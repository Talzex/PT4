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
            this.SizeTB = new System.Windows.Forms.TextBox();
            this.SizeLBL = new System.Windows.Forms.Label();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.WeightLBL = new System.Windows.Forms.Label();
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
            this.BirthCAL.Location = new System.Drawing.Point(68, 274);
            this.BirthCAL.Name = "BirthCAL";
            this.BirthCAL.TabIndex = 6;
            // 
            // SizeTB
            // 
            this.SizeTB.Location = new System.Drawing.Point(249, 13);
            this.SizeTB.Name = "SizeTB";
            this.SizeTB.Size = new System.Drawing.Size(100, 20);
            this.SizeTB.TabIndex = 8;
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
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(249, 53);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(100, 20);
            this.WeightTB.TabIndex = 10;
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
            // AnimalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(397, 464);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.WeightLBL);
            this.Controls.Add(this.SizeTB);
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
        private System.Windows.Forms.TextBox SizeTB;
        private System.Windows.Forms.Label SizeLBL;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.Label WeightLBL;
    }
}