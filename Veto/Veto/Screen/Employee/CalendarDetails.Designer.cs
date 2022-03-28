namespace Veto
{
    partial class CalendarDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBT = new System.Windows.Forms.Button();
            this.ValidateBT = new System.Windows.Forms.Button();
            this.ClientsList = new System.Windows.Forms.ListBox();
            this.AnimalsList = new System.Windows.Forms.ListBox();
            this.ClientLB = new System.Windows.Forms.Label();
            this.AnimalLB = new System.Windows.Forms.Label();
            this.BeginHourLB = new System.Windows.Forms.Label();
            this.BeginHour = new System.Windows.Forms.NumericUpDown();
            this.EndHourLB = new System.Windows.Forms.Label();
            this.EndHour = new System.Windows.Forms.NumericUpDown();
            this.Date = new System.Windows.Forms.MonthCalendar();
            this.ReasonLB = new System.Windows.Forms.Label();
            this.ReasonTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BeginHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendez-vous";
            // 
            // CancelBT
            // 
            this.CancelBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CancelBT.Location = new System.Drawing.Point(177, 613);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 30);
            this.CancelBT.TabIndex = 10;
            this.CancelBT.Text = "Annuler";
            this.CancelBT.UseVisualStyleBackColor = false;
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // ValidateBT
            // 
            this.ValidateBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ValidateBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValidateBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBT.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ValidateBT.Location = new System.Drawing.Point(40, 613);
            this.ValidateBT.Name = "ValidateBT";
            this.ValidateBT.Size = new System.Drawing.Size(75, 30);
            this.ValidateBT.TabIndex = 11;
            this.ValidateBT.Text = "Valider";
            this.ValidateBT.UseVisualStyleBackColor = false;
            this.ValidateBT.Click += new System.EventHandler(this.ValidateBT_Click);
            // 
            // ClientsList
            // 
            this.ClientsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsList.FormattingEnabled = true;
            this.ClientsList.Location = new System.Drawing.Point(47, 53);
            this.ClientsList.Name = "ClientsList";
            this.ClientsList.Size = new System.Drawing.Size(221, 95);
            this.ClientsList.TabIndex = 12;
            // 
            // AnimalsList
            // 
            this.AnimalsList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalsList.FormattingEnabled = true;
            this.AnimalsList.Location = new System.Drawing.Point(47, 183);
            this.AnimalsList.Name = "AnimalsList";
            this.AnimalsList.Size = new System.Drawing.Size(221, 69);
            this.AnimalsList.TabIndex = 13;
            // 
            // ClientLB
            // 
            this.ClientLB.AutoSize = true;
            this.ClientLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLB.Location = new System.Drawing.Point(44, 37);
            this.ClientLB.Name = "ClientLB";
            this.ClientLB.Size = new System.Drawing.Size(37, 13);
            this.ClientLB.TabIndex = 14;
            this.ClientLB.Text = "Client";
            // 
            // AnimalLB
            // 
            this.AnimalLB.AutoSize = true;
            this.AnimalLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalLB.Location = new System.Drawing.Point(44, 167);
            this.AnimalLB.Name = "AnimalLB";
            this.AnimalLB.Size = new System.Drawing.Size(42, 13);
            this.AnimalLB.TabIndex = 15;
            this.AnimalLB.Text = "Animal";
            // 
            // BeginHourLB
            // 
            this.BeginHourLB.AutoSize = true;
            this.BeginHourLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginHourLB.Location = new System.Drawing.Point(44, 275);
            this.BeginHourLB.Name = "BeginHourLB";
            this.BeginHourLB.Size = new System.Drawing.Size(88, 13);
            this.BeginHourLB.TabIndex = 16;
            this.BeginHourLB.Text = "Heure de début";
            // 
            // BeginHour
            // 
            this.BeginHour.Location = new System.Drawing.Point(138, 273);
            this.BeginHour.Name = "BeginHour";
            this.BeginHour.Size = new System.Drawing.Size(47, 20);
            this.BeginHour.TabIndex = 17;
            // 
            // EndHourLB
            // 
            this.EndHourLB.AutoSize = true;
            this.EndHourLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndHourLB.Location = new System.Drawing.Point(44, 310);
            this.EndHourLB.Name = "EndHourLB";
            this.EndHourLB.Size = new System.Drawing.Size(71, 13);
            this.EndHourLB.TabIndex = 18;
            this.EndHourLB.Text = "Heure de fin";
            // 
            // EndHour
            // 
            this.EndHour.Location = new System.Drawing.Point(138, 308);
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(47, 20);
            this.EndHour.TabIndex = 19;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(40, 439);
            this.Date.MaxSelectionCount = 1;
            this.Date.Name = "Date";
            this.Date.TabIndex = 20;
            // 
            // ReasonLB
            // 
            this.ReasonLB.AutoSize = true;
            this.ReasonLB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonLB.Location = new System.Drawing.Point(44, 354);
            this.ReasonLB.Name = "ReasonLB";
            this.ReasonLB.Size = new System.Drawing.Size(35, 13);
            this.ReasonLB.TabIndex = 21;
            this.ReasonLB.Text = "Motif";
            // 
            // ReasonTB
            // 
            this.ReasonTB.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReasonTB.Location = new System.Drawing.Point(47, 371);
            this.ReasonTB.Name = "ReasonTB";
            this.ReasonTB.Size = new System.Drawing.Size(221, 22);
            this.ReasonTB.TabIndex = 22;
            // 
            // CalendarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(314, 655);
            this.Controls.Add(this.ReasonTB);
            this.Controls.Add(this.ReasonLB);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.EndHour);
            this.Controls.Add(this.EndHourLB);
            this.Controls.Add(this.BeginHour);
            this.Controls.Add(this.BeginHourLB);
            this.Controls.Add(this.AnimalLB);
            this.Controls.Add(this.ClientLB);
            this.Controls.Add(this.AnimalsList);
            this.Controls.Add(this.ClientsList);
            this.Controls.Add(this.ValidateBT);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.label1);
            this.Name = "CalendarDetails";
            this.Text = "Ajout";
            ((System.ComponentModel.ISupportInitialize)(this.BeginHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button ValidateBT;
        private System.Windows.Forms.ListBox ClientsList;
        private System.Windows.Forms.ListBox AnimalsList;
        private System.Windows.Forms.Label ClientLB;
        private System.Windows.Forms.Label AnimalLB;
        private System.Windows.Forms.Label BeginHourLB;
        private System.Windows.Forms.NumericUpDown BeginHour;
        private System.Windows.Forms.Label EndHourLB;
        private System.Windows.Forms.NumericUpDown EndHour;
        private System.Windows.Forms.MonthCalendar Date;
        private System.Windows.Forms.Label ReasonLB;
        private System.Windows.Forms.TextBox ReasonTB;
    }
}