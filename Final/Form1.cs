using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AxMapWinGIS;
using MapWinGIS;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace Final
{
    public partial class Form1 : Form
    {
        JArray items;
        double f_x;
        double f_y;
        double t_x;
        double t_y;
        int layerHandle3;
        double sum_length = 0;
        double last_agg_cost = 0;
        Utils u = new Utils();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // 맵좌표계설정
            axMap1.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            // 배경맵적용(타일맵)
            axMap1.TileProvider = tkTileProvider.OpenStreetMap;
            // 맵초기공간범위
            axMap1.KnownExtents = tkKnownExtents.keSouth_Korea;
            // 맵커서모드변경
            axMap1.CursorMode = tkCursorMode.cmPan;
            // SelectBoxFinal 이벤트 사용시 꼭!!
            axMap1.SendSelectBoxFinal = true;

            rbFrom.Checked = true;
        }

        private void axMap1_ProjectionMismatch(object sender, _DMapEvents_ProjectionMismatchEvent e)
        {
            e.reproject = tkMwBoolean.blnTrue;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbSearch.Items.Clear();

            string target = tbSearch.Text;
  
            string url = string.Format("http://api.vworld.kr/req/search?service=search&request=search&version=2.0&crs=EPSG:4326&size=1000&page=1&query={0}&type=place&format=json&errorformat=json&key=4DC3C0AD-CFCA-3277-8293-B13CADFB6A7A", target);

            // Rest API
            var client = new RestClient(url);           // RestClient : 요청(url)을 서비스제공자(서버)에게 전달하는 객체
            client.Timeout = -1;                       // 요청 시간이 너무 길면 요청 끊어라
            var request = new RestRequest(Method.GET); // 요청 처리 방식 : GET방식 : 데이터 얻기만
            IRestResponse response = client.Execute(request); // Client 일해라

       
            var result = JObject.Parse(response.Content);
            // JSON 배열로 결과 저장, JSON 배열 = [JObject1, JObject2, ...JObjectN]  JObject = Json
            items = (JArray)result["response"]["result"]["items"];          

            //// 리스트박스에 채우기
            // 리스트박스에 아이템 추가하기 : lstSearch.Items.Add("item");           
            foreach (var item in items) // var = JObject
            {
                lbSearch.Items.Add(item["title"]);
            }
        }

        private void lbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axMap1.RemoveAllLayers();

            var item = items[lbSearch.SelectedIndex];

            Shapefile sf = new Shapefile();
            sf.CreateNew("", ShpfileType.SHP_POINT);

            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POINT);
            MapWinGIS.Point p = new MapWinGIS.Point();
            p.x = Convert.ToDouble(item["point"]["x"]);
            p.y = Convert.ToDouble(item["point"]["y"]);

            int pointindex = shp.numPoints;
            shp.InsertPoint(p, ref pointindex);

            int shpindex = sf.NumShapes;
            sf.EditInsertShape(shp, ref shpindex);

            sf.GeoProjection.ImportFromEPSG(4326);

            int center = axMap1.AddLayer(sf, true);
            Shapefile sf2 = axMap1.get_Shapefile(center);
            sf2.DefaultDrawingOptions.PointSize = 15;

            axMap1.ZoomToShape(0, lbSearch.SelectedIndex);
            axMap1.CurrentScale = 5000;

            if (rbFrom.Checked == true)
            {
                tbFrom.Text = item["title"].ToString();
                f_x = p.x;
                f_y = p.y;
            }
            if (rbTo.Checked == true)
            {
                tbTo.Text = item["title"].ToString();
                t_x = p.x;
                t_y = p.y;
            }
        }
        private void btnNavi_Click(object sender, EventArgs e)
        {
            axMap1.RemoveAllLayers();
            dgvData.DataSource = null;

            string connStr = "PG:host=localhost dbname=test user=postgres password=postgres port=5433";
            string cmd;
            cmd = string.Format("select node_id from moct_node where geom = (select ST_ClosestPoint(ST_Union(geom), ST_Transform(ST_SetSRID(ST_MakePoint({0}, {1}), 4326), 5186)) from moct_node)", f_x, f_y);
            int layerHandle = axMap1.AddLayerFromDatabase(connStr, cmd, false);
            Shapefile sf = axMap1.get_Shapefile(layerHandle);
            int f_node_id = Convert.ToInt32(sf.get_CellValue(0, 0));

            cmd = string.Format("select node_id from moct_node where geom = (select ST_ClosestPoint(ST_Union(geom), ST_Transform(ST_SetSRID(ST_MakePoint({0}, {1}), 4326), 5186)) from moct_node)", t_x, t_y);
            int layerHandle2 = axMap1.AddLayerFromDatabase(connStr, cmd, false);
            Shapefile sf2 = axMap1.get_Shapefile(layerHandle2);
            int t_node_id = Convert.ToInt32(sf2.get_CellValue(0, 0));

            cmd = string.Format("select seq, edge, agg_cost, road_name, ST_Length(geom) as length, speed, ST_Transform(geom, 4326) from moct_link as x join (select * from pgr_dijkstra('select CAST(link_id as bigint) as id, CAST(f_node as bigint) as source, CAST(t_node as bigint) as target, ST_Length(geom) / speed as cost from moct_link', {0}, {1})) as y on CAST(x.link_id as bigint) = y.edge order by seq", f_node_id, t_node_id);
            layerHandle3 = axMap1.AddLayerFromDatabase(connStr, cmd, true);
            Shapefile sf3 = axMap1.get_Shapefile(layerHandle3);
            sf3.DefaultDrawingOptions.LineWidth = 7;
            double min = Convert.ToDouble(sf3.Table.MinValue[5]);
            double max = Convert.ToDouble(sf3.Table.MaxValue[5]);
            sf3.Categories.AddRange(5, tkClassificationType.ctNaturalBreaks, 5, min, max);
            sf3.Categories.get_Item(0).DrawingOptions.FillColor = u.ColorByName(tkMapColor.Green);
            sf3.Categories.get_Item(1).DrawingOptions.FillColor = u.ColorByName(tkMapColor.GreenYellow);
            sf3.Categories.get_Item(2).DrawingOptions.FillColor = u.ColorByName(tkMapColor.Yellow);
            sf3.Categories.get_Item(3).DrawingOptions.FillColor = u.ColorByName(tkMapColor.Salmon);
            sf3.Categories.get_Item(4).DrawingOptions.FillColor = u.ColorByName(tkMapColor.Red);
            sf3.Categories.ApplyExpressions();

            CreateTable();

            tbRouteLength.Text = Convert.ToString(sum_length/1000);
            tbTravelTime.Text = Convert.ToString(last_agg_cost);
        }
        private void CreateTable()
        {
            DataTable dt = new DataTable();
            Shapefile sf = axMap1.get_Shapefile(layerHandle3);
            
            for (int i = 0; i < sf.NumFields; i++)
            {
                DataColumn dc = new DataColumn();
                dc.ColumnName = sf.Table.Field[i].Name;
                dt.Columns.Add(dc);
            }
       
            for (int i = 0; i < sf.NumShapes; i++) // 행 개수
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < sf.NumFields; j++) // 컬럼개수
                {
                    if (sf.get_CellValue(j, i) != null) // null 경우 제외
                    {
                        string val = sf.get_CellValue(j, i).ToString();
                        dr[j] = val;
                    }
                }
                dt.Rows.Add(dr); // 테이블 로우 추가
            }

            // DGV의 데이터소스 할당
            dgvData.DataSource = dt;
          
            foreach (DataRow item in dt.Rows)
            {
                double length = Convert.ToDouble(item["length"]);
                sum_length += length;
                last_agg_cost = Convert.ToDouble(item["agg_cost"]);
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            axMap1.ZoomToShape(0, dgvData.CurrentRow.Index);
            axMap1.CurrentScale = 5000;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbSearch.Items.Clear();
            dgvData.DataSource = null;
            axMap1.Redraw();

            tbFrom.Text = "";
            tbTo.Text = "";
            tbSearch.Text = "";
            tbRouteLength.Text = "";
            tbTravelTime.Text = "";

            rbFrom.Checked = true;
        }
    }
}
