namespace FourteenFeb
{
    partial class Tram
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
            this.tmrSpin = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblCop = new System.Windows.Forms.Label();
            this.lblLoiChuc = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmrSpin
            // 
            this.tmrSpin.Interval = 1000;
            this.tmrSpin.Tick += new System.EventHandler(this.TmrSpin_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 1);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 468);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(956, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 468);
            this.panel4.TabIndex = 4;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(928, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(17, 17);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.LblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.LblClose_MouseHover);
            // 
            // lblCop
            // 
            this.lblCop.AutoSize = true;
            this.lblCop.Location = new System.Drawing.Point(26, 440);
            this.lblCop.Name = "lblCop";
            this.lblCop.Size = new System.Drawing.Size(138, 17);
            this.lblCop.TabIndex = 6;
            this.lblCop.Text = "@ Copyright by TDN";
            this.lblCop.Click += new System.EventHandler(this.LblCop_Click);
            // 
            // lblLoiChuc
            // 
            this.lblLoiChuc.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoiChuc.ForeColor = System.Drawing.Color.HotPink;
            this.lblLoiChuc.Location = new System.Drawing.Point(0, 396);
            this.lblLoiChuc.Name = "lblLoiChuc";
            this.lblLoiChuc.Size = new System.Drawing.Size(957, 31);
            this.lblLoiChuc.TabIndex = 7;
            this.lblLoiChuc.Text = "Chúc T-Em Ngày Vui";
            this.lblLoiChuc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoiChuc.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(311, 319);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(313, 23);
            this.lblHint.TabIndex = 8;
            this.lblHint.Text = "The Wish Sent To U EveryNight";
            // 
            // Tram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 469);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblLoiChuc);
            this.Controls.Add(this.lblCop);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tram_FormClosing);
            this.Load += new System.EventHandler(this.Tram_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrSpin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblCop;
        private System.Windows.Forms.Label lblLoiChuc;
        private System.Windows.Forms.Label lblHint;
    }
}