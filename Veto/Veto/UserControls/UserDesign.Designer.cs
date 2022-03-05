
namespace Veto
{
    partial class UserDesign
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
            this.DetailsBTN = new System.Windows.Forms.Button();
            this.DescLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DetailsBTN
            // 
            this.DetailsBTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DetailsBTN.Location = new System.Drawing.Point(738, 25);
            this.DetailsBTN.Name = "DetailsBTN";
            this.DetailsBTN.Size = new System.Drawing.Size(100, 38);
            this.DetailsBTN.TabIndex = 0;
            this.DetailsBTN.Text = "Détails";
            this.DetailsBTN.UseVisualStyleBackColor = true;
            // 
            // DescLBL
            // 
            this.DescLBL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescLBL.AutoSize = true;
            this.DescLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLBL.Location = new System.Drawing.Point(19, 29);
            this.DescLBL.Name = "DescLBL";
            this.DescLBL.Size = new System.Drawing.Size(133, 25);
            this.DescLBL.TabIndex = 1;
            this.DescLBL.Text = "Pseudo | Rôle";
            // 
            // UserDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(146)))), ((int)(((byte)(121)))));
            this.Controls.Add(this.DescLBL);
            this.Controls.Add(this.DetailsBTN);
            this.Name = "UserDesign";
            this.Size = new System.Drawing.Size(861, 87);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DetailsBTN;
        private System.Windows.Forms.Label DescLBL;
    }
}
