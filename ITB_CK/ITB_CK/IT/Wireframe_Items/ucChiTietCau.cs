using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITB_CK.IT.Wireframe_Items
{
    public partial class ucChiTietCau : UserControl
    {
        public int STT
        {
            set
            {
                lblCau.Text = "Câu " + value;
            }
        }
        public string NoiDung
        {
            set
            {
                rtbNoiDungCau.Text = value;
            }
        }
        public ucChiTietCau()
        {
            InitializeComponent();
        }
        public ucChiTietCau(int stt, string noiDungCau)
        {
            InitializeComponent();
            STT = stt;
            NoiDung = noiDungCau;
        }
    }
}
