﻿namespace Veto
{
    partial class Schedule
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientLB = new System.Windows.Forms.Label();
            this.AnimalLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClientLB
            // 
            this.ClientLB.AutoSize = true;
            this.ClientLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLB.Location = new System.Drawing.Point(37, 10);
            this.ClientLB.Name = "ClientLB";
            this.ClientLB.Size = new System.Drawing.Size(43, 15);
            this.ClientLB.TabIndex = 0;
            this.ClientLB.Text = "Client: ";
            this.ClientLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnimalLB
            // 
            this.AnimalLB.AutoSize = true;
            this.AnimalLB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalLB.Location = new System.Drawing.Point(29, 25);
            this.AnimalLB.Name = "AnimalLB";
            this.AnimalLB.Size = new System.Drawing.Size(48, 15);
            this.AnimalLB.TabIndex = 1;
            this.AnimalLB.Text = "Animal:";
            this.AnimalLB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AnimalLB);
            this.Controls.Add(this.ClientLB);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(147, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLB;
        private System.Windows.Forms.Label AnimalLB;
    }
}