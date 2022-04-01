namespace Veto
{
    partial class StockAjout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLBL = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.SellPriceProduct = new System.Windows.Forms.TextBox();
            this.QuantityProduct = new System.Windows.Forms.TextBox();
            this.PurchasePriceProduct = new System.Windows.Forms.TextBox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.SellPriceLBL = new System.Windows.Forms.Label();
            this.PurchasePriceLBL = new System.Windows.Forms.Label();
            this.AddimageBTN = new System.Windows.Forms.Button();
            this.ConfirmProductBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.Location = new System.Drawing.Point(72, 9);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(222, 21);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "Ajouter ou modifier produit";
            // 
            // NameProduct
            // 
            this.NameProduct.Location = new System.Drawing.Point(12, 62);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(100, 20);
            this.NameProduct.TabIndex = 1;
            this.NameProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameProduct_KeyPress);
            // 
            // SellPriceProduct
            // 
            this.SellPriceProduct.Location = new System.Drawing.Point(12, 126);
            this.SellPriceProduct.Name = "SellPriceProduct";
            this.SellPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.SellPriceProduct.TabIndex = 3;
            this.SellPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SellPriceProduct_KeyPress);
            // 
            // QuantityProduct
            // 
            this.QuantityProduct.Location = new System.Drawing.Point(193, 62);
            this.QuantityProduct.Name = "QuantityProduct";
            this.QuantityProduct.Size = new System.Drawing.Size(100, 20);
            this.QuantityProduct.TabIndex = 2;
            this.QuantityProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityProduct_KeyPress);
            // 
            // PurchasePriceProduct
            // 
            this.PurchasePriceProduct.Location = new System.Drawing.Point(193, 126);
            this.PurchasePriceProduct.Name = "PurchasePriceProduct";
            this.PurchasePriceProduct.Size = new System.Drawing.Size(100, 20);
            this.PurchasePriceProduct.TabIndex = 4;
            this.PurchasePriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PurchasePriceProduct_KeyPress);
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.Location = new System.Drawing.Point(8, 38);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(100, 21);
            this.NameLBL.TabIndex = 6;
            this.NameLBL.Text = "Nom produit";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLBL.Location = new System.Drawing.Point(189, 38);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(125, 21);
            this.QuantityLBL.TabIndex = 7;
            this.QuantityLBL.Text = "Quantité produit";
            // 
            // SellPriceLBL
            // 
            this.SellPriceLBL.AutoSize = true;
            this.SellPriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLBL.Location = new System.Drawing.Point(8, 102);
            this.SellPriceLBL.Name = "SellPriceLBL";
            this.SellPriceLBL.Size = new System.Drawing.Size(99, 21);
            this.SellPriceLBL.TabIndex = 8;
            this.SellPriceLBL.Text = "Prix de vente";
            // 
            // PurchasePriceLBL
            // 
            this.PurchasePriceLBL.AutoSize = true;
            this.PurchasePriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceLBL.Location = new System.Drawing.Point(189, 102);
            this.PurchasePriceLBL.Name = "PurchasePriceLBL";
            this.PurchasePriceLBL.Size = new System.Drawing.Size(90, 21);
            this.PurchasePriceLBL.TabIndex = 9;
            this.PurchasePriceLBL.Text = "Prix d\'achat";
            // 
            // AddimageBTN
            // 
            this.AddimageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddimageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddimageBTN.ForeColor = System.Drawing.Color.White;
            this.AddimageBTN.Location = new System.Drawing.Point(12, 183);
            this.AddimageBTN.Name = "AddimageBTN";
            this.AddimageBTN.Size = new System.Drawing.Size(105, 23);
            this.AddimageBTN.TabIndex = 5;
            this.AddimageBTN.Text = "AJOUTER IMAGE";
            this.AddimageBTN.UseVisualStyleBackColor = false;
            this.AddimageBTN.Click += new System.EventHandler(this.AddimageBTN_Click);
            // 
            // ConfirmProductBTN
            // 
            this.ConfirmProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ConfirmProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmProductBTN.ForeColor = System.Drawing.Color.White;
            this.ConfirmProductBTN.Location = new System.Drawing.Point(12, 249);
            this.ConfirmProductBTN.Name = "ConfirmProductBTN";
            this.ConfirmProductBTN.Size = new System.Drawing.Size(105, 23);
            this.ConfirmProductBTN.TabIndex = 6;
            this.ConfirmProductBTN.Text = "VALIDER";
            this.ConfirmProductBTN.UseVisualStyleBackColor = false;
            this.ConfirmProductBTN.Click += new System.EventHandler(this.ConfirmProductBTN_Click);
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.CancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.Location = new System.Drawing.Point(234, 249);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.Size = new System.Drawing.Size(105, 23);
            this.CancelBTN.TabIndex = 7;
            this.CancelBTN.Text = "ANNULER";
            this.CancelBTN.UseVisualStyleBackColor = false;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(128, 160);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(75, 75);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 14;
            this.PictureBox.TabStop = false;
            // 
            // StockAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(350, 277);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.CancelBTN);
            this.Controls.Add(this.ConfirmProductBTN);
            this.Controls.Add(this.AddimageBTN);
            this.Controls.Add(this.PurchasePriceLBL);
            this.Controls.Add(this.SellPriceLBL);
            this.Controls.Add(this.QuantityLBL);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.PurchasePriceProduct);
            this.Controls.Add(this.QuantityProduct);
            this.Controls.Add(this.SellPriceProduct);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.TitleLBL);
            this.Name = "StockAjout";
            this.Text = "StockAjout";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.TextBox SellPriceProduct;
        private System.Windows.Forms.TextBox QuantityProduct;
        private System.Windows.Forms.TextBox PurchasePriceProduct;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private System.Windows.Forms.Label SellPriceLBL;
        private System.Windows.Forms.Label PurchasePriceLBL;
        private System.Windows.Forms.Button AddimageBTN;
        private System.Windows.Forms.Button ConfirmProductBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}