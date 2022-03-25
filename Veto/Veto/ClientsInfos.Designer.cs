namespace Veto
{
    partial class ClientsInfos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsInfos));
            this.IconPB = new System.Windows.Forms.PictureBox();
            this.FNameLBL = new System.Windows.Forms.Label();
            this.LNameLBL = new System.Windows.Forms.Label();
            this.MailLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // IconPB
            // 
            this.IconPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPB.BackgroundImage")));
            this.IconPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPB.Location = new System.Drawing.Point(13, 13);
            this.IconPB.Name = "IconPB";
            this.IconPB.Size = new System.Drawing.Size(100, 100);
            this.IconPB.TabIndex = 0;
            this.IconPB.TabStop = false;
            // 
            // FNameLBL
            // 
            this.FNameLBL.AutoSize = true;
            this.FNameLBL.Location = new System.Drawing.Point(119, 55);
            this.FNameLBL.Name = "FNameLBL";
            this.FNameLBL.Size = new System.Drawing.Size(43, 13);
            this.FNameLBL.TabIndex = 1;
            this.FNameLBL.Text = "Prénom";
            // 
            // LNameLBL
            // 
            this.LNameLBL.AutoSize = true;
            this.LNameLBL.Location = new System.Drawing.Point(119, 13);
            this.LNameLBL.Name = "LNameLBL";
            this.LNameLBL.Size = new System.Drawing.Size(29, 13);
            this.LNameLBL.TabIndex = 2;
            this.LNameLBL.Text = "Nom";
            // 
            // MailLBL
            // 
            this.MailLBL.AutoSize = true;
            this.MailLBL.Location = new System.Drawing.Point(119, 100);
            this.MailLBL.Name = "MailLBL";
            this.MailLBL.Size = new System.Drawing.Size(32, 13);
            this.MailLBL.TabIndex = 3;
            this.MailLBL.Text = "Email";
            // 
            // ClientsInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(911, 503);
            this.Controls.Add(this.MailLBL);
            this.Controls.Add(this.LNameLBL);
            this.Controls.Add(this.FNameLBL);
            this.Controls.Add(this.IconPB);
            this.Name = "ClientsInfos";
            this.Text = "ClientsInfos";
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPB;
        private System.Windows.Forms.Label FNameLBL;
        private System.Windows.Forms.Label LNameLBL;
        private System.Windows.Forms.Label MailLBL;
    }
}