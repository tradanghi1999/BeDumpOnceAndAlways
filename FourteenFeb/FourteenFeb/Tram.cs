using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medallion;

namespace FourteenFeb
{
    public partial class Tram : Form
    {
        public Tram()
        {
            InitializeComponent();
        }

        public void CreateSpinner(Button[] btns, string[] strs)
        {
            if(btns.Length > strs.Length)
            {
                return;
            }
            int btnsLength = btns.Length;
            for(int i = 0; i < btns.Length;i++)
            {
                btns[i].Text = strs[i];
                btns[i].Tag = i + "";
            }
            for (int i = 0; i < btns.Length; i++)
            {
                //dBtns[i] = new Button();
                this.Controls.Add(btns[i]);
            }
        }
        //Button[] dBtnsFirstRow=null;
        string[] dStrs=null;

        //Button[] dBtnsSecondRow=null;


        private Button[] dBtnsFirstRow = new Button[9];
        private Button[] dBtnsSecondRow = new Button[9];
        private Button[] dBtnsThirdRow = new Button[9];
        private Button[] dBtnsFourthRow = new Button[9];
        private void Tram_Load(object sender, EventArgs e)
        {
            SetStrings(out dStrs);
            dStrs.Shuffle();
            SetNewButtonAndString(dBtnsFirstRow, dStrs, new Point(85, 20));
            SetNewButtonAndString(dBtnsSecondRow, dStrs, new Point(85, 70));
            SetNewButtonAndString(dBtnsThirdRow, dStrs, new Point(85, 120));
            SetNewButtonAndString(dBtnsFourthRow, dStrs, new Point(85, 170));

            RandomizePos(dBtnsFirstRow, dStrs);
            RandomizePos(dBtnsSecondRow, dStrs);
            RandomizePos(dBtnsThirdRow, dStrs);
            RandomizePos(dBtnsFourthRow, dStrs);


        }

        Random rdm = new Random();
        

        void RandomizePos(Button[] btns, string[] dStrs)
        {
            int rdmSTT = rdm.Next(1,20);
            for(int i = 0; i < rdmSTT;i++)
            {
                SetToNext(btns, dStrs);
            }
        }

        void SetNewButtonAndString(Button[] dBtns, string[] dStrs, Point firstOne)
        {

            //

            Button dBtnLeft = new Button();
            Button dBtnRight = new Button();
            

            //dBtns = new Button[9];

            for (int i = 0; i < dBtns.Length; i++)
            {
                dBtns[i] = new Button();
                //this.Controls.Add(dBtns[i]);
            }



            //set Dimension

            //dBtns = new Button[10];
            dBtnLeft.Size = new Size(30, 22);
            dBtnRight.Size = new Size(30, 22);

            for (int i = 0; i < dBtns.Length; i++)
            {
                if(i == dBtns.Length / 2)
                {
                    dBtns[i].Size = new Size(60, 32);
                }
                else
                {
                    dBtns[i].Size = new Size(50, 22);
                }
                
            }

            //set Location

            //dBtns[0].Location = new Point(85, 20);

            dBtnLeft.Location = new Point(firstOne.X - dBtnLeft.Width - 10, firstOne.Y);

            dBtns[0].Location = firstOne;

            for (int i = 0; i < dBtns.Length - 1; i++)
            {
                dBtns[i + 1].Location = new Point(dBtns[i].Location.X + dBtns[i].Width + 10, dBtns[i].Location.Y);
            }

            dBtnRight.Location = new Point(dBtns[dBtns.Length-1].Location.X + dBtns[dBtns.Length - 1].Width + 10, firstOne.Y);


            //set Style
            dBtnLeft.Text = "<";
            dBtnRight.Text = ">";

            

            dBtnLeft.Font= dBtnRight.Font = new Font("Latin", 7, FontStyle.Bold);
            //dBtnRight.Font = new Font(dBtnRight.Font, FontStyle.Bold);

            dBtnLeft.FlatStyle = dBtnRight.FlatStyle = FlatStyle.Flat;
            dBtnLeft.BackColor = dBtnRight.BackColor = btnPlaceBackClr;
            dBtnLeft.ForeColor = dBtnRight.ForeColor = btnPlaceForClr;

            dBtnLeft.TextAlign = dBtnRight.TextAlign = ContentAlignment.TopCenter;
            //dBtnLeft.Margin = new Padding(50,50,20,20);


            for (int i = 0; i < dBtns.Length; i++)
            {
                dBtns[i].FlatStyle = FlatStyle.Flat;
                dBtns[i].FlatAppearance.BorderSize = 1;
                if(i==4)
                {
                    dBtns[i].FlatAppearance.BorderColor= Color.Red;
                }
                //dBtns[i].Font = new Font(dBtns[i].Font, FontStyle.Bold);

            }



            CreateSpinner(dBtns, dStrs);
            this.Controls.Add(dBtnLeft);
            this.Controls.Add(dBtnRight);
            dBtnLeft.Click += new System.EventHandler(
                delegate (object obj, EventArgs ev)
                {
                    SetToPre(dBtns, dStrs);
                }
                );
            dBtnRight.Click += new System.EventHandler(
                delegate (object obj, EventArgs ev)
                {
                    SetToNext(dBtns, dStrs);
                }
                );

        }
        Color btnPlaceBackClr = Color.Gray;
        Color btnPlaceForClr = Color.White;

