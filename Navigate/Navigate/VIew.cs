using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navigate
{
    public partial class VIew : Form
    {
        private Ctrl _ctrl;
        public VIew()
        {
            InitializeComponent();
        }
        public VIew(Ctrl ctrl)
        {
            InitializeComponent();
            _ctrl = ctrl;
            _ctrl.TheView = this;
        }
    }
}
