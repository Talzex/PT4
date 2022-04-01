
namespace Veto
{
    partial class ScreenConection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenConection));
            this.ConnexionPNL = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.IdLBL = new System.Windows.Forms.Label();
            this.ConnectBT = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.CoonexionLBL = new System.Windows.Forms.Label();
            this.ConnexionPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnexionPNL
            // 
            this.ConnexionPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(51)))), ((int)(((byte)(39)))));
            this.ConnexionPNL.Controls.Add(this.label2);
            this.ConnexionPNL.Controls.Add(this.IdLBL);
            this.ConnexionPNL.Controls.Add(this.ConnectBT);
            this.ConnexionPNL.Controls.Add(this.PasswordTB);
            this.ConnexionPNL.Controls.Add(this.LoginTB);
            this.ConnexionPNL.Controls.Add(this.CoonexionLBL);
            this.ConnexionPNL.Location = new System.Drawing.Point(88, 233);
            this.ConnexionPNL.Name = "ConnexionPNL";
            this.ConnexionPNL.Size = new System.Drawing.Size(383, 396);
            this.ConnexionPNL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(130, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de Passe";
            // 
            // IdLBL
            // 
            this.IdLBL.AutoSize = true;
            this.IdLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.IdLBL.Location = new System.Drawing.Point(130, 129);
            this.IdLBL.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IdLBL.Name = "IdLBL";
            this.IdLBL.Size = new System.Drawing.Size(80, 21);
            this.IdLBL.TabIndex = 4;
            this.IdLBL.Text = "Identifiant";
            // 
            // ConnectBT
            // 
            this.ConnectBT.BackColor = System.Drawing.Color.White;
            this.ConnectBT.FlatAppearance.BorderSize = 0;
            this.ConnectBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBT.ForeColor = System.Drawing.Color.Black;
            this.ConnectBT.Location = new System.Drawing.Point(134, 341);
            this.ConnectBT.Margin = new System.Windows.Forms.Padding(5);
            this.ConnectBT.Name = "ConnectBT";
            this.ConnectBT.Size = new System.Drawing.Size(96, 28);
            this.ConnectBT.TabIndex = 3;
            this.ConnectBT.Text = "Connexion";
            this.ConnectBT.UseVisualStyleBackColor = false;
            this.ConnectBT.Click += new System.EventHandler(this.ConnectBT_Click);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTB.Location = new System.Drawing.Point(134, 251);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(151, 22);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginTB
            // 
            this.LoginTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.LoginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTB.Location = new System.Drawing.Point(134, 155);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(5);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(115, 22);
            this.LoginTB.TabIndex = 1;
            this.LoginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CoonexionLBL
            // 
            this.CoonexionLBL.AutoSize = true;
            this.CoonexionLBL.BackColor = System.Drawing.Color.Transparent;
            this.CoonexionLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoonexionLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(224)))), ((int)(((byte)(204)))));
            this.CoonexionLBL.Location = new System.Drawing.Point(135, 29);
            this.CoonexionLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CoonexionLBL.Name = "CoonexionLBL";
            this.CoonexionLBL.Size = new System.Drawing.Size(112, 30);
            this.CoonexionLBL.TabIndex = 0;
            this.CoonexionLBL.Text = "Connexion";
            this.CoonexionLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScreenConection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.ConnexionPNL);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "ScreenConection";
            this.Activated += new System.EventHandler(this.ScreenConection_Activated);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.ConnexionPNL, 0);
            this.ConnexionPNL.ResumeLayout(false);
            this.ConnexionPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ConnexionPNL;
        private System.Windows.Forms.Button ConnectBT;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label CoonexionLBL;
        private System.Windows.Forms.Label IdLBL;
        private System.Windows.Forms.Label label2;
    }
}
