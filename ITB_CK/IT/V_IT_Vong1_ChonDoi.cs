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
    public partial class V_IT_Vong1_ChonDoi : View
    {
        public int DiemDoi1
        {
            set
            {
                int diem = value;
                if (diem < 0)
                    lblDiemDoi1.Text = ("(chua thi)");
                else
                    lblDiemDoi1.Text = diem + "";
            }
        }
        public int DiemDoi2
        {
            set
            {
                int diem = value;
                if (diem < 0)
                    lblDiemDoi2.Text = ("(chua thi)");
                else
                    lblDiemDoi2.Text = diem + "";
            }
        }
        public int DiemDoi3
        {
            set
            {
                int diem = value;
                if (diem < 0)
                    lblDiemDoi3.Text = ("(chua thi)");
                else
                    lblDiemDoi3.Text = diem + "";
            }
        }
        public bool Doi1Done
        {
            set
            {
                btnVong1_Doi1.Enabled = !(value);
            }
        }
        public bool Doi2Done
        {
            set
            {
                btnVong1_Doi2.Enabled = !(value);
            }
        }
        public bool Doi3Done
        {
            set
            {
                btnVong1_Doi3.Enabled = !(value);
            }
        }
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

        private string teamIDPending = null;
        public string TeamIDPending
        {
            set
            {
                teamIDPending = value;
            }
        }
        public V_IT_Vong1_ChonDoi()
        {
            InitializeComponent();
        }

        private void BtnVong1_Doi1_Click(object sender, EventArgs e)
        {
            _ctrl.GetDoiThiVong1(TenDoi1);
        }

        private void BtnVong1_Doi2_Click(object sender, EventArgs e)
        {
            _ctrl.GetDoiThiVong1(TenDoi2);
        }

        private void BtnVong1_Doi3_Click(object sender, EventArgs e)
        {
            _ctrl.GetDoiThiVong1(TenDoi3);
        }

        private void BtnChiTietDiemDoi1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnChiTietDiemDoi2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnChiTietDiemDoi3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void V_IT_Vong1_ChonDoi_Load(object sender, EventArgs e)
        {
            _ctrl.GetTeams();
            _ctrl.MakeTeamsPending();
        }
    }
}
