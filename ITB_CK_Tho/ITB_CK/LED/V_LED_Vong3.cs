using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LED
{
    public partial class V_LED_Vong3 : View
    {
        public bool KeyIsShown
        {
            get
            {
                return lblDapAn.Visible;
            }
            set
            {
                lblDapAn.Visible = value;
            }
        }
        //public Image QuestionImg
        //{
        //    get
        //    {
        //        return picQuestion.Image;
        //    }
        //    set
        //    {
        //        picQuestion.Image = value;
        //    }
        //}
        public string STT
        {
            get
            {
                //int i = 0;
                //int.TryParse(lblSoThuTuCauHoi.Text, out i);
                return lblCau.Text;
            }
            set
            {
                lblCau.Text = value + "";
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
                return rtbNoiDungCau.Text;
            }
            set
            {
                rtbNoiDungCau.Text = value;
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
        public V_LED_Vong3()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            //
            //Graphicialize();

        }
        private Image myBackGround = Image.FromFile(Application.StartupPath + "//Res//Vong 3.png");
        public override void Graphicialize()
        {
            this.BackgroundImage = (Image)(LIB.ResizeImage((Image)(myBackGround), this.Width, this.Height));
            this.lblDapAn.BackColor = System.Drawing.Color.FromArgb(0, ((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(182)))));
            rtbNoiDungCau.BackColor = Color.FromArgb(0, ((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
           // tableLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblDoi1.BackColor = lblDoi2.BackColor = lblDoi3.BackColor =  Color.FromArgb(0, 0, 0, 0);
            lblDiemDoi1.BackColor = lblDiemDoi2.BackColor = lblDiemDoi3.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblFullScreen.BackColor = lblFullScreen.ForeColor=Color.FromArgb(0,15, 23, 75);
        }

        private void LblFullScreen_MouseHover(object sender, EventArgs e)
        {
            lblFullScreen.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void LblFullScreen_MouseLeave(object sender, EventArgs e)
        {
            lblFullScreen.ForeColor = Color.FromArgb(0, 15, 23, 75);
        }

        public void LblFullScreen_Click(object sender, EventArgs e)
        {
            lblFullScreen.ForeColor = Color.FromArgb(255, 253, 208);
            LIB.MakeFullScreen(this,null);
            
            ResizeControls();
            RelocatingControls();
            Graphicialize();
        }

        double ratCauToScreen = 14 * 1.0 / 768, 
                ratDoiToScreen = 28 * 1.0 / 768,
                ratKeyToScreen = 30 * 1.0 / 768;
        
        
        public override void ResizeControls()
        {
            //throw new NotImplementedException();
            label1.Font=label2.Font=lblCau.Font=lblDiemDoi1.Font = lblDiemDoi2.Font = lblDiemDoi3.Font = lblDoi1.Font = lblDoi2.Font = lblDoi3.Font = new Font(lblDoi1.Font.FontFamily, (float)(this.Height*ratDoiToScreen));
            lblDiemDoi1.Height = lblDiemDoi2.Height = lblDiemDoi3.Height = lblDoi1.Height = lblDoi2.Height = lblDoi3.Height = (int)(lblDoi1.Font.Size + 10);

            label1.Font = label2.Font = lblCau.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratDoiToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rtbNoiDungCau.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratDoiToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rtbNoiDungCau.Height = rtbNoiDungCau.Font.Height * 5 + 10 * 5;
            //lblDoi1.Width = 400;
            lblDapAn.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratKeyToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDapAn.Height = lblDapAn.Font.Height * 3 + 10 * 3;
            lblDapAn.Width =TextRenderer.MeasureText("#9Slide03 SVNNexa Rust Sans Bla Rust Sans Bla", lblDapAn.Font).Width;
        }

        double ratLBLdoi2ToScreen = 170 * (1.0) / 768;
        double ratLBLcauToScreenHeight = 293 * 1.0 / 768;
        double ratLBLcauToScreenWidth = 149 * 1.0 / 1366;
        double ratRTBtoScreen = 333 * 1.0 / 768;
        double ratKeyToScreenHeight = 570*1.0 / 768;
        double ratKeyToScreenWidth = 566 * 1.0 / 1366;
        public override void RelocatingControls()
        {
            lblDoi2.BringToFront();
            lblDoi2.Left = (this.Width - lblDoi2.Width) / 2;
            lblDoi2.Top = (int)(this.Height * 1.0 * ratLBLdoi2ToScreen);
            //
            lblDoi1.Left = lblDoi2.Left - lblDoi1.Width;
            lblDoi1.Top = lblDoi2.Top;
            lblDoi3.Left = lblDoi2.Left + lblDoi2.Width;
            lblDoi3.Top = lblDoi2.Top;
            //
            lblDiemDoi2.Left = (this.Width - lblDiemDoi2.Width) / 2;
            lblDiemDoi2.Top = lblDoi2.Top + lblDoi2.Height;
            //
            lblDiemDoi1.Width = lblDoi1.Width;
            lblDiemDoi1.Left = lblDoi1.Left;
            lblDiemDoi1.Top = lblDiemDoi2.Top;
            lblDiemDoi3.Top = lblDiemDoi2.Top;
            lblDiemDoi3.Width = lblDoi3.Width;
            lblDiemDoi3.Left = lblDoi3.Left;
            //
            label1.Top = (int)(this.Height * 1.0 * ratLBLcauToScreenHeight);
            label1.Left = (int)(this.Width * 1.0 * ratLBLcauToScreenWidth);
            lblCau.Top = label2.Top = label1.Top;
            lblCau.Left = label1.Left + label1.Width;
            label2.Left = lblCau.Left + lblCau.Width;
            //
            rtbNoiDungCau.Left = (this.Width - rtbNoiDungCau.Width) / 2;
            rtbNoiDungCau.Top = (int)(this.Height * 1.0 * ratRTBtoScreen);
            rtbNoiDungCau.SendToBack();
            //
            lblDapAn.Top = (int)(this.Height * 1.0 * ratKeyToScreenHeight);
            lblDapAn.Left = (int)(this.Width * 1.0 * ratKeyToScreenWidth);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblCau_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
