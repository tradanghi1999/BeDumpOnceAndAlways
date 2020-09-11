namespace MC
{
    partial class V_Vong1_PendingStart
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
            this.lblTitleCon = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl3dot = new System.Windows.Forms.Label();
            this.tmr3dot = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTitleCon
            // 
            this.lblTitleCon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitleCon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCon.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCon.Location = new System.Drawing.Point(0, 82);
            this.lblTitleCon.Name = "lblTitleCon";
            this.lblTitleCon.Size = new System.Drawing.Size(1348, 42);
            this.lblTitleCon.TabIndex = 3;
            this.lblTitleCon.Text = "(Vòng 1 - Đội ...)";
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
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Vòng Chung Kết";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3dot
            // 
            this.lbl3dot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3dot.AutoSize = true;
            this.lbl3dot.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3dot.Location = new System.Drawing.Point(579, 271);
            this.lbl3dot.Name = "lbl3dot";
            this.lbl3dot.Size = new System.Drawing.Size(169, 159);
            this.lbl3dot.TabIndex = 4;
            this.lbl3dot.Text = "...";
            this.lbl3dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr3dot
            // 
            this.tmr3dot.Tick += new System.EventHandler(this.Tmr3dot_Tick);
            // 
            // V_Vong1_PendingStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.lbl3dot);
            this.Controls.Add(this.lblTitleCon);
            this.Controls.Add(this.lblTitle);
            this.Name = "V_Vong1_PendingStart";
            this.Text = "V_Vong1_PendingStart";
            this.Load += new System.EventHandler(this.V_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCon;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl3dot;
        private System.Windows.Forms.Timer tmr3dot;
    }
}