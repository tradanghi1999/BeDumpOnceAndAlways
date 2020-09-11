using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MC
{
    public partial class V_MC_Vong3 : View
    {
        public V_MC_Vong3()
        {
            InitializeComponent();
        }

        private void LblDoi2_Click(object sender, EventArgs e)
        {

        }

        public string TenDoi
        {

            set
            {
                lblTitleCon.Text = "Vòng 1 - Đội " + value;
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
        public string IDDoi1 { get; set; }
        public string IDDoi2 { get; set; }
        public string IDDoi3 { get; set; }
        public string TenDoi1
        {
            get
            {
                return lblDoi1.Text;
            }

            set
            {
                lblDoi1.Text = value;
            }
        }
        public string TenDoi3
        {
            get
            {
                return lblDoi3.Text;
            }

            set
            {
                lblDoi3.Text = value;
            }
        }
        public string TenDoi2
        {
            get
            {
                return lblDoi2.Text;
            }

            set
            {
                lblDoi2.Text = value;
            }
        }

        public int DiemDoi1
        {
            get
            {
                int i = 0;
                int.TryParse(lblDiemDoi1.Text, out i);
                return i;
            }
            set
            {
                lblDiemDoi1.Text = value + "";
            }
        }
        public int DiemDoi2
        {
            get
            {
                int i = 0;
                int.TryParse(lblDiemDoi2.Text, out i);
                return i;
            }
            set
            {
                lblDiemDoi2.Text = value + "";
            }
        }

        public int DiemDoi3
        {
            get
            {
                int i = 0;
                int.TryParse(lblDiemDoi3.Text, out i);
                return i;
            }
            set
            {
                lblDiemDoi3.Text = value + "";
            }
        }


        public string QuestionContent
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

    }
}
