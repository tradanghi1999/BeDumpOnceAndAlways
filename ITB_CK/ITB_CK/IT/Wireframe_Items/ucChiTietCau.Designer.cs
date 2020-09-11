namespace ITB_CK.IT.Wireframe_Items
{
    partial class ucChiTietCau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCau = new System.Windows.Forms.Label();
            this.rtbNoiDungCau = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 85);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbNoiDungCau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(447, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 85);
            this.panel2.TabIndex = 0;
            // 
            // lblCau
            // 
            this.lblCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCau.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCau.Location = new System.Drawing.Point(0, 0);
            this.lblCau.Name = "lblCau";
            this.lblCau.Size = new System.Drawing.Size(447, 85);
            this.lblCau.TabIndex = 0;
            this.lblCau.Text = "Câu 1:";
            this.lblCau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbNoiDungCau
            // 
            this.rtbNoiDungCau.BackColor = System.Drawing.SystemColors.Control;
            this.rtbNoiDungCau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNoiDungCau.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNoiDungCau.Location = new System.Drawing.Point(21, 28);
            this.rtbNoiDungCau.Name = "rtbNoiDungCau";
            this.rtbNoiDungCau.Size = new System.Drawing.Size(707, 42);
            this.rtbNoiDungCau.TabIndex = 0;
            this.rtbNoiDungCau.Text = "Nội Dung Nội Dung Nội Dung";
            // 
            // ucChiTietCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucChiTietCau";
            this.Size = new System.Drawing.Size(1366, 85);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbNoiDungCau;
    }
}
