
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
            this.TopPNL.Controls.Add(this.UserLBL);
            this.TopPNL.Controls.SetChildIndex(this.UserLBL, 0);
            this.TopPNL.Controls.SetChildIndex(this.DisconnectBT, 0);
            // 
            // UserLBL
            // 
            this.UserLBL.AutoSize = true;
            this.UserLBL.BackColor = System.Drawing.Color.Transparent;
            this.UserLBL.Location = new System.Drawing.Point(100, 41);
            this.UserLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLBL.Name = "UserLBL";
            this.UserLBL.Size = new System.Drawing.Size(29, 13);
            this.UserLBL.TabIndex = 4;
            this.UserLBL.Text = "User";
            // 
            // DisconnectBT
            // 
            this.DisconnectBT.Location = new System.Drawing.Point(976, 27);
            this.DisconnectBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisconnectBT.Name = "DisconnectBT";
            this.DisconnectBT.Size = new System.Drawing.Size(78, 26);
            this.DisconnectBT.TabIndex = 6;
            this.DisconnectBT.Text = "Déconnexion";
            this.DisconnectBT.UseVisualStyleBackColor = true;
            this.DisconnectBT.Click += new System.EventHandler(this.DisconnectBT_Click);
            // 
            // SidePNL
            // 
            this.SidePNL.BackColor = System.Drawing.Color.Black;
            this.SidePNL.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePNL.Location = new System.Drawing.Point(0, 86);
            this.SidePNL.Name = "SidePNL";
            this.SidePNL.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SidePNL.Panel1
            // 
            this.SidePNL.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(192)))), ((int)(((byte)(121)))));
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(192)))), ((int)(((byte)(121)))));
            this.SidePNL.Size = new System.Drawing.Size(260, 752);
            this.SidePNL.SplitterDistance = 376;
            this.SidePNL.TabIndex = 4;
            // 
            // ScreenCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(239)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.SidePNL);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScreenCommon";
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.TopPNL.ResumeLayout(false);
            this.TopPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UserLBL;
        private System.Windows.Forms.Button DisconnectBT;
        protected System.Windows.Forms.SplitContainer SidePNL;
    }
}
