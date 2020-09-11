using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    public partial class V_Start : View
    {
        private int _dem = 0;
        // private MC_Controller _ctrl;

        public V_Start()
        {
            InitializeComponent();
            //_ctrl = new MC_Controller();
        }
        //public V_Start(MC_Controller ctrl)
        //{
        //    InitializeComponent();
        //    _ctrl = ctrl;
        //}

        private void V_Start_Load(object sender, EventArgs e)
        {
            tmr3dot.Enabled = true;
            tmr3dot.Interval = 300;
            tmr3dot.Start();
            //if(!_controller.CheckOnStartUp(this))
            //{
            //    this.Hide();
            //}
            //_controller.CheckOnStartUp();
            _ctrl.CheckConnection();
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

            //_controller.Check();
            //throw new NotImplementedException();
        }
    }
}
