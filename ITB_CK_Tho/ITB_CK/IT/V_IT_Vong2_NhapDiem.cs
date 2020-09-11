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
    public partial class V_IT_Vong2_NhapDiem : View
    {
        public string IDDoi1 { get; set; }
        public string IDDoi2 { get; set; }
        public string IDDoi3 { get; set; }
        public string TenDoi1
        {
            get
            {
                return lblTenDoi1.Text;
            }
            set
            {
                lblTenDoi1.Text = value;
            }
        }
        public string TenDoi2
        {
            get
            {
                return lblTenDoi2.Text;
            }
            set
            {
                lblTenDoi2.Text = value;
            }
        }
        public string TenDoi3
        {
            get
            {
                return lblTenDoi3.Text;
            }
            set
            {
                lblTenDoi3.Text = value;
            }
        }
        public V_IT_Vong2_NhapDiem()
        {
            InitializeComponent();
        }

        private void NhapDiem(string teamId, string pointText)
        {
            int point = 0;
            if(int.TryParse(pointText,out point))
            {
                if(_ctrl is IT_Vong2NhapDiem_Controller)
                {
                    (_ctrl as IT_Vong2NhapDiem_Controller).InsertPointRound2(teamId, point);
                }
            }
        }

        private void BtnNhapDiemDoi1_Click(object sender, EventArgs e)
        {
            NhapDiem(IDDoi1, txbDiemDoi1.Text);
        }

        private void BtnNhapDiemDoi2_Click(object sender, EventArgs e)
        {
            NhapDiem(IDDoi2, txbDiemDoi2.Text);
        }

        private void BtnNhapDiemDoi3_Click(object sender, EventArgs e)
        {
            NhapDiem(IDDoi3, txbDiemDoi3.Text);
        }

        private void V_IT_Vong2_NhapDiem_Load(object sender, EventArgs e)
        {
            if (_ctrl is IT_Vong2NhapDiem_Controller)
            {
                (_ctrl as IT_Vong2NhapDiem_Controller).GetTeams();
            }
        }
    }
}
