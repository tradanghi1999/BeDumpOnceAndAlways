namespace IT.Items
{
    partial class ucCheckConnection
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
            this.components = new System.ComponentModel.Container();
            this.picConnect = new System.Windows.Forms.PictureBox();
            this.lblNumberOfDevice = new System.Windows.Forms.Label();
            this.tul = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picConnect)).BeginInit();
            this.SuspendLayout();
            // 
            // picConnect
            // 
            this.picConnect.Image = global::IT.Properties.Resources.wifiProblem;
            this.picConnect.Location = new System.Drawing.Point(3, 3);
            this.picConnect.Name = "picConnect";
            this.picConnect.Size = new System.Drawing.Size(83, 51);
            this.picConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picConnect.TabIndex = 0;
            this.picConnect.TabStop = false;
            this.tul.SetToolTip(this.picConnect, "Click To Get Full List");
            // 
            // lblNumberOfDevice
            // 
            this.lblNumberOfDevice.AutoSize = true;
            this.lblNumberOfDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDevice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNumberOfDevice.Location = new System.Drawing.Point(56, 28);
            this.lblNumberOfDevice.Name = "lblNumberOfDevice";
            this.lblNumberOfDevice.Size = new System.Drawing.Size(27, 25);
            this.lblNumberOfDevice.TabIndex = 1;
            this.lblNumberOfDevice.Text = "X";
            this.tul.SetToolTip(this.lblNumberOfDevice, "Click To Get Full List");
            // 
            // ucCheckConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumberOfDevice);
            this.Controls.Add(this.picConnect);
            this.Name = "ucCheckConnection";
            this.Size = new System.Drawing.Size(91, 59);
            this.tul.SetToolTip(this, "Click To Get Full List");
            this.Load += new System.EventHandler(this.UcCheckConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picConnect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picConnect;
        private System.Windows.Forms.Label lblNumberOfDevice;
        private System.Windows.Forms.ToolTip tul;
    }
}
