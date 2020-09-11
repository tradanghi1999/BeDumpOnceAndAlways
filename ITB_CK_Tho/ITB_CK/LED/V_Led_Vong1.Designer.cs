namespace LED
{
    partial class V_Led_Vong1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDapAn = new System.Windows.Forms.Label();
            this.lblCau = new System.Windows.Forms.Label();
            this.rtbNoiDungCau = new System.Windows.Forms.Label();
            this.lblFullScreen = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.lblABCD = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDapAn
            // 
            this.lblDapAn.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAn.Location = new System.Drawing.Point(557, 574);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(525, 123);
            this.lblDapAn.TabIndex = 2;
            this.lblDapAn.Text = "...";
            this.lblDapAn.Visible = false;
            // 
            // lblCau
            // 
            this.lblCau.AutoSize = true;
            this.lblCau.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCau.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCau.ForeColor = System.Drawing.Color.White;
            this.lblCau.Location = new System.Drawing.Point(56, 61);
            this.lblCau.Name = "lblCau";
            this.lblCau.Size = new System.Drawing.Size(110, 36);
            this.lblCau.TabIndex = 2;
            this.lblCau.Text = "Câu ...:";
            this.lblCau.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // rtbNoiDungCau
            // 
            this.rtbNoiDungCau.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDungCau.ForeColor = System.Drawing.Color.White;
            this.rtbNoiDungCau.Location = new System.Drawing.Point(116, 109);
            this.rtbNoiDungCau.Name = "rtbNoiDungCau";
            this.rtbNoiDungCau.Size = new System.Drawing.Size(177, 42);
            this.rtbNoiDungCau.TabIndex = 2;
            this.rtbNoiDungCau.Text = "Noi Dung";
            this.rtbNoiDungCau.Click += new System.EventHandler(this.RtbNoiDungCau_Click);
            // 
            // lblFullScreen
            // 
            this.lblFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullScreen.AutoSize = true;
            this.lblFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullScreen.Location = new System.Drawing.Point(834, 9);
            this.lblFullScreen.Name = "lblFullScreen";
            this.lblFullScreen.Size = new System.Drawing.Size(20, 24);
            this.lblFullScreen.TabIndex = 7;
            this.lblFullScreen.Text = "[]";
            this.lblFullScreen.Click += new System.EventHandler(this.LblFullScreen_Click);
            this.lblFullScreen.MouseLeave += new System.EventHandler(this.LblFullScreen_MouseLeave);
            this.lblFullScreen.MouseHover += new System.EventHandler(this.LblFullScreen_MouseHover);
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDown.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 55.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.White;
            this.lblCountDown.Location = new System.Drawing.Point(682, 28);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(195, 136);
            this.lblCountDown.TabIndex = 8;
            this.lblCountDown.Text = "90";
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.TmrCountDown_Tick);
            // 
            // lblABCD
            // 
            this.lblABCD.BackColor = System.Drawing.Color.Transparent;
            this.lblABCD.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABCD.ForeColor = System.Drawing.Color.White;
            this.lblABCD.Location = new System.Drawing.Point(116, 176);
            this.lblABCD.Name = "lblABCD";
            this.lblABCD.Size = new System.Drawing.Size(686, 42);
            this.lblABCD.TabIndex = 2;
            this.lblABCD.Text = "Noi Dung";
            this.lblABCD.Click += new System.EventHandler(this.RtbNoiDungCau_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(123, 176);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(430, 227);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 9;
            this.pic.TabStop = false;
            // 
            // V_Led_Vong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 500);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblFullScreen);
            this.Controls.Add(this.lblCau);
            this.Controls.Add(this.lblABCD);
            this.Controls.Add(this.rtbNoiDungCau);
            this.Controls.Add(this.lblDapAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_Led_Vong1";
            this.Text = "0,0,0,0";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.Label lblCau;
        private System.Windows.Forms.Label rtbNoiDungCau;
        private System.Windows.Forms.Label lblFullScreen;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.Label lblABCD;
        private System.Windows.Forms.PictureBox pic;
    }
}

