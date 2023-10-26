using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class ChongZhiDialog : Form
    {
        private static KadaoBiLi kadaoBi;
        public static User user;

        public delegate void RefreshDelegate(); // 子窗口声明定义委托 refresh()
        public event RefreshDelegate refresh;

        public ChongZhiDialog(User userInfo)
        {
            user = userInfo;
            InitializeComponent();
        }

        private void chongZhiDialog_Load(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("请登录！");
                return;
            }
            kadaoBi = HttpHelper.GetKadaoBiLi();
            this.chongzhibili.Text = "当前充值比例：" + kadaoBi.Golds.ToString() + " = " + kadaoBi.Time.ToString() + "秒";
            this.lblGolds.Text = "您当前剩余" + user.Golds + "金币";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtGolds.Text) || int.Parse(txtGolds.Text) <= 0)
                {
                    return;
                }
                int golds = int.Parse(txtGolds.Text);
                int userGolds = int.Parse(user.Golds);
                if (golds > userGolds)
                {
                    MessageBox.Show("金币余额不足！");
                    return;
                }
                int czTime = int.Parse(txtGolds.Text) * kadaoBi.Time;
                User resUser = HttpHelper.ChongZhiKadaoTime(user.Username, golds, czTime);
                if (resUser != null)
                {

                    Master.userInfo = resUser;
                    user = resUser;
                    this.refresh(); // 调用委托
                    MessageBox.Show("充值成功!请关闭软件，重新登录激活使用权限！");
                    this.Close();
                    return;
                }
                MessageBox.Show("充值失败!");
                return;

            }
            catch (Exception)
            {
                MessageBox.Show("充值失败!");
                return;
            }
        }

        private void tb_KeyPressInt(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是退格和数字，则屏蔽输入
            if (!(e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9')))
            {
                e.Handled = true;
            }
        }

        private void txtGolds_Changed(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGolds.Text) || int.Parse(txtGolds.Text) <= 0)
            {
                return;
            }
            int czTime = int.Parse(txtGolds.Text) * kadaoBi.Time;
            int dqTime = 0;
            int userKdTime = int.Parse(user.KadaoTime);
            int now = int.Parse(TimeHelper.GetTimeStamp());
            this.txtTime.Text = czTime.ToString();
            if (userKdTime <= 0 || userKdTime < now)
            {
                dqTime = now + czTime;
            }
            else
            {
                dqTime = userKdTime + czTime;
            }
            string dqDateTime = TimeHelper.GetDateTime(dqTime).ToString();
            this.lblNoticeGoldsTime.Text = "预计到期时间" + dqDateTime;
        }
    }
}
