using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using IT.Items;

namespace IT
{
    public partial class V_IT_Start : View
    {
        ucCheckConnection ucCheck;
        ucResultDetail ucRd;
        public V_IT_Start()
        {
            InitializeComponent();
            ucRd = new ucResultDetail();
            ucRd.Dock = DockStyle.Left;
            pnlicon.Controls.Add(ucRd);
            ucCheck = new ucCheckConnection();
            ucCheck.Dock = DockStyle.Left;
            pnlicon.Controls.Add(ucCheck);
        }

        private void BtnVong1_Click(object sender, EventArgs e)
        {
            //_ctrl.VoVong1();
            bool all = ucCheck.AllisConnected;
            //
            all = true;
            if(all)
            {
                (_ctrl as IT_Start_Controller).VoVong1();
            }
        }

        private void BtnVong2_Click(object sender, EventArgs e)
        {
            bool all = ucCheck.AllisConnected;
            //
            all = true;
            if (all)
            {
                (_ctrl as IT_Start_Controller).VoVong2();
            }
        }

        private void BtnVong3_Click(object sender, EventArgs e)
        {
            bool all = ucCheck.AllisConnected;
            //
            all = true;
            if (all)
            {
                (_ctrl as IT_Start_Controller).VoVong3();
            }
        }
    }
}