        void SetStrings(out string[] dStrs)
        {
            dStrs = new string[20];
            for (int i = 0; i < dStrs.Length; i++)
            {
                dStrs[i] = i + "";
            }

            dStrs[0] = "Anh";
            dStrs[1] = "Em";
            dStrs[2] = "Nha";
            dStrs[3] = "Ngon";
            dStrs[4] = "Ngủ";
            dStrs[5] = "Iu";
            dStrs[6] = "Chúc";
            dStrs[7] = "Mong";
            dStrs[8] = "Mãi";
            dStrs[9] = "Thương";
            dStrs[10] = "Sẽ";
            dStrs[11] = "Ước";
            dStrs[12] = "Làm";
            dStrs[13] = "Tìm";
            dStrs[14] = "Không";
            dStrs[15] = "Gái";
            dStrs[16] = "Được";
            dStrs[17] = "Đời";
            dStrs[18] = "Bên";
            dStrs[19] = "Cuộc";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            //if(tmrSpin.Enabled == false)
            //{
            //    tmrSpin.Enabled = true;
            //    tmrSpin.Start();
            //}
            //else if (tmrSpin.Enabled == true)
            //{
            //    tmrSpin.Enabled = false;
            //    tmrSpin.Stop();
            //}



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SetToPre(dBtnsFirstRow, dStrs);
            //if(tmrSpin.Enabled == false)
            //{
            //    tmrSpin.Enabled = true;
            //    tmrSpin.Start();
            //}
            //else if (tmrSpin.Enabled == true)
            //{
            //    tmrSpin.Enabled = false;
            //    tmrSpin.Stop();
            //}



        }

        private void SetToNext(Button[] dBtns, string[] dStrs)
        {
            if (dBtns.Length > dStrs.Length)
            {
                return;
            }

            int stt = -1;
            string sttString = dBtns[0].Tag.ToString();
            if(!int.TryParse(sttString, out stt))
            {
                return;
            }

            for(int i = 0; i < dBtns.Length; i++)
            {
                stt++;
                dBtns[i].Text = dStrs[stt%(dStrs.Length)];
                dBtns[i].Tag = stt + "";
            }
            if(AnswerIsTrue(dBtnsFirstRow,dBtnsSecondRow,dBtnsThirdRow,dBtnsFourthRow))
            {
                ShowTrue();
                //System.Threading.Thread.Sleep(1000);
                ThreadSafe(ShowAnswer);
            }
        }

        private void SetToPre(Button[] dBtns, string[] dStrs)
        {
            if (dBtns.Length > dStrs.Length)
            {
                return;
            }

            int stt = -1;
            string sttString = dBtns[0].Tag.ToString();
            if (!int.TryParse(sttString, out stt))
            {
                return;
            }
            stt--;
            stt--;
            if(stt < 0)
            {
                stt = stt + 20;
            }


            for (int i = 0; i < dBtns.Length; i++)
            {
                stt++;
                dBtns[i].Text = dStrs[stt % (dStrs.Length)];
                dBtns[i].Tag = stt + "";
            }
            if (AnswerIsTrue(dBtnsFirstRow, dBtnsSecondRow, dBtnsThirdRow, dBtnsFourthRow))
            {
                ShowTrue();
                //System.Threading.Thread.Sleep(1000);
                ThreadSafe(ShowAnswer);
            }
        }


        void ThreadSafe(Func<int> funct)
        {
            Timer tmr = new Timer();
            tmr.Enabled = true;
            tmr.Interval = 1500;
            tmr.Start();
            tmr.Tick += new EventHandler(
                delegate (object obj, EventArgs evn)
                {
                    funct();
                    tmr.Stop();
                    tmr.Dispose();
                }
                );
            
        }

        bool AnswerIsTrue(params object[] btnSs)
        {
            string theOne = "";
            for(int i=0; i< btnSs.Length; i++)
            {
                if(btnSs[i] is Button[])
                {
                    Button[] btns = btnSs[i] as Button[];

                    string str = btns.FirstOrDefault(x => x.Width == 60).Text;
                    theOne += str+" ";
                }
            }
            if(theOne.Contains("Chúc Em Ngủ Ngon"))
            {
                return true;
            }
            return false;
        }

