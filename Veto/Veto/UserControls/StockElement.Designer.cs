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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockElement));
            this.label_nom = new System.Windows.Forms.Label();
            this.label_quantite = new System.Windows.Forms.Label();
            this.label_pricesell = new System.Windows.Forms.Label();
            this.panel_product = new System.Windows.Forms.Panel();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.ModifyBTN = new System.Windows.Forms.Button();
            this.ImageProductPBOX = new System.Windows.Forms.PictureBox();
            this.label_purchaseprice = new System.Windows.Forms.Label();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.Location = new System.Drawing.Point(69, 85);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(61, 21);
            this.label_nom.TabIndex = 0;
            this.label_nom.Text = "Produit";
            // 
            // label_quantite
            // 
            this.label_quantite.AutoSize = true;
            this.label_quantite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantite.Location = new System.Drawing.Point(50, 110);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(99, 21);
            this.label_quantite.TabIndex = 1;
            this.label_quantite.Text = "Quantité : 12";
            // 
            // label_pricesell
            // 
            this.label_pricesell.AutoSize = true;
            this.label_pricesell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pricesell.Location = new System.Drawing.Point(31, 134);
            this.label_pricesell.Name = "label_pricesell";
            this.label_pricesell.Size = new System.Drawing.Size(137, 21);
            this.label_pricesell.TabIndex = 2;
            this.label_pricesell.Text = "Prix de vente : 20€";
            // 
            // panel_product
            // 
            this.panel_product.Controls.Add(this.DeleteBTN);
            this.panel_product.Controls.Add(this.ModifyBTN);
            this.panel_product.Controls.Add(this.ImageProductPBOX);
            this.panel_product.Controls.Add(this.label_purchaseprice);
            this.panel_product.Controls.Add(this.label_nom);
            this.panel_product.Controls.Add(this.label_pricesell);
            this.panel_product.Controls.Add(this.label_quantite);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product.Location = new System.Drawing.Point(0, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(200, 205);
            this.panel_product.TabIndex = 3;
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.DeleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.Location = new System.Drawing.Point(122, 179);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 6;
            this.DeleteBTN.Text = "SUPPRIMER";
            this.DeleteBTN.UseVisualStyleBackColor = false;
            this.DeleteBTN.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ModifyBTN
            // 
            this.ModifyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ModifyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ModifyBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBTN.ForeColor = System.Drawing.Color.White;
            this.ModifyBTN.Location = new System.Drawing.Point(3, 179);
            this.ModifyBTN.Name = "ModifyBTN";
            this.ModifyBTN.Size = new System.Drawing.Size(75, 23);
            this.ModifyBTN.TabIndex = 5;
            this.ModifyBTN.Text = "MODIFIER";
            this.ModifyBTN.UseVisualStyleBackColor = false;
            this.ModifyBTN.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // ImageProductPBOX
            // 
            this.ImageProductPBOX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageProductPBOX.BackgroundImage")));
            this.ImageProductPBOX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageProductPBOX.Location = new System.Drawing.Point(62, 5);
            this.ImageProductPBOX.Name = "ImageProductPBOX";
            this.ImageProductPBOX.Size = new System.Drawing.Size(75, 75);
            this.ImageProductPBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProductPBOX.TabIndex = 4;
            this.ImageProductPBOX.TabStop = false;
            this.ImageProductPBOX.Click += new System.EventHandler(this.ImageProductPBOX_Click);
            // 
            // label_purchaseprice
            // 
            this.label_purchaseprice.AutoSize = true;
            this.label_purchaseprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchaseprice.Location = new System.Drawing.Point(36, 156);
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
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductPBOX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.Label label_pricesell;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Label label_purchaseprice;
        private System.Windows.Forms.PictureBox ImageProductPBOX;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button ModifyBTN;
    }
}
