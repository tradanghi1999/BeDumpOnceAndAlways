using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT
{
    public partial class V_IT_Vong3_Ready : View
    {
        public V_IT_Vong3_Ready()
        {
            InitializeComponent();
        }

        private void BtnGetReady_Click(object sender, EventArgs e)
        {
            //
            if (_ctrl is IT_Vong3_GetReady_Controller)
                (_ctrl as IT_Vong3_GetReady_Controller).MakeReady();
            btnGetReady.Enabled = false;
            //btnVoThi.Enabled = true;
            App app = new App(new V_IT_Vong3());
            app.Load();
        }

        private void BtnVoThi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
