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
            this.NameLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(42, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name Label";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelLabel.Location = new System.Drawing.Point(43, 30);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(71, 17);
            this.TelLabel.TabIndex = 1;
            this.TelLabel.Text = "Téléphone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(44, 51);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // DetailsButton
            // 
            this.DetailsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsButton.Location = new System.Drawing.Point(606, 18);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Size = new System.Drawing.Size(129, 43);
            this.DetailsButton.TabIndex = 4;
            this.DetailsButton.Text = "Détails";
            this.DetailsButton.UseVisualStyleBackColor = true;
            // 
            // ClientComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(226)))));
            this.Controls.Add(this.DetailsButton);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TelLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "ClientComponent";
            this.Size = new System.Drawing.Size(760, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button DetailsButton;
    }
}
