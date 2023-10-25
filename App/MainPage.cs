using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class MainPage : Master
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void linkTxtRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://free-bns.com/user-create.htm");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("请输入用户名！");
                return;
            }

            if (string.IsNullOrEmpty(this.txtPassword.Text.Trim()))
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            string password = Helper.MD5Encrypt32(this.txtPassword.Text.Trim());
            User user = HttpHelper.PostLogin(username, password);
            if (user == null)
            {
                MessageBox.Show("登录失败！");
                return;
            }
            userInfo = user;
            if (userInfo == null || int.Parse(TimeHelper.GetTimeStamp()) > int.Parse(userInfo.KadaoTime))
            {
                canUse = false;
            }
            else
            {
                canUse = true;
            }
            KillSettingForm KillSettingForm = new KillSettingForm();
            this.Hide();
            KillSettingForm.ShowDialog();
            //this.Dispose();
        }
    }
}
