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
            this.NameLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.SellPriceLBL = new System.Windows.Forms.Label();
            this.panel_product = new System.Windows.Forms.Panel();
            this.RemoveBTN = new System.Windows.Forms.Button();
            this.ModifyBTN = new System.Windows.Forms.Button();
            this.ImageProductPBOX = new System.Windows.Forms.PictureBox();
            this.PurchasePriceLBL = new System.Windows.Forms.Label();
            this.panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProductPBOX)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.Location = new System.Drawing.Point(69, 85);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(61, 21);
            this.NameLBL.TabIndex = 0;
            this.NameLBL.Text = "Produit";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLBL.Location = new System.Drawing.Point(50, 110);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(99, 21);
            this.QuantityLBL.TabIndex = 1;
            this.QuantityLBL.Text = "Quantité : 12";
            // 
            // SellPriceLBL
            // 
            this.SellPriceLBL.AutoSize = true;
            this.SellPriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLBL.Location = new System.Drawing.Point(31, 134);
            this.SellPriceLBL.Name = "SellPriceLBL";
            this.SellPriceLBL.Size = new System.Drawing.Size(137, 21);
            this.SellPriceLBL.TabIndex = 2;
            this.SellPriceLBL.Text = "Prix de vente : 20€";
            // 
            // panel_product
            // 
            this.panel_product.Controls.Add(this.RemoveBTN);
            this.panel_product.Controls.Add(this.ModifyBTN);
            this.panel_product.Controls.Add(this.ImageProductPBOX);
            this.panel_product.Controls.Add(this.PurchasePriceLBL);
            this.panel_product.Controls.Add(this.NameLBL);
            this.panel_product.Controls.Add(this.SellPriceLBL);
            this.panel_product.Controls.Add(this.QuantityLBL);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product.Location = new System.Drawing.Point(0, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(200, 205);
            this.panel_product.TabIndex = 3;
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.RemoveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBTN.ForeColor = System.Drawing.Color.White;
            this.RemoveBTN.Location = new System.Drawing.Point(122, 179);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(75, 23);
            this.RemoveBTN.TabIndex = 6;
            this.RemoveBTN.Text = "SUPPRIMER";
            this.RemoveBTN.UseVisualStyleBackColor = false;
            this.RemoveBTN.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // PurchasePriceLBL
            // 
            this.PurchasePriceLBL.AutoSize = true;
            this.PurchasePriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceLBL.Location = new System.Drawing.Point(36, 156);
            this.PurchasePriceLBL.Name = "PurchasePriceLBL";
            this.PurchasePriceLBL.Size = new System.Drawing.Size(128, 21);
            this.PurchasePriceLBL.TabIndex = 3;
            this.PurchasePriceLBL.Text = "Prix d\'achat : 10€";
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

        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private System.Windows.Forms.Label SellPriceLBL;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Label PurchasePriceLBL;
        private System.Windows.Forms.PictureBox ImageProductPBOX;
        private System.Windows.Forms.Button RemoveBTN;
        private System.Windows.Forms.Button ModifyBTN;
    }
}
