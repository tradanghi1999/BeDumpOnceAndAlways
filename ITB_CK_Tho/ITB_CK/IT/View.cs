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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        protected IT_Controller _ctrl;
        public IT_Controller Controller {
            set
            {
                _ctrl = value;
                //if (_ctrl == null)
                //    throw new NullReferenceException();
            }
        }

        private void View_Load(object sender, EventArgs e)
        {
            //if(!(this is V_PointDetailTest))
            //    _ctrl.CheckConnection();
        }
    }
}
