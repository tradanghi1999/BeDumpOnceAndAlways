using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.Show_App
{
    public partial class View : Form
    {
        private Controller _ctrl;
        public Controller Controller
        {
            set
            {
                _ctrl = value;
            }
        }
        public View()
        {
            InitializeComponent();
        }

        private void OpenNew_Click(object sender, EventArgs e)
        {
            _ctrl.OpenNew();
        }
    }
}
