﻿
namespace Veto
{
    partial class ScreenAdmin
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
            this.UserBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel1.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel1
            // 
            this.SidePNL.Panel1.Controls.Add(this.UserBTN);
            // 
            // UserBTN
            // 
            this.UserBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.UserBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBTN.ForeColor = System.Drawing.Color.White;
            this.UserBTN.Location = new System.Drawing.Point(50, 118);
            this.UserBTN.Name = "UserBTN";
            this.UserBTN.Size = new System.Drawing.Size(191, 28);
            this.UserBTN.TabIndex = 8;
            this.UserBTN.Text = "EMPLOYÉS";
            this.UserBTN.UseVisualStyleBackColor = false;
            this.UserBTN.Click += new System.EventHandler(this.UserBTN_Click);
            // 
            // ScreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScreenAdmin";
            this.SidePNL.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserBTN;
    }
}
