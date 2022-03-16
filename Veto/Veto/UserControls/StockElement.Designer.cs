namespace Veto
{
    partial class StockElement
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
            this.label_nom = new System.Windows.Forms.Label();
            this.label_quantite = new System.Windows.Forms.Label();
            this.label_pricesell = new System.Windows.Forms.Label();
            this.panel_product = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_purchaseprice = new System.Windows.Forms.Label();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(69, 108);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(61, 21);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Produit";
            // 
            // label_quantite
            // 
            this.label_quantite.AutoSize = true;
            this.label_quantite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantite.Location = new System.Drawing.Point(50, 129);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(99, 21);
            this.label_quantite.TabIndex = 1;
            this.label_quantite.Text = "Quantité : 12";
            // 
            // label_pricesell
            // 
            this.label_pricesell.AutoSize = true;
            this.label_pricesell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pricesell.Location = new System.Drawing.Point(31, 153);
            this.label_pricesell.Name = "label_pricesell";
            this.label_pricesell.Size = new System.Drawing.Size(137, 21);
            this.label_pricesell.TabIndex = 2;
            this.label_pricesell.Text = "Prix de vente : 20€";
            // 
            // panel_product
            // 
            this.panel_product.Controls.Add(this.pictureBox1);
            this.panel_product.Controls.Add(this.label_purchaseprice);
            this.panel_product.Controls.Add(this.label_nom);
            this.panel_product.Controls.Add(this.label_pricesell);
            this.panel_product.Controls.Add(this.label_quantite);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product.Location = new System.Drawing.Point(0, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(200, 205);
            this.panel_product.TabIndex = 3;
            this.panel_product.Click += new System.EventHandler(this.panel_product_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_purchaseprice
            // 
            this.label_purchaseprice.AutoSize = true;
            this.label_purchaseprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchaseprice.Location = new System.Drawing.Point(36, 177);
            this.label_purchaseprice.Name = "label_purchaseprice";
            this.label_purchaseprice.Size = new System.Drawing.Size(128, 21);
            this.label_purchaseprice.TabIndex = 3;
            this.label_purchaseprice.Text = "Prix d\'achat : 10€";
            // 
            // StockElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(219)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.panel_product);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StockElement";
            this.Size = new System.Drawing.Size(200, 205);
            this.panel_product.ResumeLayout(false);
            this.panel_product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.Label label_pricesell;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Label label_purchaseprice;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
