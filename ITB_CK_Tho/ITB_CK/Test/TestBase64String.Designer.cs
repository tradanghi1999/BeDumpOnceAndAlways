namespace Test
{
    partial class TestBase64String
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetFile = new System.Windows.Forms.Button();
            this.txbDuongDan = new System.Windows.Forms.TextBox();
            this.rtbKQ = new System.Windows.Forms.RichTextBox();
            this.btnGet1Question = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(170, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetFile
            // 
            this.btnGetFile.Location = new System.Drawing.Point(178, 437);
            this.btnGetFile.Name = "btnGetFile";
            this.btnGetFile.Size = new System.Drawing.Size(99, 40);
            this.btnGetFile.TabIndex = 1;
            this.btnGetFile.Text = "Get File";
            this.btnGetFile.UseVisualStyleBackColor = true;
            this.btnGetFile.Click += new System.EventHandler(this.BtnGetFile_Click);
            // 
            // txbDuongDan
            // 
            this.txbDuongDan.Location = new System.Drawing.Point(169, 399);
            this.txbDuongDan.Name = "txbDuongDan";
            this.txbDuongDan.Size = new System.Drawing.Size(125, 22);
            this.txbDuongDan.TabIndex = 2;
            this.txbDuongDan.Click += new System.EventHandler(this.TxbDuongDan_Click);
            // 
            // rtbKQ
            // 
            this.rtbKQ.Location = new System.Drawing.Point(170, 172);
            this.rtbKQ.Name = "rtbKQ";
            this.rtbKQ.Size = new System.Drawing.Size(124, 172);
            this.rtbKQ.TabIndex = 3;
            this.rtbKQ.Text = "";
            // 
            // btnGet1Question
            // 
            this.btnGet1Question.Location = new System.Drawing.Point(533, 437);
            this.btnGet1Question.Name = "btnGet1Question";
            this.btnGet1Question.Size = new System.Drawing.Size(126, 40);
            this.btnGet1Question.TabIndex = 4;
            this.btnGet1Question.Text = "Get 1 Question";
            this.btnGet1Question.UseVisualStyleBackColor = true;
            this.btnGet1Question.Click += new System.EventHandler(this.BtnGet1Question_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(533, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(107, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(533, 172);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(124, 172);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TestBase64String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 511);
            this.Controls.Add(this.btnGet1Question);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtbKQ);
            this.Controls.Add(this.txbDuongDan);
            this.Controls.Add(this.btnGetFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TestBase64String";
            this.Text = "TestBase64String";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGetFile;
        private System.Windows.Forms.TextBox txbDuongDan;
        private System.Windows.Forms.RichTextBox rtbKQ;
        private System.Windows.Forms.Button btnGet1Question;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}