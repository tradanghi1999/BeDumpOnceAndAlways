namespace Test.Show_App
{
    partial class View
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
            this.OpenNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenNew
            // 
            this.OpenNew.Location = new System.Drawing.Point(353, 158);
            this.OpenNew.Name = "OpenNew";
            this.OpenNew.Size = new System.Drawing.Size(119, 51);
            this.OpenNew.TabIndex = 0;
            this.OpenNew.Text = "OpenNew";
            this.OpenNew.UseVisualStyleBackColor = true;
            this.OpenNew.Click += new System.EventHandler(this.OpenNew_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenNew);
            this.Name = "View";
            this.Text = "View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenNew;
    }
}