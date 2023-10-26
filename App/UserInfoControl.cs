using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class UserInfoControl : UserControl
    {
        private static User user;
        private ChongZhiDialog cz;
        public UserInfoControl(User userInfo)
        {
            user = userInfo;
            InitializeComponent();
        }

        private void userInfoControl_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("请登录");
                MainPage mp = new MainPage();
                mp.ShowDialog();
                this.Hide();
                return;
            }
            cz = new ChongZhiDialog(user);
            cz.refresh += RefreshSelf;
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            this.lblUsername.Text = user.Username;
            this.lblSign.Text = user.Signature;
            this.lblRmbs.Text = user.Rmbs;
            this.lblKadaoTime.Text = TimeHelper.GetDateTime(int.Parse(user.KadaoTime)).ToString();
            this.lblGroup.Text = user.Groupname;
            this.lblGolds.Text = user.Golds;
        }

        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            cz.ShowDialog();
        }

        private void RefreshSelf()
        {
            user = ChongZhiDialog.user;
            this.Refresh();
        }
    }
}
