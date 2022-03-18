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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NameProduct = new System.Windows.Forms.TextBox();
            this.SellPriceProduct = new System.Windows.Forms.TextBox();
            this.QuantityProduct = new System.Windows.Forms.TextBox();
            this.PurchasePriceProduct = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_sellprice = new System.Windows.Forms.Label();
            this.label_purchaseprice = new System.Windows.Forms.Label();
            this.AddimageBTN = new System.Windows.Forms.Button();
            this.ConfirmProductBTN = new System.Windows.Forms.Button();
            this.CancelBTN = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(119, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(128, 21);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Ajouter produit";
            // 
            // NameProduct
            // 
            this.NameProduct.Location = new System.Drawing.Point(12, 62);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(100, 20);
            this.NameProduct.TabIndex = 1;
            // 
            // SellPriceProduct
            // 
            this.SellPriceProduct.Location = new System.Drawing.Point(12, 126);
            this.SellPriceProduct.Name = "SellPriceProduct";
            this.SellPriceProduct.Size = new System.Drawing.Size(100, 20);
            this.SellPriceProduct.TabIndex = 3;
            // 
            // QuantityProduct
            // 
            this.QuantityProduct.Location = new System.Drawing.Point(193, 62);
            this.QuantityProduct.Name = "QuantityProduct";
            this.QuantityProduct.Size = new System.Drawing.Size(100, 20);
            this.QuantityProduct.TabIndex = 2;
            // 
            // PurchasePriceProduct
            // 
            this.PurchasePriceProduct.Location = new System.Drawing.Point(193, 126);
            this.PurchasePriceProduct.Name = "PurchasePriceProduct";
            this.PurchasePriceProduct.Size = new System.Drawing.Size(100, 20);
            this.PurchasePriceProduct.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(8, 38);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(100, 21);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Nom produit";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quantity.Location = new System.Drawing.Point(189, 38);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(125, 21);
            this.label_quantity.TabIndex = 7;
            this.label_quantity.Text = "Quantité produit";
            // 
            // label_sellprice
            // 
            this.label_sellprice.AutoSize = true;
            this.label_sellprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sellprice.Location = new System.Drawing.Point(8, 102);
            this.label_sellprice.Name = "label_sellprice";
            this.label_sellprice.Size = new System.Drawing.Size(99, 21);
            this.label_sellprice.TabIndex = 8;
            this.label_sellprice.Text = "Prix de vente";
            // 
            // label_purchaseprice
            // 
            this.label_purchaseprice.AutoSize = true;
            this.label_purchaseprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchaseprice.Location = new System.Drawing.Point(189, 102);
            this.label_purchaseprice.Name = "label_purchaseprice";
            this.label_purchaseprice.Size = new System.Drawing.Size(90, 21);
            this.label_purchaseprice.TabIndex = 9;
            this.label_purchaseprice.Text = "Prix d\'achat";
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
            this.Controls.Add(this.label_purchaseprice);
            this.Controls.Add(this.label_sellprice);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.PurchasePriceProduct);
            this.Controls.Add(this.QuantityProduct);
            this.Controls.Add(this.SellPriceProduct);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.TitleLabel);
            this.Name = "StockAjout";
            this.Text = "StockAjout";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NameProduct;
        private System.Windows.Forms.TextBox SellPriceProduct;
        private System.Windows.Forms.TextBox QuantityProduct;
        private System.Windows.Forms.TextBox PurchasePriceProduct;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_sellprice;
        private System.Windows.Forms.Label label_purchaseprice;
        private System.Windows.Forms.Button AddimageBTN;
        private System.Windows.Forms.Button ConfirmProductBTN;
        private System.Windows.Forms.Button CancelBTN;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}