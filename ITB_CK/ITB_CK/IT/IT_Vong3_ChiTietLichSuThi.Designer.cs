namespace ITB_CK.IT
{
    partial class IT_Vong3_ChiTietLichSuThi
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitleCon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpChiTietLichSuThiContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHeader.Controls.Add(this.lblTitleCon);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1348, 163);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitleCon
            // 
            this.lblTitleCon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitleCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCon.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCon.Location = new System.Drawing.Point(0, 82);
            this.lblTitleCon.Name = "lblTitleCon";
            this.lblTitleCon.Size = new System.Drawing.Size(1348, 42);
            this.lblTitleCon.TabIndex = 1;
            this.lblTitleCon.Text = "(IT - Vòng 3 - Lịch Sử Thi)";
            this.lblTitleCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1348, 82);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vòng Chung Kết";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1348, 123);
            this.panel2.TabIndex = 5;
            // 
            // flpChiTietLichSuThiContainer
            // 
            this.flpChiTietLichSuThiContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpChiTietLichSuThiContainer.Location = new System.Drawing.Point(0, 163);
            this.flpChiTietLichSuThiContainer.Name = "flpChiTietLichSuThiContainer";
            this.flpChiTietLichSuThiContainer.Size = new System.Drawing.Size(1348, 435);
            this.flpChiTietLichSuThiContainer.TabIndex = 6;
            // 
            // IT_Vong3_ChiTietLichSuThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.flpChiTietLichSuThiContainer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel2);
            this.Name = "IT_Vong3_ChiTietLichSuThi";
            this.Text = "IT_ChiTietThiVong3";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitleCon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpChiTietLichSuThiContainer;
    }
}