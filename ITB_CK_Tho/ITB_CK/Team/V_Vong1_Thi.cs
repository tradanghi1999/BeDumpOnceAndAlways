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
 
namespace Team
{
    public partial class V_Vong1_Thi : View
    {
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
                return richTextBox1.Text;
            }
            set
            {
                richTextBox1.Text = value;
            }
        }
        public string AnswerKey
        {
            get
            {
                return lblDapAn.Text;
            }
            set
            {
                lblDapAn.Text = "Key: \n" + value;
            }
        }
        public V_Vong1_Thi()
        {
            InitializeComponent();
        }

        private void V_Vong1_Thi_Load(object sender, EventArgs e)
        {
            //if(_ctrl is Team_Vong1_Controller)
            //{
            //    (_ctrl as Team_Vong1_Controller).GetNextQuestion();
            //}
        }

        //public static explicit operator V_Vong1_Thi(View v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
