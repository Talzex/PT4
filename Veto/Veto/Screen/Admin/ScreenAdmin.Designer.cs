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
            this.LogsBTN = new System.Windows.Forms.Button();
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
            this.SidePNL.Panel1.Controls.Add(this.LogsBTN);
            this.SidePNL.Panel1.Controls.Add(this.UserBTN);
            this.SidePNL.Size = new System.Drawing.Size(300, 595);
            this.SidePNL.SplitterDistance = 312;
            // 
            // UserBTN
            // 
            this.UserBTN.Location = new System.Drawing.Point(78, 113);
            this.UserBTN.Name = "UserBTN";
            this.UserBTN.Size = new System.Drawing.Size(127, 35);
            this.UserBTN.TabIndex = 8;
            this.UserBTN.Text = "Employés";
            this.UserBTN.UseVisualStyleBackColor = true;
            this.UserBTN.Click += new System.EventHandler(this.UserBTN_Click);
            // 
            // LogsBTN
            // 
            this.LogsBTN.Location = new System.Drawing.Point(78, 180);
            this.LogsBTN.Name = "LogsBTN";
            this.LogsBTN.Size = new System.Drawing.Size(127, 35);
            this.LogsBTN.TabIndex = 9;
            this.LogsBTN.Text = "Historique";
            this.LogsBTN.UseVisualStyleBackColor = true;
            this.LogsBTN.Click += new System.EventHandler(this.LogsBTN_Click);
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
        private System.Windows.Forms.Button LogsBTN;
    }
}
