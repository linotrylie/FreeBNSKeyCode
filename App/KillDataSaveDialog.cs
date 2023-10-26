using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class KillDataSaveDialog : Master
    {
        public List<Kill> list = new List<Kill>();
        public KillDataSaveDialog(List<Kill> lt)
        {
            this.list = lt;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                btnSave.Enabled = true;
                MessageBox.Show("请填写标题！");
                return;
            }
            if (userInfo == null)
            {
                btnSave.Enabled = true;
                MessageBox.Show("请登录后操作！");
                return;
            }
            string resMsg = HttpHelper.PostSaveKadaoData(userInfo.Username, textBox1.Text.Trim(), list);
            if (!string.IsNullOrEmpty(resMsg))
            {
                btnSave.Enabled = true;
                MessageBox.Show(resMsg);
                return;
            }
            btnSave.Enabled = true;
            MessageBox.Show("保存成功！");
            this.Hide();
            return;
        }

        private void KillDataSaveDialog_Load(object sender, EventArgs e)
        {
            bindListView(list);
        }

        private void bindListView(List<Kill> kills)
        {
            this.listView1.BeginUpdate();
            foreach (Kill val in kills)
            {
                int n = this.listView1.Items.Count + 1;
                ListViewItem item = new ListViewItem();
                item.ImageIndex = n;
                item.Text = n.ToString();
                item.SubItems.Add(val.KillKey);
                item.SubItems.Add(val.KillKeyDownTime.ToString() + "ms");
                item.SubItems.Add(val.KillKeyUpTime.ToString() + "ms");
                item.SubItems.Add(val.KillTime.ToString() + "s");
                this.listView1.Items.Add(item);
            }
            this.listView1.EndUpdate();
        }

    }
}
