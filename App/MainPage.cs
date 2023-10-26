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
            this.label5.Text = @"
                           免责声明
1. 本软件仅供学习和研究用途，不得用于商业目的。
2. 本软件可能包含已知或未知错误，在使用过程中可能会对您的计算机和其他
设备造成损坏或数据丢失。
3. 本软件使用过程中所产生的一切损失和责任，由用户自行承担，与软件开发
者无关。
4. 本软件使用过程中所产生的一切数据和隐私保护问题，由用户自行负责处理
和保护，与软件开发者无关。
5. 本软件使用过程中所产生的一切版权问题，由用户自行负责处理，与软件开
发者无关。
6. 用户在使用本软件时，必须遵守相关法律法规，不得侵犯他人的知识产权和
其他权利。
7. 用户在使用本软件时，必须遵守网络道德，不得进行恶意攻击、传播恶意软
件等有害信息。
8. 用户在使用本软件时，必须遵守社会道德，不得进行非法活动、欺诈等有害
行为。
                            开发者声明
1. 本软件的开发者保证软件的质量和可靠性，并对使用本软件所造成的任何损
失和责任不承担任何责任。
2. 本软件的开发者保证软件的版权和知识产权属于开发者，并对使用本软件所
造成的任何版权问题不承担任何责任。
3. 本软件的开发者保证软件的使用不违反法律法规，不侵犯他人的知识产权和
其他权利，不进行恶意攻击、传播恶意软件等有害信息。
4. 本软件的开发者保证软件的使用不违反社会道德，不进行非法活动、欺诈等
有害行为。
                           最终声明
本免责声明是用户与开发者之间达成的一致意见，用户在使用本软件时必须遵守
相关法律法规，遵守社会道德，不得进行恶意攻击、传播恶意软件等有害信息，
不得进行非法活动、欺诈等有害行为。开发者不承担因使用本软件而产生的任何
责任，用户在使用本软件时必须自行承担因使用本软件而产生的任何责任。
";
        }

        private void linkTxtRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://free-bns.com/user-create.htm");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception)
            {
                MessageBox.Show("登录失败！");
                return;
            }
        }
        //this.Dispose();
    }
}
