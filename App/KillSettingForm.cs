using FreeBNS.Hook;
using FreeBNS.Model;
using FreeBNS.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class KillSettingForm : Master
    {
        private UserControl killControl01;
        private UserControl killControl02;
        private UserControl killControl03;
        private UserControl killControl04;
        private UserControl killControl05;

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
            KeyMap = Keyboard.getKeyMap();
            killControl01 = new KillSettingControl(1);
            killControl02 = new KillSettingControl(2);
            killControl03 = new KillSettingControl(3);
            killControl04 = new KillSettingControl(4);
            killControl05 = new KillSettingControl(5);
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
            if (!canUse)
            {
                mh = new MouseHook();
                mh.SetHook();
                mh.MouseClickDownEvent += mh_MouseClickDownEvent;
                mh.MouseClickUpEvent += mh_MouseClickUpEvent;
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
            System.Diagnostics.Debug.WriteLine(e.X + "-" + e.Y + "-" + e.Button + "弹起");
            return false;
        }

        private bool mh_MouseClickDownEvent(object sender, MouseEventArgs e)
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
            System.Diagnostics.Debug.WriteLine(e.X + "-" + e.Y + "-" + e.Button + "按下");
            return true;
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
                    go_skill(KillSettingControl.getKillList(4), KillSettingControl.getIsOpen(4));
                    break;
                case "Right":
                    go_skill(KillSettingControl.getKillList(5), KillSettingControl.getIsOpen(5));
                    break;
                case "Middle":
                    go_skill(KillSettingControl.getKillList(3), KillSettingControl.getIsOpen(3));
                    break;
                case "XButton1":
                    go_skill(KillSettingControl.getKillList(1), KillSettingControl.getIsOpen(1));
                    break;
                case "XButton2":
                    go_skill(KillSettingControl.getKillList(2), KillSettingControl.getIsOpen(2));
                    break;
            }
        }

        private void go_skill(List<Kill> kills, bool isOpen)
        {
            string v = TimeHelper.GetTimeStamp();
            int nowTimestamp = int.Parse(v);
            if (kills.Count < 1 || !isOpen)
            {
                return;
            }
            foreach (Kill val in kills)
            {
                if (val.KillLastUseTime == 0 || (nowTimestamp - val.KillLastUseTime) >= val.KillTime)
                {
                    if (val.KillKey.Contains("+"))
                    {
                        string[] keys = val.KillKey.Split(new char[] { '+' });
                        byte[] values = new byte[keys.Length];
                        for (int i = 0; i < keys.Length; i++)
                        {
                            int v1;
                            KeyMap.TryGetValue(keys[i], out v1);
                            values[i] = (byte)v1;
                        }
                        System.Diagnostics.Debug.WriteLine(val.KillKey + " " + keys.Length + " " + keys.ToString() + " " + values[0] + " " + values[1]);
                        Keyboard.HoldGroupKey(values, val.KillKeyUpTime);
                    }
                    else
                    {
                        int v2;
                        KeyMap.TryGetValue(val.KillKey, out v2);
                        Keyboard.HoldKey((byte)v2, val.KillKeyUpTime);
                    }
                    val.KillLastUseTime = nowTimestamp;
                }
                System.Diagnostics.Debug.WriteLine(val.KillKey + " " + val.KillTime);
            }
        }

        private void tabControl1_SelectIndexChanged(object sender, EventArgs e)
        {

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
            mh.UnHook();
            Application.Exit();
        }
    }
}
