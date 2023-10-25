
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnMid = new System.Windows.Forms.Button();
            this.btnSideSecond = new System.Windows.Forms.Button();
            this.btnSideFirst = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "卡刀功能";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(173, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 395);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
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
            // btnRight
            // 
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
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 408);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 408);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
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
    }
}