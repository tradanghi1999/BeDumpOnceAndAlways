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
    public partial class V_MC_Vong1 : View
    {
        private int _dem=0;
        
        public string TenDoi
        {
            
            set
            {
                lblTitleCon.Text = "Vòng 1 - Đội " + value;
            }
        }
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


        public V_MC_Vong1()
        {
            InitializeComponent();
        }
        
        private void V_Start_Load(object sender, EventArgs e)
        {
            tmr3dot.Enabled = true;
            tmr3dot.Interval = 300;
            tmr3dot.Start();
           // _ctrl.CheckOnStartUp();
        }

        private void Tmr3dot_Tick(object sender, EventArgs e)
        {
            if (_dem == 4)
            {
                _dem = 1;
            }
            else
            {
                _dem++;
            }

            if (_dem == 1)
            {
                lbl3dot.Text = ".";
            }
            else if (_dem == 2)
            {
                lbl3dot.Text = "." + ".";
            }
            else if (_dem == 3)
            {
                lbl3dot.Text = "." + "." + ".";
            }


        }
    }
}
