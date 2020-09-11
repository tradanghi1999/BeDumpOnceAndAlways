namespace ITB_CK.Team.Team_PointScreen
{
    partial class Team_PointScrean
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
            this.lblTenDoi = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenDoi
            // 
            this.lblTenDoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenDoi.Font = new System.Drawing.Font("Verdana", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDoi.Location = new System.Drawing.Point(0, 0);
            this.lblTenDoi.Name = "lblTenDoi";
            this.lblTenDoi.Size = new System.Drawing.Size(1366, 226);
            this.lblTenDoi.TabIndex = 0;
            this.lblTenDoi.Text = "(Tên Đội)";
            this.lblTenDoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDiem
            // 
            this.lblDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiem.Font = new System.Drawing.Font("Verdana", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(0, 226);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(1366, 279);
            this.lblDiem.TabIndex = 1;
            this.lblDiem.Text = "(Điểm)";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Team_PointScrean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.lblTenDoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Team_PointScrean";
            this.Text = "Team_PointScrean";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenDoi;
        private System.Windows.Forms.Label lblDiem;
    }
}