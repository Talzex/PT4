namespace Veto
{
    partial class ClientComponent
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
            this.TelLBL = new System.Windows.Forms.Label();
            this.EmailLBL = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.Location = new System.Drawing.Point(56, 7);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(115, 28);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Name Label";
            // 
            // TelLBL
            // 
            this.TelLBL.AutoSize = true;
            this.TelLBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelLBL.Location = new System.Drawing.Point(57, 37);
            this.TelLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TelLBL.Name = "TelLBL";
            this.TelLBL.Size = new System.Drawing.Size(92, 23);
            this.TelLBL.TabIndex = 1;
            this.TelLBL.Text = "Téléphone:";
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLBL.Location = new System.Drawing.Point(59, 63);
            this.EmailLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(55, 23);
            this.EmailLBL.TabIndex = 2;
            this.EmailLBL.Text = "Email:";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(808, 22);
            this.DetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(172, 53);
            this.DetailsButton.TabIndex = 4;
            this.DetailsButton.Text = "Détails";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // ClientComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.EmailLBL);
            this.Controls.Add(this.TelLBL);
            this.Controls.Add(this.NameLBL);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientComponent";
            this.Size = new System.Drawing.Size(1013, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label TelLBL;
        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.Button DetailsButton;
    }
}
