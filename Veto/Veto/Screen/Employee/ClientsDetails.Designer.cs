namespace Veto
{
    partial class ClientsDetails
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
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.AddAnimalBTN = new System.Windows.Forms.Button();
            this.ValidateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.NumberLBL = new System.Windows.Forms.Label();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.AnimalsPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(83, 5);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(62, 28);
            this.LastNameLabel.TabIndex = 0;
            this.LastNameLabel.Text = "Nom:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(56, 61);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(89, 28);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "Prénom:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(345, 61);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(65, 28);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneLabel.Location = new System.Drawing.Point(298, 6);
            this.TelephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(112, 28);
            this.TelephoneLabel.TabIndex = 5;
            this.TelephoneLabel.Text = "Téléphone:";
            // 
            // AddAnimalBTN
            // 
            this.AddAnimalBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddAnimalBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAnimalBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnimalBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddAnimalBTN.Location = new System.Drawing.Point(35, 498);
            this.AddAnimalBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddAnimalBTN.Name = "AddAnimalBTN";
            this.AddAnimalBTN.Size = new System.Drawing.Size(148, 41);
            this.AddAnimalBTN.TabIndex = 6;
            this.AddAnimalBTN.Text = "Ajouter animal";
            this.AddAnimalBTN.UseVisualStyleBackColor = false;
            this.AddAnimalBTN.Click += new System.EventHandler(this.AddAnimalBTN_Click);
            // 
            // ValidateBTN
            // 
            this.ValidateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ValidateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValidateBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ValidateBTN.Location = new System.Drawing.Point(757, 498);
            this.ValidateBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValidateBTN.Name = "ValidateBTN";
            this.ValidateBTN.Size = new System.Drawing.Size(113, 41);
            this.ValidateBTN.TabIndex = 7;
            this.ValidateBTN.Text = "Valider";
            this.ValidateBTN.UseVisualStyleBackColor = false;
            this.ValidateBTN.Click += new System.EventHandler(this.ValidateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBTN.Location = new System.Drawing.Point(889, 498);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(113, 41);
            this.DeleteBTN.TabIndex = 8;
            this.DeleteBTN.Text = "Supprimer";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // NumberLBL
            // 
            this.NumberLBL.AutoSize = true;
            this.NumberLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLBL.Location = new System.Drawing.Point(29, 454);
            this.NumberLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberLBL.Name = "NumberLBL";
            this.NumberLBL.Size = new System.Drawing.Size(89, 28);
            this.NumberLBL.TabIndex = 9;
            this.NumberLBL.Text = "Nombre:";
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(152, 12);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(100, 22);
            this.LNameTB.TabIndex = 11;
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(152, 67);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(100, 22);
            this.FNameTB.TabIndex = 12;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(417, 67);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(100, 22);
            this.MailTB.TabIndex = 13;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(417, 11);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(100, 22);
            this.PhoneTB.TabIndex = 14;
            // 
            // AnimalsPNL
            // 
            this.AnimalsPNL.Location = new System.Drawing.Point(34, 114);
            this.AnimalsPNL.Name = "AnimalsPNL";
            this.AnimalsPNL.Size = new System.Drawing.Size(968, 337);
            this.AnimalsPNL.TabIndex = 15;
            // 
            // ClientsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AnimalsPNL);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.NumberLBL);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.ValidateBTN);
            this.Controls.Add(this.AddAnimalBTN);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientsDetails";
            this.Text = "Détails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Button AddAnimalBTN;
        private System.Windows.Forms.Button ValidateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label NumberLBL;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.FlowLayoutPanel AnimalsPNL;
    }
}