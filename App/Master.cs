using FreeBNS.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeBNS.App
{
    public partial class Master : Form
    {
        public static User userInfo = null;
        public static bool canUse = false;
        public static Dictionary<string, Int32> KeyMap = new Dictionary<string, Int32>();
        public Master()
        {
            InitializeComponent();
        }
    }
}
