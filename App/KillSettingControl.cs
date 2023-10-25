using FreeBNS.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class KillSettingControl : UserControl
    {
        private int index;

        private static List<Kill> kill01 = new List<Kill>();
        private static List<Kill> kill02 = new List<Kill>();
        private static List<Kill> kill03 = new List<Kill>();
        private static List<Kill> kill04 = new List<Kill>();
        private static List<Kill> kill05 = new List<Kill>();

        private static bool ck01;
        private static bool ck02;
        private static bool ck03;
        private static bool ck04;
        private static bool ck05;

        public KillSettingControl(int n)
        {
            index = n;

            InitializeComponent();
        }

        public KillSettingControl()
        {
            InitializeComponent();
        }

        private void ckIsOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckIsOpen.Checked)
            {
                switch (index)
                {
                    case 1:
                        ck01 = ckIsOpen.Checked;
                        break;
                    case 2:
                        ck02 = ckIsOpen.Checked;
                        break;
                    case 3:
                        ck03 = ckIsOpen.Checked;
                        break;
                    case 4:
                        ck04 = ckIsOpen.Checked;
                        break;
                    case 5:
                        ck05 = ckIsOpen.Checked;
                        break;
                }
            }

            if (!ckIsOpen.Checked)
            {
                switch (index)
                {
                    case 1:
                        ck01 = ckIsOpen.Checked;
                        break;
                    case 2:
                        ck02 = ckIsOpen.Checked;
                        break;
                    case 3:
                        ck03 = ckIsOpen.Checked;
                        break;
                    case 4:
                        ck04 = ckIsOpen.Checked;
                        break;
                    case 5:
                        ck05 = ckIsOpen.Checked;
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox2.Text) || string.IsNullOrEmpty(this.textBox3.Text) || string.IsNullOrEmpty(this.textBox4.Text))
            {
                MessageBox.Show("请填写完整技能键位！");
                return;
            }
            this.listView1.BeginUpdate();
            int n = this.listView1.Items.Count + 1;
            ListViewItem item = new ListViewItem();
            item.ImageIndex = n;
            item.Text = n.ToString();
            item.SubItems.Add(this.textBox1.Text);
            item.SubItems.Add(this.textBox4.Text);
            item.SubItems.Add(this.textBox3.Text);
            item.SubItems.Add(this.textBox2.Text);
            this.listView1.Items.Add(item);
            this.listView1.EndUpdate();
            Kill kill = new Kill();
            kill.KillKey = this.textBox1.Text;
            kill.KillKeyDownTime = int.Parse(this.textBox4.Text);
            kill.KillKeyUpTime = int.Parse(this.textBox3.Text);
            kill.KillTime = int.Parse(this.textBox2.Text);
            if (this.index == 1)
            {
                this.ckIsOpen.Checked = ck01;
                kill01.Add(kill);
            }
            if (this.index == 2)
            {
                this.ckIsOpen.Checked = ck02;
                kill02.Add(kill);
            }
            if (this.index == 3)
            {
                this.ckIsOpen.Checked = ck03;
                kill03.Add(kill);
            }
            if (this.index == 4)
            {
                this.ckIsOpen.Checked = ck04;
                kill04.Add(kill);
            }
            if (this.index == 5)
            {
                this.ckIsOpen.Checked = ck05;
                kill05.Add(kill);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KillSettingControl_Load(object sender, EventArgs e)
        {
            if (this.index == 1 && kill01 != null)
            {
                this.bindListView(kill01);
            }
            if (this.index == 2 && kill02 != null)
            {
                this.bindListView(kill02);
            }
            if (this.index == 3 && kill03 != null)
            {
                this.bindListView(kill03);
            }
            if (this.index == 4 && kill04 != null)
            {
                this.bindListView(kill04);
            }
            if (this.index == 5 && kill05 != null)
            {
                this.bindListView(kill05);
            }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = "0";
            this.textBox3.Text = "50";
        }

        public static List<Kill> getKillList(int index)
        {
            if (index == 1 && kill01 != null)
            {
                return kill01;
            }
            if (index == 2 && kill02 != null)
            {
                return kill02;
            }
            if (index == 3 && kill03 != null)
            {
                return kill03;
            }
            if (index == 4 && kill04 != null)
            {
                return kill04;
            }
            if (index == 5 && kill05 != null)
            {
                return kill05;
            }
            return null;
        }

        public static bool getIsOpen(int index)
        {
            if (index == 1 && ck01)
            {
                return true;
            }
            if (index == 2 && ck01)
            {
                return true;
            }
            if (index == 3 && ck01)
            {
                return true;
            }
            if (index == 4 && ck01)
            {
                return true;
            }
            if (index == 5 && ck01)
            {
                return true;
            }
            return false;
        }
    }
}
