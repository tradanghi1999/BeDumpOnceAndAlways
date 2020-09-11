using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        protected Team_Controller _ctrl;
        public Team_Controller Controller
        {
            set
            {
                _ctrl = value;
                if (_ctrl == null)
                    throw new NullReferenceException();
            }
        }

    }
}
