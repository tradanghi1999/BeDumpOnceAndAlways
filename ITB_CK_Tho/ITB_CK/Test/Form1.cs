using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        enum SecondScrenPosition
        {
            None = 0, Top = 1, Right = 2, Bottom = 3, Left = 4
        }
        private SecondScrenPosition _secondScreenPosition = SecondScrenPosition.None;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetLocation_Click(object sender, EventArgs e)
        {
            int xPos = this.Location.X;
            int yPos = this.Location.Y;
            MessageBox.Show("x= " + xPos + "; y= " + yPos + ";");
        }

        private void BtnMaximizeOnScree_Click(object sender, EventArgs e)
        {
            int secondScreenWidth = 0;
            int secondScreenHeight = 0;
            try
            {
                //secondScreenWidth = Screen.AllScreens[1].Bounds.Width;
                //secondScreenHeight = Screen.AllScreens[1].Bounds.Height;
                //Location.X = Screen.AllScreens[1].Bounds.X;
                //this.Location.Y = Screen.AllScreens[1].Bounds.Y;
                //if (_secondScreenPosition == SecondScrenPosition.Top)
                //{
                //    this.Top = - secondScreenHeight / 2;
                //    this.Left = secondScreenWidth / 2; 
                //}
                //else if(_secondScreenPosition == SecondScrenPosition.Bottom)
                //{
                //    this.Top = secondScreenHeight / 2;
                //    this.Left = secondScreenWidth / 2;
                //}
                //else if (_secondScreenPosition == SecondScrenPosition.Left)
                //{
                //    this.Top = secondScreenHeight / 2;
                //    this.Left = - secondScreenWidth / 2;

                //}
                //else if (_secondScreenPosition == SecondScrenPosition.Right)
                //{
                //    this.Top = secondScreenHeight / 2;
                //    this.Left = secondScreenWidth / 2;

                //}
                Screen secondScreen = Screen.AllScreens.FirstOrDefault(s => s != Screen.PrimaryScreen);
                this.Location = secondScreen.WorkingArea.Location;
            }
            catch
            {
                this.Top = 0;
                this.Left = 0;
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;


        }

        private void Btn2ndTop_Click(object sender, EventArgs e)
        {
            _secondScreenPosition = SecondScrenPosition.Top;
        }

        private void Btn2ndBottom_Click(object sender, EventArgs e)
        {
            _secondScreenPosition = SecondScrenPosition.Bottom;
        }

        private void Btn2ndLeft_Click(object sender, EventArgs e)
        {
            _secondScreenPosition = SecondScrenPosition.Left;
        }

        private void Btn2ndRight_Click(object sender, EventArgs e)
        {
            _secondScreenPosition = SecondScrenPosition.Right;
        }
    }
}
