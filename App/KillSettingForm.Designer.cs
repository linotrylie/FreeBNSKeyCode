
namespace FreeBNS.App
{
    public partial class KillSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillSettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnSideSecond = new System.Windows.Forms.Button();
            this.btnSideFirst = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnDelSelectedRow = new System.Windows.Forms.Button();
            this.btnRightLoad = new System.Windows.Forms.Button();
            this.btnSideSecondLoad = new System.Windows.Forms.Button();
            this.btnMidLoad = new System.Windows.Forms.Button();
            this.btnLeftLoad = new System.Windows.Forms.Button();
            this.btnSideFirstLoad = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.row_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.killdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.create_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(89, 3);
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 446);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "卡刀功能";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(173, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 395);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnMid);
            this.panel1.Controls.Add(this.btnSideSecond);
            this.panel1.Controls.Add(this.btnSideFirst);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 395);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Location = new System.Drawing.Point(21, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存当前页数据";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(21, 186);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(123, 36);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "鼠标右键";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(21, 144);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(123, 36);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "鼠标左键";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnMid
            // 
            this.btnMid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMid.ForeColor = System.Drawing.Color.White;
            this.btnMid.Image = ((System.Drawing.Image)(resources.GetObject("btnMid.Image")));
            this.btnMid.Location = new System.Drawing.Point(21, 102);
            this.btnMid.Name = "btnMid";
            this.btnMid.Size = new System.Drawing.Size(123, 36);
            this.btnMid.TabIndex = 2;
            this.btnMid.Text = "鼠标中键";
            this.btnMid.UseVisualStyleBackColor = true;
            this.btnMid.Click += new System.EventHandler(this.btnMid_Click);
            // 
            // btnSideSecond
            // 
            this.btnSideSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSideSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideSecond.ForeColor = System.Drawing.Color.White;
            this.btnSideSecond.Image = ((System.Drawing.Image)(resources.GetObject("btnSideSecond.Image")));
            this.btnSideSecond.Location = new System.Drawing.Point(21, 60);
            this.btnSideSecond.Name = "btnSideSecond";
            this.btnSideSecond.Size = new System.Drawing.Size(123, 36);
            this.btnSideSecond.TabIndex = 1;
            this.btnSideSecond.Text = "鼠标侧键2";
            this.btnSideSecond.UseVisualStyleBackColor = true;
            this.btnSideSecond.Click += new System.EventHandler(this.btnSideSecond_Click);
            // 
            // btnSideFirst
            // 
            this.btnSideFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSideFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideFirst.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSideFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnSideFirst.Image")));
            this.btnSideFirst.Location = new System.Drawing.Point(21, 18);
            this.btnSideFirst.Name = "btnSideFirst";
            this.btnSideFirst.Size = new System.Drawing.Size(123, 36);
            this.btnSideFirst.TabIndex = 0;
            this.btnSideFirst.Text = "鼠标侧键1";
            this.btnSideFirst.UseVisualStyleBackColor = false;
            this.btnSideFirst.Click += new System.EventHandler(this.btnSideFirst_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblPage);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblTotalPage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnNextPage);
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.btnDelSelectedRow);
            this.tabPage2.Controls.Add(this.btnRightLoad);
            this.tabPage2.Controls.Add(this.btnSideSecondLoad);
            this.tabPage2.Controls.Add(this.btnMidLoad);
            this.tabPage2.Controls.Add(this.btnLeftLoad);
            this.tabPage2.Controls.Add(this.btnSideFirstLoad);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "卡刀数据";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.No;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(578, 279);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 41);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(435, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "页";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPage.Location = new System.Drawing.Point(409, 368);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(15, 17);
            this.lblPage.TabIndex = 13;
            this.lblPage.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(384, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "第";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(511, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "页";
            // 
            // lblTotalPage
            // 
            this.lblTotalPage.AutoSize = true;
            this.lblTotalPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalPage.Location = new System.Drawing.Point(485, 368);
            this.lblTotalPage.Name = "lblTotalPage";
            this.lblTotalPage.Size = new System.Drawing.Size(15, 17);
            this.lblTotalPage.TabIndex = 10;
            this.lblTotalPage.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(460, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "共";
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.No;
            this.btnNextPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNextPage.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnNextPage.Location = new System.Drawing.Point(253, 365);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = "下一页";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.No;
            this.btnPrevious.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrevious.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPrevious.Location = new System.Drawing.Point(142, 365);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "上一页";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnDelSelectedRow
            // 
            this.btnDelSelectedRow.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelSelectedRow.Cursor = System.Windows.Forms.Cursors.No;
            this.btnDelSelectedRow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelSelectedRow.Location = new System.Drawing.Point(578, 326);
            this.btnDelSelectedRow.Name = "btnDelSelectedRow";
            this.btnDelSelectedRow.Size = new System.Drawing.Size(117, 41);
            this.btnDelSelectedRow.TabIndex = 6;
            this.btnDelSelectedRow.Text = "删除选中行";
            this.btnDelSelectedRow.UseVisualStyleBackColor = false;
            this.btnDelSelectedRow.Click += new System.EventHandler(this.button_DelRow_Click);
            // 
            // btnRightLoad
            // 
            this.btnRightLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.btnRightLoad.Location = new System.Drawing.Point(547, 214);
            this.btnRightLoad.Name = "btnRightLoad";
            this.btnRightLoad.Size = new System.Drawing.Size(200, 40);
            this.btnRightLoad.TabIndex = 5;
            this.btnRightLoad.Text = "加载选中行到右键";
            this.btnRightLoad.UseVisualStyleBackColor = true;
            this.btnRightLoad.Click += new System.EventHandler(this.btnRightLoad_Click);
            // 
            // btnSideSecondLoad
            // 
            this.btnSideSecondLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSideSecondLoad.Location = new System.Drawing.Point(547, 76);
            this.btnSideSecondLoad.Name = "btnSideSecondLoad";
            this.btnSideSecondLoad.Size = new System.Drawing.Size(200, 40);
            this.btnSideSecondLoad.TabIndex = 4;
            this.btnSideSecondLoad.Text = "加载选中行到侧键2";
            this.btnSideSecondLoad.UseVisualStyleBackColor = true;
            this.btnSideSecondLoad.Click += new System.EventHandler(this.btnSideSecondLoad_Click);
            // 
            // btnMidLoad
            // 
            this.btnMidLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.btnMidLoad.Location = new System.Drawing.Point(545, 122);
            this.btnMidLoad.Name = "btnMidLoad";
            this.btnMidLoad.Size = new System.Drawing.Size(200, 40);
            this.btnMidLoad.TabIndex = 3;
            this.btnMidLoad.Text = "加载选中行到中键";
            this.btnMidLoad.UseVisualStyleBackColor = true;
            this.btnMidLoad.Click += new System.EventHandler(this.btnMidLoad_Click);
            // 
            // btnLeftLoad
            // 
            this.btnLeftLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.btnLeftLoad.Location = new System.Drawing.Point(547, 168);
            this.btnLeftLoad.Name = "btnLeftLoad";
            this.btnLeftLoad.Size = new System.Drawing.Size(200, 40);
            this.btnLeftLoad.TabIndex = 2;
            this.btnLeftLoad.Text = "加载选中行到左键";
            this.btnLeftLoad.UseVisualStyleBackColor = true;
            this.btnLeftLoad.Click += new System.EventHandler(this.btnLeftLoad_Click);
            // 
            // btnSideFirstLoad
            // 
            this.btnSideFirstLoad.Cursor = System.Windows.Forms.Cursors.No;
            this.btnSideFirstLoad.Location = new System.Drawing.Point(547, 30);
            this.btnSideFirstLoad.Name = "btnSideFirstLoad";
            this.btnSideFirstLoad.Size = new System.Drawing.Size(200, 40);
            this.btnSideFirstLoad.TabIndex = 1;
            this.btnSideFirstLoad.Text = "加载选中行到侧键1";
            this.btnSideFirstLoad.UseVisualStyleBackColor = true;
            this.btnSideFirstLoad.Click += new System.EventHandler(this.btnSideFirstLoad_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.row_id,
            this.title,
            this.killdata,
            this.create_time});
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 352);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // row_id
            // 
            this.row_id.Text = "序号";
            // 
            // title
            // 
            this.title.Text = "标题";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 191;
            // 
            // killdata
            // 
            this.killdata.Text = "数据";
            this.killdata.Width = 111;
            // 
            // create_time
            // 
            this.create_time.Text = "创建时间";
            this.create_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.create_time.Width = 160;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 405);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "个人中心";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 393);
            this.panel3.TabIndex = 0;
            // 
            // KillSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "KillSettingForm";
            this.Text = "FreeBNS卡刀宏";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KillSettingForm_FormClosed);
            this.Load += new System.EventHandler(this.KillSettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnMid;
        private System.Windows.Forms.Button btnSideSecond;
        private System.Windows.Forms.Button btnSideFirst;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader row_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader create_time;
        private System.Windows.Forms.Button btnDelSelectedRow;
        private System.Windows.Forms.Button btnRightLoad;
        private System.Windows.Forms.Button btnSideSecondLoad;
        private System.Windows.Forms.Button btnMidLoad;
        private System.Windows.Forms.Button btnLeftLoad;
        private System.Windows.Forms.Button btnSideFirstLoad;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader killdata;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
    }
}