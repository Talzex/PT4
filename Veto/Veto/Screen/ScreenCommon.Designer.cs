﻿
namespace Veto
{
    partial class ScreenCommon
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
            this.UserLBL = new System.Windows.Forms.Label();
            this.DisconnectBT = new System.Windows.Forms.Button();
            this.SidePNL = new System.Windows.Forms.SplitContainer();
            this.TopPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPNL
            // 
            this.TopPNL.Controls.Add(this.DisconnectBT);
            this.TopPNL.Controls.SetChildIndex(this.DisconnectBT, 0);
            // 
            // UserLBL
            // 
            this.UserLBL.AutoSize = true;
            this.UserLBL.BackColor = System.Drawing.Color.Transparent;
            this.UserLBL.Location = new System.Drawing.Point(97, 41);
            this.UserLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLBL.Name = "UserLBL";
            this.UserLBL.Size = new System.Drawing.Size(38, 17);
            this.UserLBL.TabIndex = 4;
            this.UserLBL.Text = "User";
            // 
            // DisconnectBT
            // 
            this.DisconnectBT.Location = new System.Drawing.Point(1302, 33);
            this.DisconnectBT.Name = "DisconnectBT";
            this.DisconnectBT.Size = new System.Drawing.Size(104, 32);
            this.DisconnectBT.TabIndex = 6;
            this.DisconnectBT.Text = "Déconnexion";
            this.DisconnectBT.UseVisualStyleBackColor = true;
            // 
            // SidePNL
            // 
            this.SidePNL.BackColor = System.Drawing.Color.Black;
            this.SidePNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePNL.Location = new System.Drawing.Point(0, 0);
            this.SidePNL.Name = "SidePNL";
            this.SidePNL.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SidePNL.Panel1
            // 
            this.SidePNL.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(130)))));
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(130)))));
            this.SidePNL.Size = new System.Drawing.Size(300, 838);
            this.SidePNL.SplitterDistance = 441;
            this.SidePNL.TabIndex = 7;
            // 
            // ScreenCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Controls.Add(this.SidePNL);
            this.Controls.Add(this.UserLBL);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScreenCommon";
            this.Load += new System.EventHandler(this.EcranCommun_Load);
            this.Controls.SetChildIndex(this.UserLBL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.TopPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLBL;
        private System.Windows.Forms.Button DisconnectBT;
        protected System.Windows.Forms.SplitContainer SidePNL;
    }
}
