
namespace Veto
{
    partial class Calendar
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
            this.NextBTN = new Veto.ButtonEllipse();
            this.PrevBTN = new Veto.ButtonEllipse();
            this.RDVLYT = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WednesdayLB = new System.Windows.Forms.Label();
            this.ThursdayLB = new System.Windows.Forms.Label();
            this.TuesdayLB = new System.Windows.Forms.Label();
            this.FridayLB = new System.Windows.Forms.Label();
            this.MondayLB = new System.Windows.Forms.Label();
            this.DaysPNL = new System.Windows.Forms.Panel();
            this.WeekLB = new System.Windows.Forms.Label();
            this.AddRdvBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.DaysPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPNL
            // 
            this.CenterPNL.Location = new System.Drawing.Point(0, 0);
            this.CenterPNL.Size = new System.Drawing.Size(1064, 681);
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.AddRdvBT);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextBTN.FlatAppearance.BorderSize = 0;
            this.NextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.ForeColor = System.Drawing.Color.White;
            this.NextBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextBTN.Location = new System.Drawing.Point(1003, 92);
            this.NextBTN.Margin = new System.Windows.Forms.Padding(0);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.NextBTN.Size = new System.Drawing.Size(52, 52);
            this.NextBTN.TabIndex = 22;
            this.NextBTN.Text = ">";
            this.NextBTN.UseVisualStyleBackColor = false;
            this.NextBTN.Click += new System.EventHandler(this.NextBT_Click);
            // 
            // PrevBTN
            // 
            this.PrevBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.PrevBTN.FlatAppearance.BorderSize = 0;
            this.PrevBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBTN.ForeColor = System.Drawing.Color.White;
            this.PrevBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PrevBTN.Location = new System.Drawing.Point(320, 92);
            this.PrevBTN.Name = "PrevBTN";
            this.PrevBTN.Size = new System.Drawing.Size(50, 50);
            this.PrevBTN.TabIndex = 21;
            this.PrevBTN.Text = "<";
            this.PrevBTN.UseVisualStyleBackColor = false;
            this.PrevBTN.Click += new System.EventHandler(this.PrevBT_Click);
            // 
            // RDVLYT
            // 
            this.RDVLYT.Location = new System.Drawing.Point(320, 181);
            this.RDVLYT.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.RDVLYT.Name = "RDVLYT";
            this.RDVLYT.Size = new System.Drawing.Size(735, 488);
            this.RDVLYT.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "9h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "10h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "11h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "12h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "13h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "14h";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "15h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(299, 559);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "16h";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(299, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "17h";
            // 
            // WednesdayLB
            // 
            this.WednesdayLB.AutoSize = true;
            this.WednesdayLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayLB.Location = new System.Drawing.Point(332, 8);
            this.WednesdayLB.Name = "WednesdayLB";
            this.WednesdayLB.Size = new System.Drawing.Size(0, 17);
            this.WednesdayLB.TabIndex = 35;
            // 
            // ThursdayLB
            // 
            this.ThursdayLB.AutoSize = true;
            this.ThursdayLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayLB.Location = new System.Drawing.Point(492, 8);
            this.ThursdayLB.Name = "ThursdayLB";
            this.ThursdayLB.Size = new System.Drawing.Size(0, 17);
            this.ThursdayLB.TabIndex = 36;
            // 
            // TuesdayLB
            // 
            this.TuesdayLB.AutoSize = true;
            this.TuesdayLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayLB.Location = new System.Drawing.Point(196, 8);
            this.TuesdayLB.Name = "TuesdayLB";
            this.TuesdayLB.Size = new System.Drawing.Size(0, 17);
            this.TuesdayLB.TabIndex = 34;
            // 
            // FridayLB
            // 
            this.FridayLB.AutoSize = true;
            this.FridayLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayLB.Location = new System.Drawing.Point(633, 8);
            this.FridayLB.Name = "FridayLB";
            this.FridayLB.Size = new System.Drawing.Size(0, 17);
            this.FridayLB.TabIndex = 37;
            // 
            // MondayLB
            // 
            this.MondayLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MondayLB.AutoSize = true;
            this.MondayLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayLB.Location = new System.Drawing.Point(55, 8);
            this.MondayLB.Name = "MondayLB";
            this.MondayLB.Size = new System.Drawing.Size(0, 17);
            this.MondayLB.TabIndex = 33;
            this.MondayLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DaysPNL
            // 
            this.DaysPNL.Controls.Add(this.FridayLB);
            this.DaysPNL.Controls.Add(this.ThursdayLB);
            this.DaysPNL.Controls.Add(this.WednesdayLB);
            this.DaysPNL.Controls.Add(this.TuesdayLB);
            this.DaysPNL.Controls.Add(this.MondayLB);
            this.DaysPNL.Location = new System.Drawing.Point(320, 147);
            this.DaysPNL.Name = "DaysPNL";
            this.DaysPNL.Size = new System.Drawing.Size(735, 31);
            this.DaysPNL.TabIndex = 38;
            // 
            // WeekLB
            // 
            this.WeekLB.AutoSize = true;
            this.WeekLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekLB.Location = new System.Drawing.Point(567, 108);
            this.WeekLB.Name = "WeekLB";
            this.WeekLB.Size = new System.Drawing.Size(121, 25);
            this.WeekLB.TabIndex = 39;
            this.WeekLB.Text = "Semaine du ";
            // 
            // AddRdvBT
            // 
            this.AddRdvBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddRdvBT.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddRdvBT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRdvBT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRdvBT.ForeColor = System.Drawing.Color.White;
            this.AddRdvBT.Location = new System.Drawing.Point(54, 19);
            this.AddRdvBT.Name = "AddRdvBT";
            this.AddRdvBT.Size = new System.Drawing.Size(191, 23);
            this.AddRdvBT.TabIndex = 0;
            this.AddRdvBT.Text = "NOUVEAU RENDEZ-VOUS";
            this.AddRdvBT.UseVisualStyleBackColor = false;
            this.AddRdvBT.Click += new System.EventHandler(this.AddRdvBT_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.WeekLB);
            this.Controls.Add(this.DaysPNL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RDVLYT);
            this.Controls.Add(this.NextBTN);
            this.Controls.Add(this.PrevBTN);
            this.Name = "Calendar";
            this.Activated += new System.EventHandler(this.Calendar_Activated);
            this.Controls.SetChildIndex(this.CenterPNL, 0);
            this.Controls.SetChildIndex(this.PrevBTN, 0);
            this.Controls.SetChildIndex(this.NextBTN, 0);
            this.Controls.SetChildIndex(this.RDVLYT, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.DaysPNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.WeekLB, 0);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.DaysPNL.ResumeLayout(false);
            this.DaysPNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse NextBTN;
        private ButtonEllipse PrevBTN;
        private System.Windows.Forms.FlowLayoutPanel RDVLYT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label WednesdayLB;
        private System.Windows.Forms.Label ThursdayLB;
        private System.Windows.Forms.Label TuesdayLB;
        private System.Windows.Forms.Label FridayLB;
        private System.Windows.Forms.Label MondayLB;
        private System.Windows.Forms.Panel DaysPNL;
        private System.Windows.Forms.Label WeekLB;
        private System.Windows.Forms.Button AddRdvBT;
    }
}
