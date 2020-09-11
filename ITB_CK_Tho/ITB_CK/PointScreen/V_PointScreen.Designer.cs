namespace PointScreen
{
    partial class V_PointScreen
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
            this.lblDiem = new System.Windows.Forms.Label();
            this.tmrGetDiem = new System.Windows.Forms.Timer(this.components);
            this.picWinCtrl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWinCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.White;
            this.lblDiem.Location = new System.Drawing.Point(0, 227);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(1348, 279);
            this.lblDiem.TabIndex = 3;
            this.lblDiem.Text = "(Điểm)";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tmrGetDiem
            // 
            this.tmrGetDiem.Tick += new System.EventHandler(this.TmrGetDiem_Tick);
            // 
            // picWinCtrl
            // 
            this.picWinCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picWinCtrl.Image = global::PointScreen.Properties.Resources.arrowDark;
            this.picWinCtrl.Location = new System.Drawing.Point(1316, 685);
            this.picWinCtrl.Name = "picWinCtrl";
            this.picWinCtrl.Size = new System.Drawing.Size(32, 35);
            this.picWinCtrl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWinCtrl.TabIndex = 4;
            this.picWinCtrl.TabStop = false;
            this.picWinCtrl.Click += new System.EventHandler(this.PicWinCtrl_Click);
            // 
            // V_PointScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.picWinCtrl);
            this.Name = "V_PointScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.V_PointScreen_Vong1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWinCtrl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Timer tmrGetDiem;
        private System.Windows.Forms.PictureBox picWinCtrl;
    }
}

