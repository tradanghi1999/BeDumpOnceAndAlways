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
    public partial class V_LED_HienDiem : View
    {
        public V_LED_HienDiem()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        //
        //
        //
        Image myBackGround = Image.FromFile(Application.StartupPath + "//Res//diemtongV1.png");
        //Image piCVong2 = Image.FromFile(Application.StartupPath + "Res//diemtongV2.png");
        //Image piCVong3 = Image.FromFile(Application.StartupPath + "Res//diemtongV3.png");
        public override void Graphicialize()
        {
            this.BackgroundImage = (Image)(LIB.ResizeImage((Image)(myBackGround), this.Width, this.Height));
            this.lblDiemDoiNhat.BackColor = lblDiemDoiBa.BackColor = lblDiemDoiNhi.BackColor = lblDoiBa.BackColor = lblDoiNhat.BackColor = lblDoiNhi.BackColor = Color.Transparent; 

            base.Graphicialize();
        }
        double tiLeChu = 30 * 1.0 / 500;

        public override void ResizeControls()
        {
            this.lblDiemDoiNhat.Font = lblDiemDoiNhi.Font = lblDiemDoiBa.Font = lblDoiNhat.Font = lblDoiNhi.Font = lblDoiBa.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", (float)(this.Height * 1.0 *   tiLeChu), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            base.ResizeControls();

        }

        public string TenDoiNhat
        {
            set
            {
                lblDoiNhat.Text = value;
            }
        }
        public string TenDoiNhi
        {
            set
            {
                lblDoiNhi.Text = value;
            }
        }
        public string TenDoiBa
        {
            set
            {
                lblDoiBa.Text = value;
            }
        }
        public string DiemDoiNhat
        {
            set
            {
                lblDiemDoiNhat.Text = value;
            }
        }
        public string DiemDoiNhi
        {
            set
            {
                lblDiemDoiNhi.Text = value;
            }
        }
        public string DiemDoiBa
        {
            set
            {
                lblDiemDoiBa.Text = value;
            }
        }

        double toadoXTuongDoiDoiNhat = 0.35,
                toadoXTuongDoiDoiNhi = 0.535,
                toadoXTuongDoiDoiBa = 0.715,
            toadoYTuongDoiDoi = 0.16,
                toadoYTuongDoiDiem = 0.7;
        public override void RelocatingControls()
        {
            lblDoiNhat.Top = lblDiemDoiNhat.Top = (int)(toadoXTuongDoiDoiNhat * 1.0 * this.Height);
            lblDiemDoiNhi.Top = lblDoiNhi.Top = (int)(toadoXTuongDoiDoiNhi * 1.0 * this.Height);
            lblDiemDoiBa.Top = lblDoiBa.Top = (int)(toadoXTuongDoiDoiBa * 1.0 * this.Height);
            lblDoiNhat.Left = lblDoiNhi.Left = lblDoiBa.Left = (int)(toadoYTuongDoiDoi * 1.0 * this.Width);
            lblDiemDoiNhi.Left = lblDiemDoiNhat.Left = lblDiemDoiBa.Left = (int)(toadoYTuongDoiDiem * 1.0 * this.Width);
            base.RelocatingControls();
        }

        internal void LblFullScreen_Click(object p, EventArgs empty)
        {
            LIB.MakeFullScreen(this, null);
            ResizeControls();
            RelocatingControls();
            Graphicialize();
        }
    }
}
