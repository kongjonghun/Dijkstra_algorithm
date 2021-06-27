
namespace Final
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.rbTo = new System.Windows.Forms.RadioButton();
            this.rbFrom = new System.Windows.Forms.RadioButton();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTravelTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRouteLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.ListBox();
            this.btnNavi = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.dgvData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            this.splitContainer1.Panel1.Controls.Add(this.rbTo);
            this.splitContainer1.Panel1.Controls.Add(this.rbFrom);
            this.splitContainer1.Panel1.Controls.Add(this.tbTo);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tbFrom);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.tbTravelTime);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.tbRouteLength);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.lbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnNavi);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(903, 623);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(96, 583);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "초기화";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // rbTo
            // 
            this.rbTo.AutoSize = true;
            this.rbTo.Location = new System.Drawing.Point(96, 11);
            this.rbTo.Name = "rbTo";
            this.rbTo.Size = new System.Drawing.Size(59, 16);
            this.rbTo.TabIndex = 18;
            this.rbTo.TabStop = true;
            this.rbTo.Text = "도착지";
            this.rbTo.UseVisualStyleBackColor = true;
            // 
            // rbFrom
            // 
            this.rbFrom.AutoSize = true;
            this.rbFrom.Location = new System.Drawing.Point(30, 11);
            this.rbFrom.Name = "rbFrom";
            this.rbFrom.Size = new System.Drawing.Size(59, 16);
            this.rbFrom.TabIndex = 17;
            this.rbFrom.TabStop = true;
            this.rbFrom.Text = "출발지";
            this.rbFrom.UseVisualStyleBackColor = true;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(63, 381);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(110, 21);
            this.tbTo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "도착지:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(63, 354);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(110, 21);
            this.tbFrom.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "출발지:";
            // 
            // tbTravelTime
            // 
            this.tbTravelTime.Location = new System.Drawing.Point(77, 535);
            this.tbTravelTime.Name = "tbTravelTime";
            this.tbTravelTime.Size = new System.Drawing.Size(96, 21);
            this.tbTravelTime.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "예상 소요시간(분):";
            // 
            // tbRouteLength
            // 
            this.tbRouteLength.Location = new System.Drawing.Point(77, 476);
            this.tbRouteLength.Name = "tbRouteLength";
            this.tbRouteLength.Size = new System.Drawing.Size(96, 21);
            this.tbRouteLength.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "총 길이(km):";
            // 
            // lbSearch
            // 
            this.lbSearch.FormattingEnabled = true;
            this.lbSearch.ItemHeight = 12;
            this.lbSearch.Location = new System.Drawing.Point(12, 63);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(161, 280);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSearch_MouseDoubleClick);
            // 
            // btnNavi
            // 
            this.btnNavi.Location = new System.Drawing.Point(96, 411);
            this.btnNavi.Name = "btnNavi";
            this.btnNavi.Size = new System.Drawing.Size(77, 23);
            this.btnNavi.TabIndex = 3;
            this.btnNavi.Text = "길찾기";
            this.btnNavi.UseVisualStyleBackColor = true;
            this.btnNavi.Click += new System.EventHandler(this.btnNavi_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(122, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 34);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(104, 21);
            this.tbSearch.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axMap1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvData);
            this.splitContainer2.Size = new System.Drawing.Size(717, 623);
            this.splitContainer2.SplitterDistance = 434;
            this.splitContainer2.TabIndex = 0;
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(0, 0);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(717, 434);
            this.axMap1.TabIndex = 0;
            this.axMap1.ProjectionMismatch += new AxMapWinGIS._DMapEvents_ProjectionMismatchEventHandler(this.axMap1_ProjectionMismatch);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(717, 185);
            this.dgvData.TabIndex = 0;
            this.dgvData.DoubleClick += new System.EventHandler(this.dgvData_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 623);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "공간DB 길찾기 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.RadioButton rbTo;
        private System.Windows.Forms.RadioButton rbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTravelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRouteLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbSearch;
        private System.Windows.Forms.Button btnNavi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvData;
        private AxMapWinGIS.AxMap axMap1;
    }
}

