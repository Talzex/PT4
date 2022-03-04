
namespace Veto
{
    partial class UserBase
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBase));
            this.UserDescPNL = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UserRoleLBL = new System.Windows.Forms.Label();
            this.UserLNameLBL = new System.Windows.Forms.Label();
            this.UserFNameLBL = new System.Windows.Forms.Label();
            this.UserProfilePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            this.UserDescPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePB)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPNL
            // 
            this.TopPNL.Location = new System.Drawing.Point(0, 0);
            this.TopPNL.Size = new System.Drawing.Size(1269, 86);
            // 
            // SidePNL
            // 
            this.SidePNL.Location = new System.Drawing.Point(86, 0);
            this.SidePNL.Size = new System.Drawing.Size(150, 838);
            this.SidePNL.SplitterDistance = 419;
            // 
            // UserDescPNL
            // 
            this.UserDescPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(191)))));
            this.UserDescPNL.Controls.Add(this.label1);
            this.UserDescPNL.Controls.Add(this.UserRoleLBL);
            this.UserDescPNL.Controls.Add(this.UserLNameLBL);
            this.UserDescPNL.Controls.Add(this.UserFNameLBL);
            this.UserDescPNL.Controls.Add(this.UserProfilePB);
            this.UserDescPNL.Location = new System.Drawing.Point(373, 115);
            this.UserDescPNL.Name = "UserDescPNL";
            this.UserDescPNL.Size = new System.Drawing.Size(982, 673);
            this.UserDescPNL.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mot de Passe";
            // 
            // UserRoleLBL
            // 
            this.UserRoleLBL.AutoSize = true;
            this.UserRoleLBL.Location = new System.Drawing.Point(579, 110);
            this.UserRoleLBL.Name = "UserRoleLBL";
            this.UserRoleLBL.Size = new System.Drawing.Size(37, 17);
            this.UserRoleLBL.TabIndex = 4;
            this.UserRoleLBL.Text = "Rôle";
            // 
            // UserLNameLBL
            // 
            this.UserLNameLBL.AutoSize = true;
            this.UserLNameLBL.Location = new System.Drawing.Point(262, 160);
            this.UserLNameLBL.Name = "UserLNameLBL";
            this.UserLNameLBL.Size = new System.Drawing.Size(33, 17);
            this.UserLNameLBL.TabIndex = 2;
            this.UserLNameLBL.Text = "Mail";
            // 
            // UserFNameLBL
            // 
            this.UserFNameLBL.AutoSize = true;
            this.UserFNameLBL.Location = new System.Drawing.Point(262, 47);
            this.UserFNameLBL.Name = "UserFNameLBL";
            this.UserFNameLBL.Size = new System.Drawing.Size(43, 17);
            this.UserFNameLBL.TabIndex = 1;
            this.UserFNameLBL.Text = "Login";
            // 
            // UserProfilePB
            // 
            this.UserProfilePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserProfilePB.BackgroundImage")));
            this.UserProfilePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserProfilePB.InitialImage = ((System.Drawing.Image)(resources.GetObject("UserProfilePB.InitialImage")));
            this.UserProfilePB.Location = new System.Drawing.Point(62, 27);
            this.UserProfilePB.Name = "UserProfilePB";
            this.UserProfilePB.Size = new System.Drawing.Size(160, 160);
            this.UserProfilePB.TabIndex = 0;
            this.UserProfilePB.TabStop = false;
            // 
            // UserBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.UserDescPNL);
            this.Name = "UserBase";
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.UserDescPNL, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.UserDescPNL.ResumeLayout(false);
            this.UserDescPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserDescPNL;
        private System.Windows.Forms.PictureBox UserProfilePB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserRoleLBL;
        private System.Windows.Forms.Label UserLNameLBL;
        private System.Windows.Forms.Label UserFNameLBL;
    }
}
