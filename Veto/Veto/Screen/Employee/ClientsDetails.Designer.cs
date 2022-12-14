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
            this.LastNameLBL = new System.Windows.Forms.Label();
            this.FirstNameLBL = new System.Windows.Forms.Label();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.PhoneLBL = new System.Windows.Forms.Label();
            this.AddAnimalBTN = new System.Windows.Forms.Button();
            this.ValidateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.NumberLBL = new System.Windows.Forms.Label();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.AnimalsPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.BirthCAL = new System.Windows.Forms.MonthCalendar();
            this.BirthLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastNameLBL
            // 
            this.LastNameLBL.AutoSize = true;
            this.LastNameLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLBL.Location = new System.Drawing.Point(62, 4);
            this.LastNameLBL.Name = "LastNameLBL";
            this.LastNameLBL.Size = new System.Drawing.Size(50, 21);
            this.LastNameLBL.TabIndex = 0;
            this.LastNameLBL.Text = "Nom:";
            // 
            // FirstNameLBL
            // 
            this.FirstNameLBL.AutoSize = true;
            this.FirstNameLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLBL.Location = new System.Drawing.Point(42, 50);
            this.FirstNameLBL.Name = "FirstNameLBL";
            this.FirstNameLBL.Size = new System.Drawing.Size(71, 21);
            this.FirstNameLBL.TabIndex = 1;
            this.FirstNameLBL.Text = "Prénom:";
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLBL.Location = new System.Drawing.Point(259, 50);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(52, 21);
            this.EmailLBL.TabIndex = 2;
            this.EmailLBL.Text = "Email:";
            // 
            // PhoneLBL
            // 
            this.PhoneLBL.AutoSize = true;
            this.PhoneLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLBL.Location = new System.Drawing.Point(224, 5);
            this.PhoneLBL.Name = "PhoneLBL";
            this.PhoneLBL.Size = new System.Drawing.Size(90, 21);
            this.PhoneLBL.TabIndex = 5;
            this.PhoneLBL.Text = "Téléphone:";
            // 
            // AddAnimalBTN
            // 
            this.AddAnimalBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddAnimalBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddAnimalBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAnimalBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddAnimalBTN.Location = new System.Drawing.Point(28, 566);
            this.AddAnimalBTN.Name = "AddAnimalBTN";
            this.AddAnimalBTN.Size = new System.Drawing.Size(128, 33);
            this.AddAnimalBTN.TabIndex = 6;
            this.AddAnimalBTN.Text = "AJOUTER ANIMAL";
            this.AddAnimalBTN.UseVisualStyleBackColor = false;
            this.AddAnimalBTN.Click += new System.EventHandler(this.AddAnimalBTN_Click);
            // 
            // ValidateBTN
            // 
            this.ValidateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ValidateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValidateBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ValidateBTN.Location = new System.Drawing.Point(570, 566);
            this.ValidateBTN.Name = "ValidateBTN";
            this.ValidateBTN.Size = new System.Drawing.Size(85, 33);
            this.ValidateBTN.TabIndex = 7;
            this.ValidateBTN.Text = "VALIDER";
            this.ValidateBTN.UseVisualStyleBackColor = false;
            this.ValidateBTN.Click += new System.EventHandler(this.ValidateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteBTN.Location = new System.Drawing.Point(669, 566);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(85, 33);
            this.DeleteBTN.TabIndex = 8;
            this.DeleteBTN.Text = "SUPPRIMER";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // NumberLBL
            // 
            this.NumberLBL.AutoSize = true;
            this.NumberLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLBL.Location = new System.Drawing.Point(24, 530);
            this.NumberLBL.Name = "NumberLBL";
            this.NumberLBL.Size = new System.Drawing.Size(71, 21);
            this.NumberLBL.TabIndex = 9;
            this.NumberLBL.Text = "Nombre:";
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(114, 10);
            this.LNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(76, 20);
            this.LNameTB.TabIndex = 11;
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(114, 54);
            this.FNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(76, 20);
            this.FNameTB.TabIndex = 12;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(313, 54);
            this.MailTB.Margin = new System.Windows.Forms.Padding(2);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(76, 20);
            this.MailTB.TabIndex = 13;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Location = new System.Drawing.Point(313, 9);
            this.PhoneTB.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(76, 20);
            this.PhoneTB.TabIndex = 14;
            this.PhoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB_KeyPress);
            // 
            // AnimalsPNL
            // 
            this.AnimalsPNL.Location = new System.Drawing.Point(46, 242);
            this.AnimalsPNL.Margin = new System.Windows.Forms.Padding(2);
            this.AnimalsPNL.Name = "AnimalsPNL";
            this.AnimalsPNL.Size = new System.Drawing.Size(726, 274);
            this.AnimalsPNL.TabIndex = 15;
            // 
            // BirthCAL
            // 
            this.BirthCAL.Location = new System.Drawing.Point(479, 50);
            this.BirthCAL.MaxSelectionCount = 1;
            this.BirthCAL.Name = "BirthCAL";
            this.BirthCAL.TabIndex = 16;
            // 
            // BirthLBL
            // 
            this.BirthLBL.AutoSize = true;
            this.BirthLBL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLBL.Location = new System.Drawing.Point(525, 20);
            this.BirthLBL.Name = "BirthLBL";
            this.BirthLBL.Size = new System.Drawing.Size(140, 21);
            this.BirthLBL.TabIndex = 17;
            this.BirthLBL.Text = "Date de naissance";
            // 
            // ClientsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.BirthLBL);
            this.Controls.Add(this.BirthCAL);
            this.Controls.Add(this.AnimalsPNL);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.MailTB);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.NumberLBL);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.ValidateBTN);
            this.Controls.Add(this.AddAnimalBTN);
            this.Controls.Add(this.PhoneLBL);
            this.Controls.Add(this.EmailLBL);
            this.Controls.Add(this.FirstNameLBL);
            this.Controls.Add(this.LastNameLBL);
            this.Name = "ClientsDetails";
            this.Text = "Détails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastNameLBL;
        private System.Windows.Forms.Label FirstNameLBL;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Label PhoneLBL;
        private System.Windows.Forms.Button AddAnimalBTN;
        private System.Windows.Forms.Button ValidateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Label NumberLBL;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.FlowLayoutPanel AnimalsPNL;
        private System.Windows.Forms.MonthCalendar BirthCAL;
        private System.Windows.Forms.Label BirthLBL;
    }
}