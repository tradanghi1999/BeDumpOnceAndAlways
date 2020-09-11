using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaiLieuChuyenTin
{
    public partial class Illustration : Form
    {
        public Illustration()
        {
            InitializeComponent();
        }

        private void Illustration_Load(object sender, EventArgs e)
        {
            SourceCode a = new SourceCode();
            a.GiaiBaiToan8QuanHau();
        }
    }
}
