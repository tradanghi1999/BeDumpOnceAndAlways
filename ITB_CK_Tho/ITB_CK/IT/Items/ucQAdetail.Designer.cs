namespace IT.Items
{
    partial class ucQAdetail
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
            this.pnlitemContainer = new System.Windows.Forms.Panel();
            this.pnlNoiDungCauHoi = new System.Windows.Forms.Panel();
            this.btnHien = new System.Windows.Forms.Button();
            this.btnSai = new System.Windows.Forms.Button();
            this.btnDung = new System.Windows.Forms.Button();
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblSTTcauHoi = new System.Windows.Forms.Label();
            this.lblVong = new System.Windows.Forms.Label();
            this.lblTenDoi = new System.Windows.Forms.Label();
            this.pnlBorderBottom = new System.Windows.Forms.Panel();
            this.pnlBorderTop = new System.Windows.Forms.Panel();
            this.picMore = new System.Windows.Forms.PictureBox();
            this.rtbNoiDungCauHoi = new System.Windows.Forms.RichTextBox();
            this.pnlitemContainer.SuspendLayout();
            this.pnlNoiDungCauHoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlitemContainer
            // 
            this.pnlitemContainer.Controls.Add(this.pnlNoiDungCauHoi);
            this.pnlitemContainer.Controls.Add(this.btnHien);
            this.pnlitemContainer.Controls.Add(this.btnSai);
            this.pnlitemContainer.Controls.Add(this.btnDung);
            this.pnlitemContainer.Controls.Add(this.lblDiem);
            this.pnlitemContainer.Controls.Add(this.lblSTTcauHoi);
            this.pnlitemContainer.Controls.Add(this.lblVong);
            this.pnlitemContainer.Controls.Add(this.lblTenDoi);
            this.pnlitemContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlitemContainer.Location = new System.Drawing.Point(3, 7);
            this.pnlitemContainer.Name = "pnlitemContainer";
            this.pnlitemContainer.Size = new System.Drawing.Size(1342, 86);
            this.pnlitemContainer.TabIndex = 0;
            // 
            // pnlNoiDungCauHoi
            // 
            this.pnlNoiDungCauHoi.Controls.Add(this.rtbNoiDungCauHoi);
            this.pnlNoiDungCauHoi.Controls.Add(this.picMore);
            this.pnlNoiDungCauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNoiDungCauHoi.Location = new System.Drawing.Point(532, 0);
            this.pnlNoiDungCauHoi.Name = "pnlNoiDungCauHoi";
            this.pnlNoiDungCauHoi.Size = new System.Drawing.Size(474, 86);
            this.pnlNoiDungCauHoi.TabIndex = 7;
            // 
            // btnHien
            // 
            this.btnHien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHien.BackColor = System.Drawing.SystemColors.Control;
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHien.Location = new System.Drawing.Point(1244, 20);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(95, 44);
            this.btnHien.TabIndex = 6;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = false;
            // 
            // btnSai
            // 
            this.btnSai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSai.FlatAppearance.BorderSize = 0;
            this.btnSai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSai.Location = new System.Drawing.Point(1127, 22);
            this.btnSai.Name = "btnSai";
            this.btnSai.Size = new System.Drawing.Size(88, 41);
            this.btnSai.TabIndex = 6;
            this.btnSai.Text = "Sai";
            this.btnSai.UseVisualStyleBackColor = true;
            this.btnSai.Click += new System.EventHandler(this.BtnSai_Click);
            // 
            // btnDung
            // 
            this.btnDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDung.FlatAppearance.BorderSize = 0;
            this.btnDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDung.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDung.Location = new System.Drawing.Point(1012, 21);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(95, 44);
            this.btnDung.TabIndex = 5;
            this.btnDung.Text = "Đúng";
            this.btnDung.UseVisualStyleBackColor = true;
            this.btnDung.Click += new System.EventHandler(this.BtnDung_Click);
            // 
            // lblDiem
            // 
            this.lblDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(420, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(112, 86);
            this.lblDiem.TabIndex = 3;
            this.lblDiem.Text = "Điểm";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSTTcauHoi
            // 
            this.lblSTTcauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSTTcauHoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTTcauHoi.Location = new System.Drawing.Point(308, 0);
            this.lblSTTcauHoi.Name = "lblSTTcauHoi";
            this.lblSTTcauHoi.Size = new System.Drawing.Size(112, 86);
            this.lblSTTcauHoi.TabIndex = 2;
            this.lblSTTcauHoi.Text = "STT";
            this.lblSTTcauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVong
            // 
            this.lblVong.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVong.Location = new System.Drawing.Point(214, 0);
            this.lblVong.Name = "lblVong";
            this.lblVong.Size = new System.Drawing.Size(94, 86);
            this.lblVong.TabIndex = 1;
            this.lblVong.Text = "Vòng";
            this.lblVong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenDoi
            // 
            this.lblTenDoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTenDoi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDoi.Location = new System.Drawing.Point(0, 0);
            this.lblTenDoi.Name = "lblTenDoi";
            this.lblTenDoi.Size = new System.Drawing.Size(214, 86);
            this.lblTenDoi.TabIndex = 0;
            this.lblTenDoi.Text = "Tên Đội";
            this.lblTenDoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBorderBottom
            // 
            this.pnlBorderBottom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBorderBottom.Location = new System.Drawing.Point(0, 98);
            this.pnlBorderBottom.Name = "pnlBorderBottom";
            this.pnlBorderBottom.Size = new System.Drawing.Size(1348, 1);
            this.pnlBorderBottom.TabIndex = 1;
            // 
            // pnlBorderTop
            // 
            this.pnlBorderTop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorderTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBorderTop.Name = "pnlBorderTop";
            this.pnlBorderTop.Size = new System.Drawing.Size(1348, 1);
            this.pnlBorderTop.TabIndex = 1;
            // 
            // picMore
            // 
            this.picMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picMore.Image = global::IT.Properties.Resources.arrow;
            this.picMore.Location = new System.Drawing.Point(441, 53);
            this.picMore.Name = "picMore";
            this.picMore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.picMore.Size = new System.Drawing.Size(25, 30);
            this.picMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMore.TabIndex = 5;
            this.picMore.TabStop = false;
            this.picMore.Click += new System.EventHandler(this.PicMore_Click);
            this.picMore.MouseLeave += new System.EventHandler(this.PicMore_MouseLeave);
            this.picMore.MouseHover += new System.EventHandler(this.PicMore_MouseHover);
            // 
            // rtbNoiDungCauHoi
            // 
            this.rtbNoiDungCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNoiDungCauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbNoiDungCauHoi.Location = new System.Drawing.Point(0, 0);
            this.rtbNoiDungCauHoi.Name = "rtbNoiDungCauHoi";
            this.rtbNoiDungCauHoi.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbNoiDungCauHoi.Size = new System.Drawing.Size(435, 86);
            this.rtbNoiDungCauHoi.TabIndex = 6;
            this.rtbNoiDungCauHoi.Text = "Song Tren Doi Tinh La Gi Ma Khien NGuio Ta Phai Kho";
            // 
            // ucQAdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBorderTop);
            this.Controls.Add(this.pnlBorderBottom);
            this.Controls.Add(this.pnlitemContainer);
            this.Name = "ucQAdetail";
            this.Size = new System.Drawing.Size(1348, 99);
            this.pnlitemContainer.ResumeLayout(false);
            this.pnlNoiDungCauHoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlitemContainer;
        private System.Windows.Forms.Panel pnlNoiDungCauHoi;
        private System.Windows.Forms.PictureBox picMore;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.Button btnSai;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label lblSTTcauHoi;
        private System.Windows.Forms.Label lblVong;
        private System.Windows.Forms.Label lblTenDoi;
        private System.Windows.Forms.Panel pnlBorderBottom;
        private System.Windows.Forms.Panel pnlBorderTop;
        private System.Windows.Forms.RichTextBox rtbNoiDungCauHoi;
    }
}
