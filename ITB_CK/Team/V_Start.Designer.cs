namespace Team
{
    partial class V_Start
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
            this.tmr3dot = new System.Windows.Forms.Timer(this.components);
            this.lbl3dot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tmr3dot
            // 
            this.tmr3dot.Tick += new System.EventHandler(this.Tmr3dot_Tick);
            // 
            // lbl3dot
            // 
            this.lbl3dot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3dot.AutoSize = true;
            this.lbl3dot.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3dot.Location = new System.Drawing.Point(590, 281);
            this.lbl3dot.Name = "lbl3dot";
            this.lbl3dot.Size = new System.Drawing.Size(169, 159);
            this.lbl3dot.TabIndex = 1;
            this.lbl3dot.Text = "...";
            this.lbl3dot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // V_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.lbl3dot);
            this.Name = "V_Start";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.V_Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer tmr3dot;
        private System.Windows.Forms.Label lbl3dot;
    }
}

