using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT.Items
{
    public partial class ucQAdetail : UserControl
    {
        public Color Border
        {
            get
            {
                return pnlBorderTop.BackColor;
            }
            set
            {
                Color color = value;
                pnlBorderTop.BackColor = pnlBorderBottom.BackColor = color;
            }
        }
        public bool IsCorrect
        {
            get
            {
                return btnDung.Enabled;
            }
            set
            {
                bool isCorrect = value;
                btnDung.Enabled = !isCorrect;
                btnSai.Enabled = isCorrect;
            }
        }

        private bool _isShown = false;
        public bool IsShown
        {
            get
            {
                return _isShown;
            }
            set
            {
                bool isShown = value;
                if(isShown)
                {
                    btnHien.BackColor = SystemColors.ButtonShadow;
                }
                else
                {
                    btnHien.BackColor = SystemColors.Control;
                }
                _isShown = isShown;
            }
        }


        public string TenDoi
        {
            get
            {
                return lblTenDoi.Text;
            }
            set
            {
                lblTenDoi.Text = value;
            }
        }
        public string Vong
        {
            get
            {
                return lblVong.Text;
            }
            set
            {
                lblVong.Text = value;
            }
        }

        public string STT
        {
            get
            {
                return lblSTTcauHoi.Text;
            }
            set
            {
                lblSTTcauHoi.Text = value;
            }
        }
        public int Diem
        {
            get
            {
                int diem = 0;
                if(int.TryParse(lblDiem.Text, out diem))
                { }
                return diem;
            }
            set
            {
                lblDiem.Text = value + "";
            }
        }
        public string NoiDungCauHoi
        {
            get
            {
                return rtbNoiDungCauHoi.Text;
            }
            set
            {
                rtbNoiDungCauHoi.Text = value;
            }
        }

        public string ID { get; set; }
        //private bool _isMore = false;
        //public bool IsMore
        //{
        //    get
        //    {
        //        return _isMore;
        //    }
        //    set
        //    {
        //        bool isMore = value;



        //        _isMore = isMore;

        //        setMore(isMore);
        //    }
        //}
        private bool _isMore = false;  
        private void setMore(bool bol)
        {
            if (bol)
            {
                string sampleText = "Song Trong Doi Song Can Co Mot Tam Long, Song Nhu Cho Tha";
                var sizeOfSampleText = TextRenderer.MeasureText(sampleText, rtbNoiDungCauHoi.Font);
                var lineNumber = (sizeOfSampleText.Width / rtbNoiDungCauHoi.Width) + 1;
                var spaceNumber = lineNumber - 1;
                //rtbNoiDungCauHoi.Height = (int)(lineNumber * sizeOfSampleText.Height + spaceNumber * 10);
                //pnlitemContainer.Height = rtbNoiDungCauHoi.Height;
                var fitHeight = (int)(lineNumber * sizeOfSampleText.Height + spaceNumber * 10);
                this.Height = fitHeight + 13;
                pnlitemContainer.Height = fitHeight;
                pnlNoiDungCauHoi.Height = fitHeight;
                rtbNoiDungCauHoi.Height = fitHeight;

                
                //
                //picMore.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else
            {
                this.Height = 86+13;
                pnlitemContainer.Height = 86;
                pnlNoiDungCauHoi.Height = 86;
                rtbNoiDungCauHoi.Height = 86;
                //picMore.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
        }
        public ucQAdetail()
        {
            InitializeComponent();
            //this.IsMore = false;
        }

        private void PicMore_Click(object sender, EventArgs e)
        {
            if(!_isMore)
            {
                picMore.Image = global::IT.Properties.Resources.arrowUp;
                
            }
            else
            {
                picMore.Image = global::IT.Properties.Resources.arrow;
            }
            setMore(!_isMore);
            _isMore = !_isMore;


        }

        private void RtbNoiDungCauHoi_SizeChanged(object sender, EventArgs e)
        {
            //this.pnlitemContainer.Height = rtbNoiDungCauHoi.Height;
            //this.Height = rtbNoiDungCauHoi.Height + 25;
        }

        private void PicMore_MouseHover(object sender, EventArgs e)
        {
            picMore.BackColor = Color.FromArgb(200, 200, 200);
        }

        private void PicMore_MouseLeave(object sender, EventArgs e)
        {
            picMore.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void BtnDung_Click(object sender, EventArgs e)
        {
            IsCorrect = true;
        }

        private void BtnSai_Click(object sender, EventArgs e)
        {
            IsCorrect = false;
        }
    }
}
