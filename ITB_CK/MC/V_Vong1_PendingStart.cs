using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC
{
    public partial class V_Vong1_PendingStart : View
    {
        private int _dem=0;
        
        public V_Vong1_PendingStart()
        {
            InitializeComponent();
        }
        
        private void V_Start_Load(object sender, EventArgs e)
        {
            tmr3dot.Enabled = true;
            tmr3dot.Interval = 300;
            tmr3dot.Start();
           // _ctrl.CheckOnStartUp();
        }

        private void Tmr3dot_Tick(object sender, EventArgs e)
        {
            if (_dem == 4)
            {
                _dem = 1;
            }
            else
            {
                _dem++;
            }

            if (_dem == 1)
            {
                lbl3dot.Text = ".";
            }
            else if (_dem == 2)
            {
                lbl3dot.Text = "." + ".";
            }
            else if (_dem == 3)
            {
                lbl3dot.Text = "." + "." + ".";
            }


        }
    }
}
