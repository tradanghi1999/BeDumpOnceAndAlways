using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace MC
{
    public class View : Form
    {
        protected MC_Controller _controller;
        public MC_Controller Controller
        {
            set
            {
                _controller = value;
                if (_controller == null)
                    throw new NullReferenceException();
            }
        }
        public void SetController(MC_Controller ctrl)
        {
            _controller = ctrl;
        }
        public View() : base()
        {

        }
    }
}
