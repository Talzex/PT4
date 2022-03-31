namespace Veto
{
    partial class AnimalDetails
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
            this.NameLBL = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SpecieTB = new System.Windows.Forms.TextBox();
            this.SpecieLBL = new System.Windows.Forms.Label();
            this.RaceTB = new System.Windows.Forms.TextBox();
            this.RaceLBL = new System.Windows.Forms.Label();
            this.BirthCAL = new System.Windows.Forms.MonthCalendar();
            this.SizeLBL = new System.Windows.Forms.Label();
            this.WeightLBL = new System.Windows.Forms.Label();
            this.BirthLBL = new System.Windows.Forms.Label();
            this.DiseasesLB = new System.Windows.Forms.ListBox();
            this.DiseasesLBL = new System.Windows.Forms.Label();
            this.AddDiseasesBTN = new System.Windows.Forms.Button();
            this.RmDiseaseBTN = new System.Windows.Forms.Button();
            this.HeightNUM = new System.Windows.Forms.NumericUpDown();
            this.WeightNUM = new System.Windows.Forms.NumericUpDown();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Location = new System.Drawing.Point(13, 13);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(29, 13);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Nom";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(68, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 1;
            // 
            // SpecieTB
            // 
            this.SpecieTB.Location = new System.Drawing.Point(68, 53);
            this.SpecieTB.Name = "SpecieTB";
            this.SpecieTB.Size = new System.Drawing.Size(100, 20);
            this.SpecieTB.TabIndex = 3;
            // 
            // SpecieLBL
            // 
            this.SpecieLBL.AutoSize = true;
            this.SpecieLBL.Location = new System.Drawing.Point(13, 53);
            this.SpecieLBL.Name = "SpecieLBL";
            this.SpecieLBL.Size = new System.Drawing.Size(43, 13);
            this.SpecieLBL.TabIndex = 2;
            this.SpecieLBL.Text = "Espèce";
            // 
            // RaceTB
            // 
            this.RaceTB.Location = new System.Drawing.Point(68, 95);
            this.RaceTB.Name = "RaceTB";
            this.RaceTB.Size = new System.Drawing.Size(100, 20);
            this.RaceTB.TabIndex = 5;
            // 
            // RaceLBL
            // 
            this.RaceLBL.AutoSize = true;
            this.RaceLBL.Location = new System.Drawing.Point(13, 95);
            this.RaceLBL.Name = "RaceLBL";
            this.RaceLBL.Size = new System.Drawing.Size(33, 13);
            this.RaceLBL.TabIndex = 4;
            this.RaceLBL.Text = "Race";
            // 
            // BirthCAL
            // 
            this.BirthCAL.Location = new System.Drawing.Point(68, 127);
            this.BirthCAL.MaxSelectionCount = 1;
            this.BirthCAL.Name = "BirthCAL";
            this.BirthCAL.TabIndex = 6;
            // 
            // SizeLBL
            // 
            this.SizeLBL.AutoSize = true;
            this.SizeLBL.Location = new System.Drawing.Point(194, 13);
            this.SizeLBL.Name = "SizeLBL";
            this.SizeLBL.Size = new System.Drawing.Size(32, 13);
            this.SizeLBL.TabIndex = 7;
            this.SizeLBL.Text = "Taille";
            // 
            // WeightLBL
            // 
            this.WeightLBL.AutoSize = true;
            this.WeightLBL.Location = new System.Drawing.Point(194, 53);
            this.WeightLBL.Name = "WeightLBL";
            this.WeightLBL.Size = new System.Drawing.Size(33, 13);
            this.WeightLBL.TabIndex = 9;
            this.WeightLBL.Text = "Poids";
            // 
            // BirthLBL
            // 
            this.BirthLBL.AutoSize = true;
            this.BirthLBL.Location = new System.Drawing.Point(13, 127);
            this.BirthLBL.Name = "BirthLBL";
            this.BirthLBL.Size = new System.Drawing.Size(55, 26);
            this.BirthLBL.TabIndex = 11;
            this.BirthLBL.Text = "Date de \r\nnaissance";
            // 
            // DiseasesLB
            // 
            this.DiseasesLB.FormattingEnabled = true;
            this.DiseasesLB.Location = new System.Drawing.Point(434, 53);
            this.DiseasesLB.Name = "DiseasesLB";
            this.DiseasesLB.Size = new System.Drawing.Size(277, 95);
            this.DiseasesLB.TabIndex = 12;
            // 
            // DiseasesLBL
            // 
            this.DiseasesLBL.AutoSize = true;
            this.DiseasesLBL.Location = new System.Drawing.Point(431, 13);
            this.DiseasesLBL.Name = "DiseasesLBL";
            this.DiseasesLBL.Size = new System.Drawing.Size(49, 13);
            this.DiseasesLBL.TabIndex = 13;
            this.DiseasesLBL.Text = "Maladies";
            // 
            // AddDiseasesBTN
            // 
            this.AddDiseasesBTN.Location = new System.Drawing.Point(434, 155);
            this.AddDiseasesBTN.Name = "AddDiseasesBTN";
            this.AddDiseasesBTN.Size = new System.Drawing.Size(75, 23);
            this.AddDiseasesBTN.TabIndex = 14;
            this.AddDiseasesBTN.Text = "Ajouter Maladie";
            this.AddDiseasesBTN.UseVisualStyleBackColor = true;
            this.AddDiseasesBTN.Click += new System.EventHandler(this.AddDiseasesBTN_Click);
            // 
            // RmDiseaseBTN
            // 
            this.RmDiseaseBTN.Location = new System.Drawing.Point(636, 154);
            this.RmDiseaseBTN.Name = "RmDiseaseBTN";
            this.RmDiseaseBTN.Size = new System.Drawing.Size(75, 23);
            this.RmDiseaseBTN.TabIndex = 15;
            this.RmDiseaseBTN.Text = "Enlever  Maladie";
            this.RmDiseaseBTN.UseVisualStyleBackColor = true;
            this.RmDiseaseBTN.Click += new System.EventHandler(this.RmDiseaseBTN_Click);
            // 
            // HeightNUM
            // 
            this.HeightNUM.Location = new System.Drawing.Point(249, 11);
            this.HeightNUM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.HeightNUM.Name = "HeightNUM";
            this.HeightNUM.Size = new System.Drawing.Size(71, 20);
            this.HeightNUM.TabIndex = 16;
            // 
            // WeightNUM
            // 
            this.WeightNUM.Location = new System.Drawing.Point(249, 54);
            this.WeightNUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WeightNUM.Name = "WeightNUM";
            this.WeightNUM.Size = new System.Drawing.Size(71, 20);
            this.WeightNUM.TabIndex = 17;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(434, 259);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(84, 23);
            this.SaveBTN.TabIndex = 18;
            this.SaveBTN.Text = "Sauvegarder";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(539, 259);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 19;
            this.DeleteBTN.Text = "Supprimer";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.Location = new System.Drawing.Point(636, 259);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(77, 23);
            this.CancelBTN.TabIndex = 20;
            this.CancelBTN.Text = "Annuler";
            this.CancelBTN.UseVisualStyleBackColor = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // AnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(723, 294);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.WeightNUM);
            this.Controls.Add(this.HeightNUM);
            this.Controls.Add(this.RmDiseaseBTN);
            this.Controls.Add(this.AddDiseasesBTN);
            this.Controls.Add(this.DiseasesLBL);
            this.Controls.Add(this.DiseasesLB);
            this.Controls.Add(this.BirthLBL);
            this.Controls.Add(this.WeightLBL);
            this.Controls.Add(this.SizeLBL);
            this.Controls.Add(this.BirthCAL);
            this.Controls.Add(this.RaceTB);
            this.Controls.Add(this.RaceLBL);
            this.Controls.Add(this.SpecieTB);
            this.Controls.Add(this.SpecieLBL);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NameLBL);
            this.Name = "AnimalDetails";
            this.Text = "AnimalDetails";
            ((System.ComponentModel.ISupportInitialize)(this.HeightNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SpecieTB;
        private System.Windows.Forms.Label SpecieLBL;
        private System.Windows.Forms.TextBox RaceTB;
        private System.Windows.Forms.Label RaceLBL;
        private System.Windows.Forms.MonthCalendar BirthCAL;
        private System.Windows.Forms.Label SizeLBL;
        private System.Windows.Forms.Label WeightLBL;
        private System.Windows.Forms.Label BirthLBL;
        private System.Windows.Forms.ListBox DiseasesLB;
        private System.Windows.Forms.Label DiseasesLBL;
        private System.Windows.Forms.Button AddDiseasesBTN;
        private System.Windows.Forms.Button RmDiseaseBTN;
        private System.Windows.Forms.NumericUpDown HeightNUM;
        private System.Windows.Forms.NumericUpDown WeightNUM;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button CancelBTN;
    }
}