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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        public virtual void RelocatingControls()
        {

        }
        public virtual void ResizeControls()
        {

        }
        public virtual void Graphicialize()
        {

        }
        protected LED_Controller _ctrl;
        public LED_Controller Controller
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
