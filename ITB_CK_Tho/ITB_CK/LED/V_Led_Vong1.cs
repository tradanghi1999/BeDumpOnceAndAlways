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
using ITB_CK.LED;
//

namespace LED
{
    public partial class V_Led_Vong1 : View
    {
        private Image myBackGround = Image.FromFile(Application.StartupPath + "//Res//Vong 1.png");
        private Image myPic;
        public Image Pic
        {
            set
            {
                myPic = value;
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
                return rtbNoiDungCau.Text;
            }
            set
            {
                rtbNoiDungCau.Text = value;
            }
        }
        public string QuestionMaybeAnswer
        {
            set
            {
                lblABCD.Text = value;
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
        public V_Led_Vong1()
        {
            InitializeComponent();
            Graphicialize();
        }

        public override void Graphicialize()
        {
            this.BackgroundImage = (Image)(LIB.ResizeImage((Image)(myBackGround), this.Width, this.Height));
            this.lblDapAn.BackColor = System.Drawing.Color.FromArgb(0, ((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(182)))));
            rtbNoiDungCau.BackColor = Color.FromArgb(0, ((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            // tableLayoutPanel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            //lblDoi1.BackColor = lblDoi2.BackColor = lblDoi3.BackColor = Color.FromArgb(0, 0, 0, 0);
            //lblDiemDoi1.BackColor = lblDiemDoi2.BackColor = lblDiemDoi3.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblFullScreen.BackColor = lblFullScreen.ForeColor = Color.FromArgb(0, 15, 23, 75);
            lblCau.BackColor = Color.FromArgb(0, 0, 0, 0);
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
            LIB.MakeFullScreen(this, null);
            ResizeControls();
            RelocatingControls();
            Graphicialize();
        }

        double ratCauToScreenHeight = 150 * 1.0 / 768,
                ratCauToScreenWidth = 90 * 1.0 / 1366,
                ratDoiToScreen = 25 * 1.0 / 768,
                ratKeyToScreen = 25 * 1.0 / 768,
                ratCountToScreen = 56 * 1.0 / 768,
                ratNoiDungToScreen = 0.85,
                ratPicSizeToScreen = 0.5
            ;
            


        public override void ResizeControls()
        {
            //throw new NotImplementedException();
            //label1.Font = label2.Font = lblCau.Font = lblDiemDoi1.Font = lblDiemDoi2.Font = lblDiemDoi3.Font = lblDoi1.Font = lblDoi2.Font = lblDoi3.Font = new Font(lblDoi1.Font.FontFamily, (float)(this.Height * ratDoiToScreen));
            //lblCau.Font = new Font(lblCau.Font.FontFamily, (float)(this.Height * ratDoiToScreen));
            

            //lblDiemDoi1.Height = lblDiemDoi2.Height = lblDiemDoi3.Height = lblDoi1.Height = lblDoi2.Height = lblDoi3.Height = (int)(lblDoi1.Font.Size + 10);
            
           // lblCau.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratDoiToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCau.Font = new Font("Times New Roman", (float)(this.Height * ratDoiToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCountDown.Font = new Font("Times New Roman", (float)(this.Height * ratCountToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            lblCau.Height = (int)(lblCau.Font.Size + 20);
            //
            lblABCD.Font=rtbNoiDungCau.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratDoiToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rtbNoiDungCau.Height = rtbNoiDungCau.Font.Height * 5 + 10 * 5;
            //
            // rtbNoiDungCau.MaximumSize =new Size(0, (int)(ratNoiDungToScreen * 1.0 * this.Width));
            //
            lblABCD.Height = lblABCD.Font.Height * 5 + 10 * 5;
            rtbNoiDungCau.Width = (int)(ratNoiDungToScreen * 1.0 * this.Width);
            //lblDoi1.Width = 400;
            lblDapAn.Font = new Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * ratKeyToScreen), ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDapAn.Height = lblDapAn.Font.Height * 3 + 10 * 3;
            lblDapAn.Width = TextRenderer.MeasureText("#9Slide03 SVNNexa Rust Sans Bla Rust Sans Bla", lblDapAn.Font).Width;
            //
            pic.Width = (int)(this.Width * ratPicSizeToScreen);
            pic.Height = (int)(this.Width * ratPicSizeToScreen);
        }

        double ratLBLdoi2ToScreen = 170 * (1.0) / 768;
        double ratLBLcauToScreenHeight = 293 * 1.0 / 768;
        double ratLBLcauToScreenWidth = 149 * 1.0 / 1366;
        double ratRTBtoScreen = 200 * 1.0 / 768;

        private void RtbNoiDungCau_Click(object sender, EventArgs e)
        {

        }

        double ratKeyToScreenHeight = 570 * 1.0 / 768;

        private int _demCount = 90;
        private void TmrCountDown_Tick(object sender, EventArgs e)
        {
            _demCount--;
            if(_demCount >=0)
            {
                this.lblCountDown.Text = _demCount + "";
            }
            else
            {
                tmrCountDown.Stop();
            }
            
        }
        public bool StartCountEnabled
        {
            set
            {
                if(value == true)
                {
                    tmrCountDown.Start();
                }
            }
        }

        double ratKeyToScreenWidth = 566 * 1.0 / 1366;
        public override void RelocatingControls()
        {
            //lblDoi2.BringToFront();
            //lblDoi2.Left = (this.Width - lblDoi2.Width) / 2;
            //lblDoi2.Top = (int)(this.Height * 1.0 * ratLBLdoi2ToScreen);
            //
            //lblDoi1.Left = lblDoi2.Left - lblDoi1.Width;
            //lblDoi1.Top = lblDoi2.Top;
            //lblDoi3.Left = lblDoi2.Left + lblDoi2.Width;
            //lblDoi3.Top = lblDoi2.Top;
            //
            //lblDiemDoi2.Left = (this.Width - lblDiemDoi2.Width) / 2;
            //lblDiemDoi2.Top = lblDoi2.Top + lblDoi2.Height;
            //
            //lblDiemDoi1.Width = lblDoi1.Width;
            //lblDiemDoi1.Left = lblDoi1.Left;
            //lblDiemDoi1.Top = lblDiemDoi2.Top;
            //lblDiemDoi3.Top = lblDiemDoi2.Top;
            //lblDiemDoi3.Width = lblDoi3.Width;
            //lblDiemDoi3.Left = lblDoi3.Left;
            //
            //label1.Top = (int)(this.Height * 1.0 * ratLBLcauToScreenHeight);
            //label1.Left = (int)(this.Width * 1.0 * ratLBLcauToScreenWidth);

            //label2.Left = lblCau.Left + lblCau.Width;
            //

            lblCau.Top = (int)(this.Height * 1.0 * ratCauToScreenHeight);
            lblCau.Left = (int)(this.Width * 1.0 * ratCauToScreenWidth);
            rtbNoiDungCau.Left = (this.Width - rtbNoiDungCau.Width) / 2;
            rtbNoiDungCau.Top = (int)(this.Height * 1.0 * ratRTBtoScreen);
            //
            lblABCD.Left = rtbNoiDungCau.Left;


            //////////////////
            ///
            Size myText = TextRenderer.MeasureText(rtbNoiDungCau.Text, rtbNoiDungCau.Font);
            int skt = 35;
            int sodong =(int)(rtbNoiDungCau.Text.ToCharArray().Length * 1.0 / skt);
            int height = (int)((sodong - 1) * 0.5 * myText.Height + myText.Height * sodong);
            lblABCD.Top = rtbNoiDungCau.Top + height + (int)(1.5 * myText.Height); 

            //
            rtbNoiDungCau.SendToBack();
            //
            lblDapAn.Top = (int)(this.Height * 1.0 * ratKeyToScreenHeight);
            lblDapAn.Left = (int)(this.Width * 1.0 * ratKeyToScreenWidth);
            //
            lblCountDown.Left = (int)(0.89 * this.Width);
            lblCountDown.Top = (int)(0.05 * this.Height);
            //
            pic.Left = lblCau.Left;
            pic.Top = lblABCD.Top;
        }

        public bool ShowABCD
        {
            get
            {
                return lblABCD.Visible;
            }
            set
            {
                lblABCD.Visible = value;
            }
        }
        public bool ShowPic
        {
            set
            {
                pic.Visible = value;
            }
        }
        public void RelocatingAndResizingControls(string type)
        {
            if(type=="nohinh")
            {
                ResizeControls();
                RelocatingControls();
                return;
            }

            ResizeControls();
            RelocatingControls();
            if (myPic != null)
                pic.Image = LIB.ResizeImage(myPic, pic.Width, pic.Height);

            if (ShowABCD)
            {
                
                lblABCD.Left = (int)(this.Width * 0.7);
                
                return;
            }

            pic.Left = (this.Width - pic.Width) / 2;


        }

        
        

    }
}
