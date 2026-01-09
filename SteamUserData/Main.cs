using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamUserData
{
    public partial class Main : AntdUI.Window
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Input_Leave(object sender, EventArgs e)
        {
            if (sender is Input textBox)
            {
                // 取消文本选择
                textBox.SelectionLength = 0;
            }
        }

    }
}
