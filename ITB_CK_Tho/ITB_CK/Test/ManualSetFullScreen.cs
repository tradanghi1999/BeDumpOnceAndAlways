using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ManualSetFullScreen : Form
    {
        public ManualSetFullScreen()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //if (this.WindowState != FormWindowState.Maximized)
            //    return;
            Screen onScreen = Screen.FromControl(this);
            if(onScreen != Screen.PrimaryScreen)
            {
                this.Location = onScreen.WorkingArea.Location;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
                return;
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
