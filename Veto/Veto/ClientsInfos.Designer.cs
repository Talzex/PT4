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
            // ClientsInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(911, 503);
            this.Controls.Add(this.IconPB);
            this.Name = "ClientsInfos";
            this.Text = "ClientsInfos";
            ((System.ComponentModel.ISupportInitialize)(this.IconPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPB;
    }
}