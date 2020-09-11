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
    public partial class V_IT_Vong3 : View
    {


        public V_IT_Vong3()
        {
            InitializeComponent();
            DoiDauTienState = null;
            DoiThuHaiState = null;

        }
        public Image QuestionImg
        {
            get
            {
                return picQuestion.Image;
            }
            set
            {
                picQuestion.Image = value;
            }
        }
        public string STT
        {
            get
            {
                //int i = 0;
                //int.TryParse(lblSoThuTuCauHoi.Text, out i);
                return lblSoThuTuCauHoi.Text;
            }
            set
            {
                lblSoThuTuCauHoi.Text = value + "";
            }
        }
        public string IDDoi1 { get; set; }
        public string IDDoi2 { get; set; }
        public string IDDoi3 { get; set; }
        public string TenDoi1 {
            get
            {
                return lblDoi1.Text;
            }

            set
            {
                lblDoi1.Text = value;
            }
        }
        public string TenDoi3 {
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
                return lblNoiDungCauHoi.Text;
            }
            set
            {
                lblNoiDungCauHoi.Text = value;
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
                lblDapAn.Text = value;
            }
        }
        private void V_IT_Vong3_Load(object sender, EventArgs e)
        {
            if (_ctrl is IT_Vong3_Controller)
            {
                (_ctrl as IT_Vong3_Controller).GetTeams();
                (_ctrl as IT_Vong3_Controller).GetFirstQuestion();
            }
            
        }
        //private void RefreshState()
        //{
        //    cbxDoi1TraLoi1.Checked = false;
        //    cbxDoi1TraLoi2.Checked = false;
        //    cbxDoi2TraLoi1.Checked = false;
        //    cbxDoi2TraLoi2.Checked = false;
        //    cbxDoi3TraLoi1.Checked = false;
        //    cbxDoi3TraLoi2.Checked = false;
        //}

        private void CheckDoiTraLoiDauTien(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rdo = sender as RadioButton;
                //Panel pnl = rdo.Parent as Panel;
                //if(pnl!=null)
                //{
                //    foreach(Control ctrl in pnl.Controls)
                //    {
                //        if(ctrl is RadioButton)
                //        {
                //            if(ctrl.Name != rdo.Name)
                //            {
                //                (ctrl as RadioButton).Checked = false;
                //            }
                //        }
                //    }
                //}
                if (rdo.Name.Contains("Doi1"))
                {

                }
                else if (rdo.Name.Contains("Doi2"))
                {

                }
                else if (rdo.Name.Contains("Doi3"))
                {

                }

            }
        }

        private void BtnTiepTheo_Click(object sender, EventArgs e)
        {
            if(!CheckState())
            {
                return;
            }

            if (_ctrl is IT_Vong3_Controller)
            {
                (_ctrl as IT_Vong3_Controller).UpdateResultDetail();
                //(_ctrl as IT_Vong3_Controller).GetTeams();
                (_ctrl as IT_Vong3_Controller).GetTeams();
                (_ctrl as IT_Vong3_Controller).GetNextQuestion();
                ResetState();
                (_ctrl as IT_Vong3_Controller).GetNextQuestionState();
            }
        }

        private void ResetState()
        {
            //throw new NotImplementedException();
            DoiDauTienState = null;
            DoiThuHaiState = null;
            foreach (Control ctrl in pnlDoiDauTien.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rdo = ctrl as RadioButton;
                    rdo.Checked = false;
                }
            }
            foreach (Control ctrl in pnlDoiThuHai.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rdo = ctrl as RadioButton;
                    rdo.Checked = false;
                }
            }
            
            

        }

        public string IdDoiDauTienTraLoi
        {
            get;
            private set;
        }
        public string IdDoiDauThuHaiTraLoi
        {
            get;
            private set;
        }
        private bool CheckState()
        {
            //throw new NotImplementedException();
            RadioButton rdoTeamDauChecked = null;
            foreach(Control ctrl in pnlDoiDauTien.Controls)
            {
                if(ctrl is RadioButton)
                {
                    RadioButton rdo = ctrl as RadioButton;
                    if(rdo.Checked)
                    {
                        rdoTeamDauChecked = rdo;
                    }
                }
            }

            if(rdoTeamDauChecked != null)
            {
                if (btnDung1.Enabled == true && btnSai1.Enabled == true)
                {
                    MessageBox.Show("Chua Doi 1 Dung/Sai");
                    return false;
                }
                try
                {
                    int sttDoiI = int.Parse(rdoTeamDauChecked.Text.Substring(rdoTeamDauChecked.Text.Length - 1, 1));
                    if(sttDoiI == 0 || sttDoiI > 3)
                    {
                        IdDoiDauTienTraLoi = "";
                    }
                    else if(sttDoiI == 1)
                    {
                        IdDoiDauTienTraLoi = IDDoi1;
                    }
                    else if(sttDoiI == 2)
                    {
                        IdDoiDauTienTraLoi = IDDoi2;
                    }
                    else
                    {
                        IdDoiDauTienTraLoi = IDDoi3;
                    }
                }
                catch(Exception e)
                {
                    return false;
                }
            }
            else
            {
                IdDoiDauTienTraLoi = null;
            }

            RadioButton rdoTeamHaiChecked = null;
            foreach (Control ctrl in pnlDoiThuHai.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rdo = ctrl as RadioButton;
                    if (rdo.Checked)
                    {
                        rdoTeamHaiChecked = rdo;
                    }
                }
            }

            if (rdoTeamHaiChecked != null)
            {
                if (btnDung2.Enabled == true && btnSai2.Enabled == true)
                {
                    MessageBox.Show("Chua Doi 2 Dung/Sai");
                    return false;
                }
                try
                {
                    int sttDoiII = int.Parse(rdoTeamHaiChecked.Text.Substring(rdoTeamDauChecked.Text.Length - 1, 1));
                    if (sttDoiII == 0 || sttDoiII > 3)
                    {
                        IdDoiDauThuHaiTraLoi = "";
                    }
                    else if (sttDoiII == 1)
                    {
                        IdDoiDauThuHaiTraLoi = IDDoi1;
                    }
                    else if (sttDoiII == 2)
                    {
                        IdDoiDauThuHaiTraLoi = IDDoi2;
                    }
                    else
                    {
                        IdDoiDauThuHaiTraLoi = IDDoi3;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                IdDoiDauThuHaiTraLoi = null;
            }

            
            

            return true;
        }

        public bool? DoiThuHaiState
        {
            get
            {
                if (btnDung2.Enabled && btnSai2.Enabled)
                    return null;
                else
                    return !(btnDung2.Enabled);
            }
            set
            {
                if(value !=null)
                {
                    bool myValue = (bool)value;
                    btnDung2.Enabled = !myValue;
                    btnSai2.Enabled = myValue;
                }
                else
                {
                    btnDung2.Enabled = true;
                    btnSai2.Enabled = true;
                }
            }
        }

        public bool? DoiDauTienState
        {
            get
            {
                if (btnDung1.Enabled && btnSai1.Enabled)
                    return null;
                else
                    return !(btnDung1.Enabled);
            }
            set
            {
                if (value != null)
                {
                    bool myValue = (bool)value;
                    btnDung1.Enabled = !myValue;
                    btnSai1.Enabled = myValue;
                }
                else
                {
                    btnDung1.Enabled = true;
                    btnSai1.Enabled = true;
                }
            }
        }

        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            if (!CheckState())
            {
                return;
            }
            if (_ctrl is IT_Vong3_Controller)
            {
                //(_ctrl as IT_Vong3_Controller).GetTeams();
                (_ctrl as IT_Vong3_Controller).GetPreQuestion();
                
            }
        }

        private void BtnDung1_Click(object sender, EventArgs e)
        {
            DoiDauTienState = true;

        }

        private void BtnSai1_Click(object sender, EventArgs e)
        {
            DoiDauTienState = false;
        }

        private void BtnDung2_Click(object sender, EventArgs e)
        {
            DoiThuHaiState = true;
        }

        private void BtnSai2_Click(object sender, EventArgs e)
        {
            DoiThuHaiState = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetState();
        }

        private void BtnShowKey_Click(object sender, EventArgs e)
        {
            if (_ctrl is IT_Vong3_Controller)
            {
                //(_ctrl as IT_Vong3_Controller).GetTeams();
                (_ctrl as IT_Vong3_Controller).ShowKey();

            }
        }
        //private void CheckDoiTraLoiThuHai(object sender, EventArgs e)
        //{
        //    if (sender is CheckBox)
        //    {
        //        CheckBox cbx = sender as CheckBox;
        //        cbxDoi1TraLoi2.Checked = false;
        //        cbxDoi2TraLoi2.Checked = false;
        //        cbxDoi3TraLoi2.Checked = false;
        //        cbx.Checked = true;

        //    }
        //}
    }
}
