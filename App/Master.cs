using FreeBNS.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class Master : Form
    {
        public User userInfo = null;
        public bool canUse = false;
        public static Dictionary<string, Int32> KeyMap = new Dictionary<string, Int32>();
        public Master()
        {
            InitializeComponent();
        }
    }
}
