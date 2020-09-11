namespace IT
{
    partial class V_PointDetailTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.filter = new IT.Items.ucQAfilter();
            this.header = new IT.Items.ucQAheader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpItems);
            this.panel1.Controls.Add(this.filter);
            this.panel1.Controls.Add(this.header);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 531);
            this.panel1.TabIndex = 4;
            // 
            // flpItems
            // 
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpItems.Location = new System.Drawing.Point(0, 120);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(1363, 411);
            this.flpItems.TabIndex = 6;
            // 
            // filter
            // 
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Location = new System.Drawing.Point(0, 60);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(1363, 60);
            this.filter.TabIndex = 5;
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1363, 60);
            this.header.TabIndex = 4;
            // 
            // V_PointDetailTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 721);
            this.Controls.Add(this.panel1);
            this.Name = "V_PointDetailTest";
            this.Text = "V_PointDetail";
            this.Load += new System.EventHandler(this.V_PointDetailTest_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private Items.ucQAfilter filter;
        private Items.ucQAheader header;
    }
}