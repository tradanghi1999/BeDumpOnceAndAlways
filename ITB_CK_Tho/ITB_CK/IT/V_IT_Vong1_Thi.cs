using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using IT.Items;

namespace IT
{
    
    public partial class V_IT_Vong1_Thi : View
    {
        public string CurrentPoint
        {
            get
            {
                return lblDiem.Text;
            }
            set
            {
                lblDiem.Text = "Điểm: " + value;
            }
        }
        public string RightAnswerRate
        {
            get
            {
                return lblSoCauDung.Text;
            }
            set
            {
                lblSoCauDung.Text = "Đúng: " + value;
            }
        }
        public string QuestionNumText
        {
            get
            {
                return lblCau.Text;
            }
            set
            {
                lblCau.Text = "Câu " + value + ":";
            }
        }
        public string QuestionText
        {
            get
            {
                return rtbCauHoi.Text;
            }
            set
            {
                rtbCauHoi.Text = value;
            }
        }
        public string AnswerKey
        {
            get
            {
                return txbDapAn.Text;
            }
            set
            {
                txbDapAn.Text = value;
            }
        }

        public V_IT_Vong1_Thi()
        {
            InitializeComponent();

            ucResultDetail ucRd = new ucResultDetail();
            ucRd.Dock = DockStyle.Left;
            pnlicon.Controls.Add(ucRd);
            ucCheckConnection ucCheck = new ucCheckConnection();
            ucCheck.Dock = DockStyle.Left;
            pnlicon.Controls.Add(ucCheck);

            
        }



        private void BtnDung_Click(object sender, EventArgs e)
        {
            if(_ctrl is IT_Vong1Thi_Controller)
            {
                IT_Vong1Thi_Controller ctrl = _ctrl as IT_Vong1Thi_Controller;
                ctrl.SetRight();
            }
        }

        private void BtnSai_Click(object sender, EventArgs e)
        {
            if (_ctrl is IT_Vong1Thi_Controller)
            {
                IT_Vong1Thi_Controller ctrl = _ctrl as IT_Vong1Thi_Controller;
                ctrl.SetWrong();
            }
        }

        private void BtnBoQua_Click(object sender, EventArgs e)
        {
            if (_ctrl is IT_Vong1Thi_Controller)
            {
                IT_Vong1Thi_Controller ctrl = _ctrl as IT_Vong1Thi_Controller;
                ctrl.SetWrong();
            }
        }
    }
}
