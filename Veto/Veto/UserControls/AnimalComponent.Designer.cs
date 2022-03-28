namespace Veto
{
    partial class AnimalComponent
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
            this.SpecieLBL = new System.Windows.Forms.Label();
            this.AgeLBL = new System.Windows.Forms.Label();
            this.DetailsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(19, 6);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(101, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name Label";
            // 
            // SpecieLBL
            // 
            this.SpecieLBL.AutoSize = true;
            this.SpecieLBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecieLBL.Location = new System.Drawing.Point(19, 27);
            this.SpecieLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpecieLBL.Name = "SpecieLBL";
            this.SpecieLBL.Size = new System.Drawing.Size(66, 23);
            this.SpecieLBL.TabIndex = 1;
            this.SpecieLBL.Text = "Espèce:";
            // 
            // AgeLBL
            // 
            this.AgeLBL.AutoSize = true;
            this.AgeLBL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLBL.Location = new System.Drawing.Point(19, 48);
            this.AgeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLBL.Name = "AgeLBL";
            this.AgeLBL.Size = new System.Drawing.Size(44, 23);
            this.AgeLBL.TabIndex = 2;
            this.AgeLBL.Text = "Age:";
            // 
            // DetailsBTN
            // 
            this.DetailsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(130)))));
            this.DetailsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DetailsBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBTN.Location = new System.Drawing.Point(811, 16);
            this.DetailsBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DetailsBTN.Name = "DetailsBTN";
            this.DetailsBTN.Size = new System.Drawing.Size(100, 42);
            this.DetailsBTN.TabIndex = 3;
            this.DetailsBTN.Text = "Détails";
            this.DetailsBTN.UseVisualStyleBackColor = false;
            this.DetailsBTN.Click += new System.EventHandler(this.DetailsBTN_Click);
            // 
            // AnimalComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailsBTN);
            this.Controls.Add(this.AgeLBL);
            this.Controls.Add(this.SpecieLBL);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnimalComponent";
            this.Size = new System.Drawing.Size(973, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpecieLBL;
        private System.Windows.Forms.Label AgeLBL;
        private System.Windows.Forms.Button DetailsBTN;
    }
}
