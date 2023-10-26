using FreeBNS.Hook;
using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class KillSettingForm : Master
    {
        private KillSettingControl killControl01;
        private KillSettingControl killControl02;
        private KillSettingControl killControl03;
        private KillSettingControl killControl04;
        private KillSettingControl killControl05;
        private UserInfoControl userInfoControl;

        MouseHook mh;
        MouseEventArgs mouseDown1;
        MouseEventArgs mouseDown2;
        MouseEventArgs mouseDown3;
        MouseEventArgs mouseDown4;
        MouseEventArgs mouseDown5;

        private object obj = new object();
        System.Timers.Timer timer1 = new System.Timers.Timer();
        System.Timers.Timer timer2 = new System.Timers.Timer();
        System.Timers.Timer timer3 = new System.Timers.Timer();
        System.Timers.Timer timer4 = new System.Timers.Timer();
        System.Timers.Timer timer5 = new System.Timers.Timer();

        private string buttonEvent = "";

        private int index = 1;

        private static string page = "1";
        private static string totalPage = "1";
        private static string pageSize = "14";

        public KillSettingForm()
        {
            this.init_Timer();
            InitializeComponent();
        }

        void init_Timer()
        {
            timer1.Interval = 100;
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer1.AutoReset = true;

            timer2.Interval = 100;
            timer2.Elapsed += new System.Timers.ElapsedEventHandler(timer2_Tick);
            timer2.AutoReset = true;

            timer3.Interval = 100;
            timer3.Elapsed += new System.Timers.ElapsedEventHandler(timer3_Tick);
            timer3.AutoReset = true;

            timer4.Interval = 100;
            timer4.Elapsed += new System.Timers.ElapsedEventHandler(timer4_Tick);
            timer4.AutoReset = true;

            timer5.Interval = 100;
            timer5.Elapsed += new System.Timers.ElapsedEventHandler(timer5_Tick);
            timer5.AutoReset = true;
        }


        private void KillSettingForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (userInfo == null)
                {
                    MainPage mp = new MainPage();
                    mp.ShowDialog();
                    this.Hide();
                    return;
                }
                KeyMap = Keyboard.getKeyMap();
                killControl01 = new KillSettingControl(1);
                killControl02 = new KillSettingControl(2);
                killControl03 = new KillSettingControl(3);
                killControl04 = new KillSettingControl(4);
                killControl05 = new KillSettingControl(5);
                userInfoControl = new UserInfoControl(userInfo);
                if (this.index == 1)
                {
                    this.btnSideFirst.BackColor = Color.MediumSeaGreen;
                    this.btnSideSecond.BackColor = Color.Transparent;
                    this.btnMid.BackColor = Color.Transparent;
                    this.btnLeft.BackColor = Color.Transparent;
                    this.btnRight.BackColor = Color.Transparent;
                    killControl01.Show();
                    panel2.Controls.Clear();
                    panel2.Controls.Add(killControl01);
                }
                //开始监听鼠标键位活动
                startMouseClickEvent();
                //加载卡刀数据列表
                KadaoDataList(page, pageSize);
            }
            catch (Exception)
            {
                MessageBox.Show("请稍后~");
                return;
            }
        }
        private void startMouseClickEvent()
        {
            if (canUse)
            {
                mh = new MouseHook();
                mh.SetHook();
                mh.MouseClickDownEvent += mh_MouseClickDownEvent;
                mh.MouseClickUpEvent += mh_MouseClickUpEvent;
            }
            else
            {
                MessageBox.Show("没有使用时长了，请前去个人中心充值！");
            }
        }

        void timer1_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(100);
                longMouseDown(this.mouseDown1);
            }
        }
        void timer2_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(100);
                longMouseDown(this.mouseDown2);
            }
        }
        void timer3_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(100);
                longMouseDown(this.mouseDown3);
            }
        }
        void timer4_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(100);
                longMouseDown(this.mouseDown4);
            }
        }
        void timer5_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            lock (obj)
            {
                System.Threading.Thread.Sleep(100);
                longMouseDown(this.mouseDown5);
            }
        }

        private bool mh_MouseClickUpEvent(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString() == "None")
            {
                return true;
            }
            switch (e.Button.ToString())
            {
                case "Left":
                    this.mouseDown4 = e;
                    timer4.Stop();
                    break;
                case "Right":
                    this.mouseDown5 = e;
                    timer5.Stop();
                    break;
                case "Middle":
                    this.mouseDown3 = e;
                    timer3.Stop();
                    break;
                case "XButton1":
                    this.mouseDown1 = e;
                    timer1.Stop();
                    break;
                case "XButton2":
                    this.mouseDown2 = e;
                    timer2.Stop();
                    break;
            }
            //System.Diagnostics.Debug.WriteLine(e.X + "-" + e.Y + "-" + e.Button + "弹起");
            return false;
        }

        private bool mh_MouseClickDownEvent(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button.ToString() == "None")
                {
                    return false;
                }

                switch (e.Button.ToString())
                {
                    case "Left":
                        this.mouseDown4 = e;
                        timer4.Start();
                        break;
                    case "Right":
                        this.mouseDown5 = e;
                        timer5.Start();
                        break;
                    case "Middle":
                        this.mouseDown3 = e;
                        timer3.Start();
                        break;
                    case "XButton1":
                        this.mouseDown1 = e;
                        timer1.Start();
                        break;
                    case "XButton2":
                        this.mouseDown2 = e;
                        timer2.Start();
                        break;
                }
                //System.Diagnostics.Debug.WriteLine(e.X + "-" + e.Y + "-" + e.Button + "按下");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("请稍后~");
                return false;
            }
        }

        private void longMouseDown(MouseEventArgs e)
        {
            this.buttonEvent = e.Button.ToString();
            this.start_kill_loop(this.buttonEvent);
        }

        private void start_kill_loop(string button)
        {
            switch (button)
            {
                case "Left":
                    go_skill(4, KillSettingControl.getKillList(4), KillSettingControl.getIsOpen(4));
                    break;
                case "Right":
                    go_skill(5, KillSettingControl.getKillList(5), KillSettingControl.getIsOpen(5));
                    break;
                case "Middle":
                    go_skill(3, KillSettingControl.getKillList(3), KillSettingControl.getIsOpen(3));
                    break;
                case "XButton1":
                    go_skill(1, KillSettingControl.getKillList(1), KillSettingControl.getIsOpen(1));
                    break;
                case "XButton2":
                    go_skill(2, KillSettingControl.getKillList(2), KillSettingControl.getIsOpen(2));
                    break;
            }
        }

        private void go_skill(int n, List<Kill> kills, bool isOpen)
        {
            //System.Diagnostics.Debug.WriteLine("进入技能释放循环");
            //System.Diagnostics.Debug.WriteLine(JsonHelper.JsonSerializer<List<Kill>>(kills));
            if (kills.Count < 1 || !isOpen)
            {
                //System.Diagnostics.Debug.WriteLine("提前返回了");
                return;
            }
            //System.Diagnostics.Debug.WriteLine(kills.ToString());
            foreach (Kill val in kills)
            {
                string v = TimeHelper.GetTimeStamp();
                int nowTimestamp = int.Parse(v);
                System.Diagnostics.Debug.WriteLine(val.KillKey + " " + val.KillTime + " " + val.KillLastUseTime + " " + nowTimestamp);
                if (val.KillLastUseTime == 0 || (nowTimestamp - val.KillLastUseTime) >= val.KillTime)
                {
                    if (val.KillKey.Contains("+"))
                    {
                        string[] keys = val.KillKey.Split(new char[] { '+' });
                        byte[] values = new byte[keys.Length];
                        for (int i = 0; i < keys.Length; i++)
                        {
                            int v1;
                            KeyMap.TryGetValue(keys[i].ToUpper(), out v1);
                            values[i] = (byte)v1;
                        }
                        //System.Diagnostics.Debug.WriteLine(val.KillKey + " " + keys.Length + " " + keys.ToString() + " " + values[0] + " " + values[1]);
                        Keyboard.HoldGroupKey(values, val.KillKeyDownTime, val.KillKeyUpTime);
                    }
                    else
                    {
                        int v2;
                        KeyMap.TryGetValue(val.KillKey.ToUpper(), out v2);
                        Keyboard.HoldKey((byte)v2, val.KillKeyDownTime, val.KillKeyUpTime);
                    }
                    val.KillLastUseTime = nowTimestamp;
                    //System.Diagnostics.Debug.WriteLine(val.KillKey + " " + val.KillTime + " " + val.KillLastUseTime);
                }

                //System.Diagnostics.Debug.WriteLine(val.KillKey + " " + val.KillTime + " " + val.KillLastUseTime + " " + val.KillLastUseTime);
            }
            //System.Diagnostics.Debug.WriteLine("释放完成后：" + JsonHelper.JsonSerializer<List<Kill>>(kills));
            return;
        }

        private void tabControl1_SelectIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }
            if (tabControl1.SelectedIndex == 1)
            {
                //KadaoDataList(page, pageSize);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                userInfoControl.Show();
                panel3.Controls.Clear();
                panel3.Controls.Add(userInfoControl);
            }
        }

        private void btnSideFirst_Click(object sender, EventArgs e)
        {
            this.btnSideFirst.BackColor = Color.MediumSeaGreen;
            this.btnSideSecond.BackColor = Color.Transparent;
            this.btnMid.BackColor = Color.Transparent;
            this.btnLeft.BackColor = Color.Transparent;
            this.btnRight.BackColor = Color.Transparent;
            this.index = 1;
            killControl01.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(killControl01);
        }

        private void btnSideSecond_Click(object sender, EventArgs e)
        {
            this.btnSideFirst.BackColor = Color.Transparent;
            this.btnSideSecond.BackColor = Color.MediumSeaGreen;
            this.btnMid.BackColor = Color.Transparent;
            this.btnLeft.BackColor = Color.Transparent;
            this.btnRight.BackColor = Color.Transparent;
            this.index = 2;
            killControl02.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(killControl02);
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            this.btnSideFirst.BackColor = Color.Transparent;
            this.btnSideSecond.BackColor = Color.Transparent;
            this.btnMid.BackColor = Color.MediumSeaGreen;
            this.btnLeft.BackColor = Color.Transparent;
            this.btnRight.BackColor = Color.Transparent;
            this.index = 3;
            killControl03.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(killControl03);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.btnSideFirst.BackColor = Color.Transparent;
            this.btnSideSecond.BackColor = Color.Transparent;
            this.btnMid.BackColor = Color.Transparent;
            this.btnLeft.BackColor = Color.MediumSeaGreen;
            this.btnRight.BackColor = Color.Transparent;
            this.index = 4;
            killControl04.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(killControl04);
        }


        private void btnRight_Click(object sender, EventArgs e)
        {
            this.btnSideFirst.BackColor = Color.Transparent;
            this.btnSideSecond.BackColor = Color.Transparent;
            this.btnMid.BackColor = Color.Transparent;
            this.btnLeft.BackColor = Color.Transparent;
            this.btnRight.BackColor = Color.MediumSeaGreen;
            this.index = 5;
            killControl05.Show();
            panel2.Controls.Clear();
            panel2.Controls.Add(killControl05);
        }

        private void KillSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ZDYHook.RemoveHook();
            if (canUse)
            {
                mh.UnHook();
            }
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            KillDataSaveDialog kd = new KillDataSaveDialog(KillSettingControl.getKillList(this.index));
            kd.ShowDialog();
        }

        private void KadaoDataList(string tpage, string page_size)
        {
            try
            {
                if (userInfo == null)
                {
                    MessageBox.Show("请登录后操作！");
                    return;
                }
                //Data data = null;
                Data data = HttpHelper.GetMyKadaoDataList(userInfo.Username, page_size, tpage);
                if (data == null)
                {
                    this.lblTotalPage.Text = "1";
                    totalPage = "1";
                    page = "1";
                    this.lblPage.Text = "1";
                    return;
                }
                bindListView(data);
                this.lblTotalPage.Text = data.TotalPage.ToString();
                totalPage = data.TotalPage.ToString();
                page = tpage;
                this.lblPage.Text = tpage;
            }
            catch (Exception)
            {
                MessageBox.Show("没有数据!");
                return;
            }

        }


        private void bindListView(Data data)
        {
            this.listView1.Items.Clear();
            this.listView1.BeginUpdate();
            foreach (MyKadaoData val in data.List)
            {
                int n = this.listView1.Items.Count + 1;
                ListViewItem item = new ListViewItem();
                item.ImageIndex = n;
                item.Text = n.ToString();
                item.SubItems.Add(val.Title);
                item.SubItems.Add(val.Data);
                item.SubItems.Add(val.CreateTime.ToString());
                this.listView1.Items.Add(item);
            }
            this.listView1.EndUpdate();

        }

        private void setKillList(int n)
        {
            string str = listView1.SelectedItems[0].SubItems[2].Text;
            List<Kill> kills = JsonHelper.JsonDeserialize<List<Kill>>(HttpUtility.HtmlDecode(str));
            switch (n)
            {
                case 1:
                    killControl01.setKillList(n, kills);
                    break;
                case 2:
                    killControl02.setKillList(n, kills);
                    break;
                case 3:
                    killControl03.setKillList(n, kills);
                    break;
                case 4:
                    killControl04.setKillList(n, kills);
                    break;
                case 5:
                    killControl05.setKillList(n, kills);
                    break;
            }
        }

        private void btnSideFirstLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    setKillList(1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("遇到些问题~");
                return;
            }

        }

        private void btnSideSecondLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    setKillList(2);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("遇到些问题~");
                return;
            }
        }

        private void btnMidLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    setKillList(3);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("遇到些问题~");
                return;
            }
        }

        private void btnLeftLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    setKillList(4);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("遇到些问题~");
                return;
            }
        }

        private void btnRightLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedIndices != null && listView1.SelectedIndices.Count > 0)
                {
                    setKillList(5);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("遇到些问题~");
                return;
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (!this.btnNextPage.Enabled)
            { return; }
            this.btnNextPage.Enabled = false;
            int newpage = int.Parse(page) + 1;
            int nowTotalPage = int.Parse(totalPage);
            if (newpage > nowTotalPage)
            {
                this.btnNextPage.Enabled = true;
                return;
            }
            KadaoDataList(newpage.ToString(), pageSize);
            this.btnNextPage.Enabled = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //当程序进来判断Enabled状态,若是false表示上一次未执行完,
            if (!this.btnPrevious.Enabled)
            { return; }
            this.btnPrevious.Enabled = false;
            int newpage = int.Parse(page) - 1;
            if (newpage < 1)
            {
                this.btnPrevious.Enabled = true;
                return;
            }
            KadaoDataList(newpage.ToString(), pageSize);
            this.btnPrevious.Enabled = true;
        }

        //“清除选定行”按钮，清除选择的行
        private void button_DelRow_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)//判断lv有被选中项
            {
                string kid = listView1.SelectedItems[0].SubItems[0].Text;
                if (!HttpHelper.DelMyKadaoData(userInfo.Username, kid))
                {
                    MessageBox.Show("删除失败！");
                    return;
                }
                listView1.Items.Remove(listView1.SelectedItems[0]);   //按项移除
            }
            KadaoDataList("1", pageSize);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //当程序进来判断Enabled状态,若是false表示上一次未执行完,
            if (!this.btnRefresh.Enabled)
            { return; }
            this.btnRefresh.Enabled = false;
            KadaoDataList(page, pageSize);
            this.btnRefresh.Enabled = true;
        }
    }
}
