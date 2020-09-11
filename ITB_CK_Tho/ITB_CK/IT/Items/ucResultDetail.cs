using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT.Items
{
    public partial class ucResultDetail : UserControl
    {
        public ucResultDetail()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            App app = new App(new V_PointDetailTest());
            app.Load();
        }
    }
}
