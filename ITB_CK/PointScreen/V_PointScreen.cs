﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using ITB_CK.Team.Team_PointScreen;

namespace PointScreen
{
    public partial class V_PointScreen : Form, IV_PointScreen_Adapter
    {
        /// <summary>
        /// Variable Zone
        /// </summary>
        enum SecondScrenPosition
        {
            None = 0, Top = 1, Right = 2, Bottom = 3, Left = 4
        }
        private PointScreenController _ctrl;
        private int _diem;
        private string _tenDoi;
        public int Diem
        {
            set
            {
                _diem = value;
                lblDiem.Text = _diem + "";
            }
        }
        public string TenDoi
        {
            set
            {
                _tenDoi = value;
                lblTenDoi.Text = _tenDoi + "";
            }
        }

        /// <summary>
        /// Controller Zone
        /// </summary>

        private SecondScrenPosition _seconndPos = SecondScrenPosition.None;
        public V_PointScreen()
        {
            InitializeComponent();
            _ctrl = new PointScreenController();

        }

        private void V_PointScreen_Vong1_Load(object sender, EventArgs e)
        {
            tmrGetDiem.Enabled = true;
            tmrGetDiem.Interval = 300;
            tmrGetDiem.Start();
           
            
        }

        private void TmrGetDiem_Tick(object sender, EventArgs e)
        {
            _ctrl.GetAndUpdateTeam(this);
        }





        /// <summary>
        /// UI zone 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicWinCtrl_Click(object sender, EventArgs e)
        {
            if(picWinCtrl.Tag == null)
            {
                //this.WindowState = FormWindowState.Maximized;

                this.FormBorderStyle = FormBorderStyle.None;
                try
                {
                    if (_seconndPos == SecondScrenPosition.Top)
                    {
                        this.Width = Screen.AllScreens[1].Bounds.Width;
                        this.Height = Screen.AllScreens[1].Bounds.Height;
                        //phụ thuộc vào vị trí tương đói của màn hình
                        this.Left = 0 - ((this.Width - Screen.PrimaryScreen.Bounds.Width) / 2);
                        this.Top = 0 - this.Height;
                    }
                    if (_seconndPos == SecondScrenPosition.Left)
                    {
                        this.Width = Screen.AllScreens[1].Bounds.Width;
                        this.Height = Screen.AllScreens[1].Bounds.Height;
                        //phụ thuộc vào vị trí tương đói của màn hình
                        this.Left = 0 - this.Width;
                        this.Top = 0 - ((this.Height - Screen.PrimaryScreen.Bounds.Height));
                    }
                    if (_seconndPos == SecondScrenPosition.Right)
                    {
                        this.Width = Screen.AllScreens[1].Bounds.Width;
                        this.Height = Screen.AllScreens[1].Bounds.Height;
                        //phụ thuộc vào vị trí tương đói của màn hình
                        this.Left = 0 + Screen.PrimaryScreen.Bounds.Width;
                        this.Top = 0 + ((this.Height - Screen.PrimaryScreen.Bounds.Height));
                    }

                    if (_seconndPos == SecondScrenPosition.Bottom)
                    {
                        this.Width = Screen.AllScreens[1].Bounds.Width;
                        this.Height = Screen.AllScreens[1].Bounds.Height;
                        //phụ thuộc vào vị trí tương đói của màn hình
                        this.Left = 0 - ((this.Width - Screen.PrimaryScreen.Bounds.Width) / 2);
                        this.Top = 0 + Screen.PrimaryScreen.Bounds.Height;
                    }


                }
                catch
                {
                    this.Width = Screen.AllScreens[0].Bounds.Width;
                    this.Height = Screen.AllScreens[0].Bounds.Height;
                    //phụ thuộc vào vị trí tương đói của màn hình
                    this.Left = 0;
                    this.Top = 0;
                }
                
                //
                
                this.TopMost = true;
                //
                this.picWinCtrl.Image = global::PointScreen.Properties.Resources.arrowLight;
                this.picWinCtrl.Tag = 1;
            }
            else
            {
                this.Width = 1366;
                this.Height = 768;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.TopMost = false;
                //
                pnlSecondScreenPlace.Visible = true;
                //
                this.picWinCtrl.Image = global::PointScreen.Properties.Resources.arrowDark;
                this.picWinCtrl.Tag = null;
            }
        }
        private void ChooseSecondScreenPlace(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button clickedBtn = sender as Button;
                if(clickedBtn.Name.Contains("Top"))
                {
                    _seconndPos = SecondScrenPosition.Top;
                }
                else if (clickedBtn.Name.Contains("Right"))
                {
                    _seconndPos = SecondScrenPosition.Right;
                }
                else if (clickedBtn.Name.Contains("Bottom"))
                {
                    _seconndPos = SecondScrenPosition.Bottom;
                }
                else if (clickedBtn.Name.Contains("Left"))
                {
                    _seconndPos = SecondScrenPosition.Left;
                }
                //
                picWinCtrl.Enabled = true;
                lblCloseSetScreen.Visible = true;
                //
                btn2ndTop.BackColor = Color.LightGray;
                btn2ndRight.BackColor = Color.LightGray;
                btn2ndBottom.BackColor = Color.LightGray;
                btn2ndLeft.BackColor = Color.LightGray;
                //
                clickedBtn.BackColor = Color.Gray;
            }
            

        }

        private void LblCloseSetScreen_Click(object sender, EventArgs e)
        {
            pnlSecondScreenPlace.Visible = false;
        }
    }

    public interface IV_PointScreen_Adapter
    {

    }
}
