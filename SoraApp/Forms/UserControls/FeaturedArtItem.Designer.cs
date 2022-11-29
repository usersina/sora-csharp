namespace SoraApp.Forms.UserControls
{
    partial class FeaturedArtItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeaturedArtItem));
            this.panel6 = new System.Windows.Forms.Panel();
            this.CoverPb = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.GenreLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverPb)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.CoverPb);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(339, 237);
            this.panel6.TabIndex = 7;
            // 
            // CoverPb
            // 
            this.CoverPb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CoverPb.BackgroundImage")));
            this.CoverPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CoverPb.Location = new System.Drawing.Point(115, 0);
            this.CoverPb.Name = "CoverPb";
            this.CoverPb.Size = new System.Drawing.Size(111, 158);
            this.CoverPb.TabIndex = 0;
            this.CoverPb.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.GenreLbl);
            this.panel7.Controls.Add(this.AuthorLbl);
            this.panel7.Controls.Add(this.TitleLbl);
            this.panel7.Location = new System.Drawing.Point(0, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(339, 125);
            this.panel7.TabIndex = 1;
            // 
            // GenreLbl
            // 
            this.GenreLbl.AutoSize = true;
            this.GenreLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GenreLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreLbl.Location = new System.Drawing.Point(146, 105);
            this.GenreLbl.Name = "GenreLbl";
            this.GenreLbl.Size = new System.Drawing.Size(47, 15);
            this.GenreLbl.TabIndex = 2;
            this.GenreLbl.Text = "Fantasy";
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorLbl.Location = new System.Drawing.Point(101, 79);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(136, 21);
            this.AuthorLbl.TabIndex = 1;
            this.AuthorLbl.Text = "Jonathan Smake";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLbl.Location = new System.Drawing.Point(38, 49);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(263, 30);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Time Travel for Dummies";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FeaturedArtItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Name = "FeaturedArtItem";
            this.Size = new System.Drawing.Size(339, 237);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoverPb)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel6;
        private PictureBox CoverPb;
        private Panel panel7;
        private Label GenreLbl;
        private Label AuthorLbl;
        private Label TitleLbl;
    }
}
