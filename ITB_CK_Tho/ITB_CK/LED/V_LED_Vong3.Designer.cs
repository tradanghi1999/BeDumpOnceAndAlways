using System.Drawing;
using System.Windows.Forms;
using LED;

namespace LED
{
    partial class V_LED_Vong3
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
            this.lblDapAn = new System.Windows.Forms.Label();
            this.lblCau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbNoiDungCau = new System.Windows.Forms.Label();
            this.lblFullScreen = new System.Windows.Forms.Label();
            this.lblDiemDoi1 = new System.Windows.Forms.Label();
            this.lblDoi3 = new System.Windows.Forms.Label();
            this.lblDiemDoi3 = new System.Windows.Forms.Label();
            this.lblDoi2 = new System.Windows.Forms.Label();
            this.lblDiemDoi2 = new System.Windows.Forms.Label();
            this.lblDoi1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDapAn
            // 
            this.lblDapAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(155)))), ((int)(((byte)(182)))));
            this.lblDapAn.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAn.Location = new System.Drawing.Point(566, 573);
            this.lblDapAn.Margin = new System.Windows.Forms.Padding(0);
            this.lblDapAn.Name = "lblDapAn";
            this.lblDapAn.Size = new System.Drawing.Size(501, 122);
            this.lblDapAn.TabIndex = 3;
            this.lblDapAn.Text = "Key";
            // 
            // lblCau
            // 
            this.lblCau.AutoSize = true;
            this.lblCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            this.lblCau.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(147)))), ((int)(((byte)(189)))));
            this.lblCau.Location = new System.Drawing.Point(219, 293);
            this.lblCau.Name = "lblCau";
            this.lblCau.Size = new System.Drawing.Size(36, 36);
            this.lblCau.TabIndex = 3;
            this.lblCau.Text = "...";
            this.lblCau.Click += new System.EventHandler(this.LblCau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            this.label2.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(147)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(255, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            this.label1.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(147)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(149, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CÂU";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // rtbNoiDungCau
            // 
            this.rtbNoiDungCau.Font = new System.Drawing.Font("#9Slide03 SVNNexa Rust Sans Bla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDungCau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(147)))), ((int)(((byte)(189)))));
            this.rtbNoiDungCau.Location = new System.Drawing.Point(261, 333);
            this.rtbNoiDungCau.Name = "rtbNoiDungCau";
            this.rtbNoiDungCau.Size = new System.Drawing.Size(843, 196);
            this.rtbNoiDungCau.TabIndex = 5;
            this.rtbNoiDungCau.Text = "label3";
            // 
            // lblFullScreen
            // 
            this.lblFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullScreen.AutoSize = true;
            this.lblFullScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullScreen.Location = new System.Drawing.Point(1306, 6);
            this.lblFullScreen.Name = "lblFullScreen";
            this.lblFullScreen.Size = new System.Drawing.Size(20, 24);
            this.lblFullScreen.TabIndex = 6;
            this.lblFullScreen.Text = "[]";
            this.lblFullScreen.Click += new System.EventHandler(this.LblFullScreen_Click);
            this.lblFullScreen.MouseLeave += new System.EventHandler(this.LblFullScreen_MouseLeave);
            this.lblFullScreen.MouseHover += new System.EventHandler(this.LblFullScreen_MouseHover);
            // 
            // lblDiemDoi1
            // 
            this.lblDiemDoi1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiemDoi1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDoi1.Location = new System.Drawing.Point(-3, 220);
            this.lblDiemDoi1.Name = "lblDiemDoi1";
            this.lblDiemDoi1.Size = new System.Drawing.Size(438, 50);
            this.lblDiemDoi1.TabIndex = 3;
            this.lblDiemDoi1.Text = "...";
            this.lblDiemDoi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDoi3
            // 
            this.lblDoi3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDoi3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoi3.Location = new System.Drawing.Point(896, 170);
            this.lblDoi3.Name = "lblDoi3";
            this.lblDoi3.Size = new System.Drawing.Size(440, 50);
            this.lblDoi3.TabIndex = 3;
            this.lblDoi3.Text = "Đội 3";
            this.lblDoi3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiemDoi3
            // 
            this.lblDiemDoi3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiemDoi3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDoi3.Location = new System.Drawing.Point(910, 220);
            this.lblDiemDoi3.Name = "lblDiemDoi3";
            this.lblDiemDoi3.Size = new System.Drawing.Size(440, 50);
            this.lblDiemDoi3.TabIndex = 4;
            this.lblDiemDoi3.Text = "...";
            this.lblDiemDoi3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoi2
            // 
            this.lblDoi2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDoi2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoi2.Location = new System.Drawing.Point(444, 170);
            this.lblDoi2.Name = "lblDoi2";
            this.lblDoi2.Size = new System.Drawing.Size(452, 50);
            this.lblDoi2.TabIndex = 3;
            this.lblDoi2.Text = "Đội 2";
            this.lblDoi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiemDoi2
            // 
            this.lblDiemDoi2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDiemDoi2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemDoi2.Location = new System.Drawing.Point(441, 220);
            this.lblDiemDoi2.Name = "lblDiemDoi2";
            this.lblDiemDoi2.Size = new System.Drawing.Size(452, 50);
            this.lblDiemDoi2.TabIndex = 4;
            this.lblDiemDoi2.Text = "...";
            this.lblDiemDoi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDoi1
            // 
            this.lblDoi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(223)))));
            this.lblDoi1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoi1.Location = new System.Drawing.Point(12, 170);
            this.lblDoi1.Name = "lblDoi1";
            this.lblDoi1.Size = new System.Drawing.Size(438, 50);
            this.lblDoi1.TabIndex = 2;
            this.lblDoi1.Text = "Đội 1";
            this.lblDoi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // V_LED_Vong3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.lblDoi3);
            this.Controls.Add(this.lblDiemDoi3);
            this.Controls.Add(this.lblDiemDoi1);
            this.Controls.Add(this.lblDoi2);
            this.Controls.Add(this.lblFullScreen);
            this.Controls.Add(this.lblDiemDoi2);
            this.Controls.Add(this.rtbNoiDungCau);
            this.Controls.Add(this.lblDoi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCau);
            this.Controls.Add(this.lblDapAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_LED_Vong3";
            this.Text = "V_LED_Vong3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDapAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCau;
        private System.Windows.Forms.Label label2;
        private Label rtbNoiDungCau;
        private Label lblFullScreen;
        private Label lblDiemDoi1;
        private Label lblDoi3;
        private Label lblDiemDoi3;
        private Label lblDoi2;
        private Label lblDiemDoi2;
        private Label lblDoi1;
    }
}