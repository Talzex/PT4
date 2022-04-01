
namespace Veto
{
    partial class UserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetails));
            this.UserDescPNL = new System.Windows.Forms.Panel();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.RoleCB = new System.Windows.Forms.ComboBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.UserRoleLBL = new System.Windows.Forms.Label();
            this.UserLNameLBL = new System.Windows.Forms.Label();
            this.UserFNameLBL = new System.Windows.Forms.Label();
            this.UserProfilePB = new System.Windows.Forms.PictureBox();
            this.UserDescPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePB)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDescPNL
            // 
            this.UserDescPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(191)))));
            this.UserDescPNL.Controls.Add(this.PasswordTB);
            this.UserDescPNL.Controls.Add(this.PasswordLBL);
            this.UserDescPNL.Controls.Add(this.RoleCB);
            this.UserDescPNL.Controls.Add(this.MailTB);
            this.UserDescPNL.Controls.Add(this.LoginTB);
            this.UserDescPNL.Controls.Add(this.CancelBTN);
            this.UserDescPNL.Controls.Add(this.DeleteBTN);
            this.UserDescPNL.Controls.Add(this.SaveBTN);
            this.UserDescPNL.Controls.Add(this.UserRoleLBL);
            this.UserDescPNL.Controls.Add(this.UserLNameLBL);
            this.UserDescPNL.Controls.Add(this.UserFNameLBL);
            this.UserDescPNL.Controls.Add(this.UserProfilePB);
            this.UserDescPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDescPNL.Location = new System.Drawing.Point(0, 0);
            this.UserDescPNL.Margin = new System.Windows.Forms.Padding(2);
            this.UserDescPNL.Name = "UserDescPNL";
            this.UserDescPNL.Size = new System.Drawing.Size(600, 201);
            this.UserDescPNL.TabIndex = 7;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(455, 13);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(100, 20);
            this.PasswordTB.TabIndex = 13;
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.Location = new System.Drawing.Point(378, 16);
            this.PasswordLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(75, 13);
            this.PasswordLBL.TabIndex = 12;
            this.PasswordLBL.Text = "Mot de Passe";
            // 
            // RoleCB
            // 
            this.RoleCB.FormattingEnabled = true;
            this.RoleCB.Location = new System.Drawing.Point(205, 127);
            this.RoleCB.Name = "RoleCB";
            this.RoleCB.Size = new System.Drawing.Size(100, 21);
            this.RoleCB.TabIndex = 11;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(205, 70);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(100, 20);
            this.MailTB.TabIndex = 9;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(205, 10);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 20);
            this.LoginTB.TabIndex = 8;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.CancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.Location = new System.Drawing.Point(513, 166);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(75, 23);
            this.CancelBTN.TabIndex = 7;
            this.CancelBTN.Text = "ANNULER";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.Location = new System.Drawing.Point(158, 166);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 6;
            this.DeleteBTN.Text = "SUPPRIMER";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // SaveBTN
            // 
            this.SaveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.SaveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.ForeColor = System.Drawing.Color.White;
            this.SaveBTN.Location = new System.Drawing.Point(55, 166);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(97, 23);
            this.SaveBTN.TabIndex = 5;
            this.SaveBTN.Text = "SAUVEGARDER";
            this.SaveBTN.UseVisualStyleBackColor = false;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // UserRoleLBL
            // 
            this.UserRoleLBL.AutoSize = true;
            this.UserRoleLBL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLBL.Location = new System.Drawing.Point(145, 130);
            this.UserRoleLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserRoleLBL.Name = "UserRoleLBL";
            this.UserRoleLBL.Size = new System.Drawing.Size(30, 13);
            this.UserRoleLBL.TabIndex = 4;
            this.UserRoleLBL.Text = "Rôle";
            // 
            // UserLNameLBL
            // 
            this.UserLNameLBL.AutoSize = true;
            this.UserLNameLBL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLNameLBL.Location = new System.Drawing.Point(145, 73);
            this.UserLNameLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLNameLBL.Name = "UserLNameLBL";
            this.UserLNameLBL.Size = new System.Drawing.Size(29, 13);
            this.UserLNameLBL.TabIndex = 2;
            this.UserLNameLBL.Text = "Mail";
            // 
            // UserFNameLBL
            // 
            this.UserFNameLBL.AutoSize = true;
            this.UserFNameLBL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFNameLBL.Location = new System.Drawing.Point(145, 13);
            this.UserFNameLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserFNameLBL.Name = "UserFNameLBL";
            this.UserFNameLBL.Size = new System.Drawing.Size(36, 13);
            this.UserFNameLBL.TabIndex = 1;
            this.UserFNameLBL.Text = "Login";
            // 
            // UserProfilePB
            // 
            this.UserProfilePB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserProfilePB.BackgroundImage")));
            this.UserProfilePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserProfilePB.InitialImage = ((System.Drawing.Image)(resources.GetObject("UserProfilePB.InitialImage")));
            this.UserProfilePB.Location = new System.Drawing.Point(11, 13);
            this.UserProfilePB.Margin = new System.Windows.Forms.Padding(2);
            this.UserProfilePB.Name = "UserProfilePB";
            this.UserProfilePB.Size = new System.Drawing.Size(120, 130);
            this.UserProfilePB.TabIndex = 0;
            this.UserProfilePB.TabStop = false;
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(600, 201);
            this.Controls.Add(this.UserDescPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.UserDescPNL.ResumeLayout(false);
            this.UserDescPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UserDescPNL;
        private System.Windows.Forms.Label UserRoleLBL;
        private System.Windows.Forms.Label UserLNameLBL;
        private System.Windows.Forms.Label UserFNameLBL;
        private System.Windows.Forms.PictureBox UserProfilePB;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.ComboBox RoleCB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordLBL;
    }
}