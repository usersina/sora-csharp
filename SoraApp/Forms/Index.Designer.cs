namespace SoraApp
{
    partial class Index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectBtn = new System.Windows.Forms.Button();
            this.placeHolderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectBtn.Location = new System.Drawing.Point(269, 198);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(243, 82);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect to DB";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // placeHolderLabel
            // 
            this.placeHolderLabel.AutoSize = true;
            this.placeHolderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeHolderLabel.Location = new System.Drawing.Point(295, 150);
            this.placeHolderLabel.Name = "placeHolderLabel";
            this.placeHolderLabel.Size = new System.Drawing.Size(186, 45);
            this.placeHolderLabel.TabIndex = 1;
            this.placeHolderLabel.Text = "Placeholder";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.placeHolderLabel);
            this.Controls.Add(this.connectBtn);
            this.Name = "Index";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button connectBtn;
        private Label placeHolderLabel;
    }
}