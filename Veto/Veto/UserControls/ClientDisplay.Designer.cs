namespace Veto
{
    partial class ClientDisplay
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
            this.NameLBL = new System.Windows.Forms.Label();
            this.DetailsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Location = new System.Drawing.Point(13, 33);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(29, 13);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Nom";
            // 
            // DetailsBTN
            // 
            this.DetailsBTN.Location = new System.Drawing.Point(245, 28);
            this.DetailsBTN.Name = "DetailsBTN";
            this.DetailsBTN.Size = new System.Drawing.Size(75, 23);
            this.DetailsBTN.TabIndex = 1;
            this.DetailsBTN.Text = "Details";
            this.DetailsBTN.UseVisualStyleBackColor = true;
            this.DetailsBTN.Click += new System.EventHandler(this.DetailsBTN_Click);
            // 
            // ClientDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.DetailsBTN);
            this.Controls.Add(this.NameLBL);
            this.Name = "ClientDisplay";
            this.Size = new System.Drawing.Size(342, 75);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Button DetailsBTN;
    }
}
