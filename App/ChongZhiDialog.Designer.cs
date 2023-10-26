namespace FreeBNS.App
{
    partial class ChongZhiDialog
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
            this.chongzhibili = new System.Windows.Forms.Label();
            this.lblGolds = new System.Windows.Forms.Label();
            this.txtGolds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoticeGoldsTime = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chongzhibili
            // 
            this.chongzhibili.AutoSize = true;
            this.chongzhibili.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chongzhibili.Location = new System.Drawing.Point(43, 53);
            this.chongzhibili.Name = "chongzhibili";
            this.chongzhibili.Size = new System.Drawing.Size(55, 21);
            this.chongzhibili.TabIndex = 0;
            this.chongzhibili.Text = "label1";
            // 
            // lblGolds
            // 
            this.lblGolds.AutoSize = true;
            this.lblGolds.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGolds.Location = new System.Drawing.Point(45, 100);
            this.lblGolds.Name = "lblGolds";
            this.lblGolds.Size = new System.Drawing.Size(50, 20);
            this.lblGolds.TabIndex = 1;
            this.lblGolds.Text = "label1";
            // 
            // txtGolds
            // 
            this.txtGolds.Location = new System.Drawing.Point(97, 153);
            this.txtGolds.Name = "txtGolds";
            this.txtGolds.Size = new System.Drawing.Size(100, 21);
            this.txtGolds.TabIndex = 2;
            this.txtGolds.TextChanged += new System.EventHandler(this.txtGolds_Changed);
            this.txtGolds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPressInt);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "金币数量";
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(97, 192);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 21);
            this.txtTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "兑换时间";
            // 
            // lblNoticeGoldsTime
            // 
            this.lblNoticeGoldsTime.AutoSize = true;
            this.lblNoticeGoldsTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNoticeGoldsTime.Location = new System.Drawing.Point(30, 237);
            this.lblNoticeGoldsTime.Name = "lblNoticeGoldsTime";
            this.lblNoticeGoldsTime.Size = new System.Drawing.Size(127, 20);
            this.lblNoticeGoldsTime.TabIndex = 6;
            this.lblNoticeGoldsTime.Text = "预计到期时间 *****";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOk.Location = new System.Drawing.Point(97, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 31);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "确认充值";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ChongZhiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 340);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblNoticeGoldsTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGolds);
            this.Controls.Add(this.lblGolds);
            this.Controls.Add(this.chongzhibili);
            this.Name = "ChongZhiDialog";
            this.Text = "ChongZhiDialog";
            this.Load += new System.EventHandler(this.chongZhiDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chongzhibili;
        private System.Windows.Forms.Label lblGolds;
        private System.Windows.Forms.TextBox txtGolds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoticeGoldsTime;
        private System.Windows.Forms.Button btnOk;
    }
}