        int ShowTrue()
        {
            List<Button> theMid = new List<Button>();
            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is Button))
                {
                    continue;
                }
                Button btn = ctrl as Button;
                if (btn.Width == 60)
                {
                    theMid.Add(btn);
                }


            }



            foreach (Button btn in theMid)
            {
                btn.FlatAppearance.BorderColor = lightGrnClr;
            }

            return -1;
        }

        int ShowAnswer()
        {
            List<Button> theMid = new List<Button>();
            foreach(Control ctrl in this.Controls)
            {
                if(!(ctrl is Button))
                {
                    continue;
                }
                Button btn = ctrl as Button;
                if(btn.Width == 60)
                {
                    theMid.Add(btn);
                }
                

            }



            foreach(Button btn in theMid)
            {
                btn.Location = new Point(btn.Location.X, btn.Location.Y + 100);
            }


            dBtnsFourthRow[5].Location = new Point(dBtnsFourthRow[5].Location.X, dBtnsFourthRow[5].Location.Y + 50);

            // colorize
            foreach (Button btn in theMid)
            {
                btn.BackColor = greenClr;
            }

            dBtnsFirstRow[3].BackColor= dBtnsFirstRow[4].BackColor = dBtnsFirstRow[5].BackColor =
                dBtnsSecondRow[3].BackColor = dBtnsSecondRow[5].BackColor =
                dBtnsSecondRow[2].BackColor = dBtnsSecondRow[6].BackColor =
                dBtnsThirdRow[3].BackColor = dBtnsThirdRow[5].BackColor = pinkClr;

            dBtnsFourthRow[5].BackColor = lightGrnClr;

            dBtnsFirstRow[3].FlatAppearance.BorderColor = dBtnsFirstRow[4].FlatAppearance.BorderColor = dBtnsFirstRow[5].FlatAppearance.BorderColor =
                 dBtnsSecondRow[3].FlatAppearance.BorderColor = dBtnsSecondRow[5].FlatAppearance.BorderColor =
                 dBtnsSecondRow[2].FlatAppearance.BorderColor = dBtnsSecondRow[6].FlatAppearance.BorderColor =
                 dBtnsThirdRow[3].FlatAppearance.BorderColor = dBtnsThirdRow[5].FlatAppearance.BorderColor = pinkOutClr;

            foreach (Button btn in theMid)
            {
                btn.FlatAppearance.BorderColor = greenOutClr;
            }

            dBtnsFourthRow[5].FlatAppearance.BorderColor = lightGrnOutClr;



            foreach (Control ctrl in this.Controls)
            {
                if(ctrl is Button && (ctrl as Button).BackColor!=pinkClr &&
                    (ctrl as Button).BackColor != greenClr && 
                    (ctrl as Button).BackColor != lightGrnClr)
                {
                    ctrl.Visible = false;
                }
            }

            lblLoiChuc.Visible = true;
            lblHint.Visible = false;

            return -1;
        }

        Color pinkClr = Color.FromArgb(255,187,215);
        Color greenClr = Color.FromArgb(179,226,137);
        Color lightGrnClr = Color.FromArgb(91,192,191);

        Color pinkOutClr = Color.FromArgb(209,141,178);
        Color greenOutClr = Color.FromArgb(177, 194, 122);
        Color lightGrnOutClr = Color.FromArgb(99, 173, 208);

        void Spining(Button[] dBtns)
        {
            int xKhc = Math.Abs(dBtns[dBtns.Length - 1].Location.X - dBtns[dBtns.Length - 2].Location.X);

        }

        private void TmrSpin_Tick(object sender, EventArgs e)
        {
            //button1.Location = new Point(button1.Location.X + 10, button1.Location.Y); 
        }

        private void SHow(object sender, EventArgs e)
        {
            ShowAnswer();
        }

        private void LblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.Font = new Font(lblClose.Font, FontStyle.Bold);
        }

        private void LblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.Font = new Font(lblClose.Font, FontStyle.Regular);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            //if (lblLoiChuc.Visible == true)
            //{
            //    this.Close();
            //    return;
            //}

            //if (MessageBox.Show("Please Try Again", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //{

            //}
            //else
            //{
            //    this.Close();
            //}
            Close();
        }

        private void Tram_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(lblLoiChuc.Visible == true)
            {
                //this.Close();
                return;
            }

            if(MessageBox.Show("Please Try Again", "Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {

            }
        }

        private void LblCop_Click(object sender, EventArgs e)
        {
            ShowAnswer();
        }
    }
}
