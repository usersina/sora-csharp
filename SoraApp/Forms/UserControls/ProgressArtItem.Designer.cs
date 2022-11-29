namespace SoraApp.Forms.UserControls
{
    partial class ProgressArtItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressArtItem));
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.CoverPb = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LastSeenAtLbl = new System.Windows.Forms.Label();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPb)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.ContainerPanel.Controls.Add(this.CoverPb);
            this.ContainerPanel.Controls.Add(this.panel5);
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(339, 180);
            this.ContainerPanel.TabIndex = 4;
            // 
            // CoverPb
            // 
            this.CoverPb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CoverPb.BackgroundImage")));
            this.CoverPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPb.Location = new System.Drawing.Point(33, 0);
            this.CoverPb.Name = "CoverPb";
            this.CoverPb.Size = new System.Drawing.Size(111, 158);
            this.CoverPb.TabIndex = 0;
            this.CoverPb.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.LastSeenAtLbl);
            this.panel5.Controls.Add(this.ProgressLbl);
            this.panel5.Controls.Add(this.TitleLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(339, 125);
            this.panel5.TabIndex = 1;
            // 
            // LastSeenAtLbl
            // 
            this.LastSeenAtLbl.AutoSize = true;
            this.LastSeenAtLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastSeenAtLbl.Location = new System.Drawing.Point(173, 75);
            this.LastSeenAtLbl.Name = "LastSeenAtLbl";
            this.LastSeenAtLbl.Size = new System.Drawing.Size(95, 15);
            this.LastSeenAtLbl.TabIndex = 2;
            this.LastSeenAtLbl.Text = "Read a week ago";
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProgressLbl.Location = new System.Drawing.Point(173, 56);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(105, 17);
            this.ProgressLbl.TabIndex = 1;
            this.ProgressLbl.Text = "Page 190 of 350";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(171, 17);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(129, 32);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Book Title";
            // 
            // ProgressArtItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContainerPanel);
            this.Name = "ProgressArtItem";
            this.Size = new System.Drawing.Size(339, 180);
            this.ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoverPb)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ContainerPanel;
        private PictureBox CoverPb;
        private Panel panel5;
        private Label LastSeenAtLbl;
        private Label ProgressLbl;
        private Label TitleLbl;
    }
}
