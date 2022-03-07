
namespace Veto
{
    partial class ScreenBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenBase));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TopPNL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.TopPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ImageLocation = "";
            this.Logo.Location = new System.Drawing.Point(9, 6);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(60, 60);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // TopPNL
            // 
            this.TopPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(90)))), ((int)(((byte)(67)))));
            this.TopPNL.Controls.Add(this.Logo);
            this.TopPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPNL.Location = new System.Drawing.Point(0, 0);
            this.TopPNL.Name = "TopPNL";
            this.TopPNL.Size = new System.Drawing.Size(1419, 86);
            this.TopPNL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "srfe";
            // 
            // ScreenBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopPNL);
            this.Name = "ScreenBase";
            this.Text = "ScreenBase";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.TopPNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        protected System.Windows.Forms.Panel TopPNL;
        private System.Windows.Forms.Label label1;
    }
}