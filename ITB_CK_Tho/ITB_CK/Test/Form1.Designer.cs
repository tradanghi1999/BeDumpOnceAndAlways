namespace Test
{
    partial class Form1
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
            this.btnGetLocation = new System.Windows.Forms.Button();
            this.btnMaximizeOnScree = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSecondScreenPlace = new System.Windows.Forms.Panel();
            this.lblCloseSetScreen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2ndBottom = new System.Windows.Forms.Button();
            this.btn2ndTop = new System.Windows.Forms.Button();
            this.btn2ndRight = new System.Windows.Forms.Button();
            this.btn2ndLeft = new System.Windows.Forms.Button();
            this.btn1st = new System.Windows.Forms.Button();
            this.pnlSecondScreenPlace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetLocation
            // 
            this.btnGetLocation.Location = new System.Drawing.Point(237, 12);
            this.btnGetLocation.Name = "btnGetLocation";
            this.btnGetLocation.Size = new System.Drawing.Size(131, 85);
            this.btnGetLocation.TabIndex = 0;
            this.btnGetLocation.Text = "btnGetLocation";
            this.btnGetLocation.UseVisualStyleBackColor = true;
            this.btnGetLocation.Click += new System.EventHandler(this.BtnGetLocation_Click);
            // 
            // btnMaximizeOnScree
            // 
            this.btnMaximizeOnScree.Location = new System.Drawing.Point(617, 12);
            this.btnMaximizeOnScree.Name = "btnMaximizeOnScree";
            this.btnMaximizeOnScree.Size = new System.Drawing.Size(131, 85);
            this.btnMaximizeOnScree.TabIndex = 0;
            this.btnMaximizeOnScree.Text = "btnMaximizeOnScreen";
            this.btnMaximizeOnScree.UseVisualStyleBackColor = true;
            this.btnMaximizeOnScree.Click += new System.EventHandler(this.BtnMaximizeOnScree_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 574);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(975, 15);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pnlSecondScreenPlace
            // 
            this.pnlSecondScreenPlace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSecondScreenPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecondScreenPlace.Controls.Add(this.lblCloseSetScreen);
            this.pnlSecondScreenPlace.Controls.Add(this.label1);
            this.pnlSecondScreenPlace.Controls.Add(this.btn2ndBottom);
            this.pnlSecondScreenPlace.Controls.Add(this.btn2ndTop);
            this.pnlSecondScreenPlace.Controls.Add(this.btn2ndRight);
            this.pnlSecondScreenPlace.Controls.Add(this.btn2ndLeft);
            this.pnlSecondScreenPlace.Controls.Add(this.btn1st);
            this.pnlSecondScreenPlace.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSecondScreenPlace.ForeColor = System.Drawing.Color.White;
            this.pnlSecondScreenPlace.Location = new System.Drawing.Point(178, 123);
            this.pnlSecondScreenPlace.Name = "pnlSecondScreenPlace";
            this.pnlSecondScreenPlace.Size = new System.Drawing.Size(636, 411);
            this.pnlSecondScreenPlace.TabIndex = 6;
            // 
            // lblCloseSetScreen
            // 
            this.lblCloseSetScreen.AutoSize = true;
            this.lblCloseSetScreen.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseSetScreen.ForeColor = System.Drawing.Color.Black;
            this.lblCloseSetScreen.Location = new System.Drawing.Point(611, 2);
            this.lblCloseSetScreen.Name = "lblCloseSetScreen";
            this.lblCloseSetScreen.Size = new System.Drawing.Size(20, 24);
            this.lblCloseSetScreen.TabIndex = 1;
            this.lblCloseSetScreen.Text = "x";
            this.lblCloseSetScreen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCloseSetScreen.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose second screen place to begin";
            // 
            // btn2ndBottom
            // 
            this.btn2ndBottom.BackColor = System.Drawing.Color.LightGray;
            this.btn2ndBottom.FlatAppearance.BorderSize = 0;
            this.btn2ndBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndBottom.Location = new System.Drawing.Point(244, 300);
            this.btn2ndBottom.Name = "btn2ndBottom";
            this.btn2ndBottom.Size = new System.Drawing.Size(131, 74);
            this.btn2ndBottom.TabIndex = 0;
            this.btn2ndBottom.Text = "2";
            this.btn2ndBottom.UseVisualStyleBackColor = false;
            this.btn2ndBottom.Click += new System.EventHandler(this.Btn2ndBottom_Click);
            // 
            // btn2ndTop
            // 
            this.btn2ndTop.BackColor = System.Drawing.Color.LightGray;
            this.btn2ndTop.FlatAppearance.BorderSize = 0;
            this.btn2ndTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndTop.Location = new System.Drawing.Point(244, 98);
            this.btn2ndTop.Name = "btn2ndTop";
            this.btn2ndTop.Size = new System.Drawing.Size(131, 74);
            this.btn2ndTop.TabIndex = 0;
            this.btn2ndTop.Text = "2";
            this.btn2ndTop.UseVisualStyleBackColor = false;
            this.btn2ndTop.Click += new System.EventHandler(this.Btn2ndTop_Click);
            // 
            // btn2ndRight
            // 
            this.btn2ndRight.BackColor = System.Drawing.Color.LightGray;
            this.btn2ndRight.FlatAppearance.BorderSize = 0;
            this.btn2ndRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndRight.Location = new System.Drawing.Point(404, 196);
            this.btn2ndRight.Name = "btn2ndRight";
            this.btn2ndRight.Size = new System.Drawing.Size(131, 74);
            this.btn2ndRight.TabIndex = 0;
            this.btn2ndRight.Text = "2";
            this.btn2ndRight.UseVisualStyleBackColor = false;
            this.btn2ndRight.Click += new System.EventHandler(this.Btn2ndRight_Click);
            // 
            // btn2ndLeft
            // 
            this.btn2ndLeft.BackColor = System.Drawing.Color.LightGray;
            this.btn2ndLeft.FlatAppearance.BorderSize = 0;
            this.btn2ndLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2ndLeft.Location = new System.Drawing.Point(85, 196);
            this.btn2ndLeft.Name = "btn2ndLeft";
            this.btn2ndLeft.Size = new System.Drawing.Size(131, 74);
            this.btn2ndLeft.TabIndex = 0;
            this.btn2ndLeft.Text = "2";
            this.btn2ndLeft.UseVisualStyleBackColor = false;
            this.btn2ndLeft.Click += new System.EventHandler(this.Btn2ndLeft_Click);
            // 
            // btn1st
            // 
            this.btn1st.BackColor = System.Drawing.Color.Gray;
            this.btn1st.FlatAppearance.BorderSize = 0;
            this.btn1st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1st.Location = new System.Drawing.Point(244, 196);
            this.btn1st.Name = "btn1st";
            this.btn1st.Size = new System.Drawing.Size(131, 74);
            this.btn1st.TabIndex = 0;
            this.btn1st.Text = "1";
            this.btn1st.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 589);
            this.Controls.Add(this.pnlSecondScreenPlace);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnMaximizeOnScree);
            this.Controls.Add(this.btnGetLocation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSecondScreenPlace.ResumeLayout(false);
            this.pnlSecondScreenPlace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetLocation;
        private System.Windows.Forms.Button btnMaximizeOnScree;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlSecondScreenPlace;
        private System.Windows.Forms.Label lblCloseSetScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2ndBottom;
        private System.Windows.Forms.Button btn2ndTop;
        private System.Windows.Forms.Button btn2ndRight;
        private System.Windows.Forms.Button btn2ndLeft;
        private System.Windows.Forms.Button btn1st;
    }
}

