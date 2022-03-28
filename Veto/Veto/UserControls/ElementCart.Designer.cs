
namespace Veto
{
    partial class ElementCart
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
            this.label_product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_unitprice = new System.Windows.Forms.Label();
            this.label_Quantity = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.button_less = new Veto.ButtonEllipse();
            this.button_add = new Veto.ButtonEllipse();
            this.button_remove = new Veto.ButtonEllipse();
            this.SuspendLayout();
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(75, 23);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(78, 21);
            this.label_product.TabIndex = 3;
            this.label_product.Text = "Produit 1 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(744, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total : 30€";
            // 
            // label_unitprice
            // 
            this.label_unitprice.AutoSize = true;
            this.label_unitprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unitprice.Location = new System.Drawing.Point(606, 23);
            this.label_unitprice.Name = "label_unitprice";
            this.label_unitprice.Size = new System.Drawing.Size(93, 21);
            this.label_unitprice.TabIndex = 1;
            this.label_unitprice.Text = "Prix /u : 15€";
            // 
            // label_Quantity
            // 
            this.label_Quantity.AutoSize = true;
            this.label_Quantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Quantity.Location = new System.Drawing.Point(237, 23);
            this.label_Quantity.Name = "label_Quantity";
            this.label_Quantity.Size = new System.Drawing.Size(81, 21);
            this.label_Quantity.TabIndex = 0;
            this.label_Quantity.Text = "Quantité : ";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(388, 23);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(50, 20);
            this.QuantityTB.TabIndex = 7;
            this.QuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTB_KeyPress);
            // 
            // button_less
            // 
            this.button_less.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_less.FlatAppearance.BorderSize = 0;
            this.button_less.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_less.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_less.ForeColor = System.Drawing.Color.White;
            this.button_less.Location = new System.Drawing.Point(342, 13);
            this.button_less.Name = "button_less";
            this.button_less.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.button_less.Size = new System.Drawing.Size(40, 40);
            this.button_less.TabIndex = 5;
            this.button_less.Text = "-";
            this.button_less.UseVisualStyleBackColor = false;
            this.button_less.Click += new System.EventHandler(this.button_less_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(444, 11);
            this.button_add.Name = "button_add";
            this.button_add.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.button_add.Size = new System.Drawing.Size(40, 40);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.button_remove.FlatAppearance.BorderSize = 0;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.ForeColor = System.Drawing.Color.White;
            this.button_remove.Location = new System.Drawing.Point(10, 13);
            this.button_remove.Name = "button_remove";
            this.button_remove.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button_remove.Size = new System.Drawing.Size(40, 40);
            this.button_remove.TabIndex = 4;
            this.button_remove.Text = "X";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // ElementCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.button_less);
            this.Controls.Add(this.label_Quantity);
            this.Controls.Add(this.label_unitprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_product);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_remove);
            this.Name = "ElementCart";
            this.Size = new System.Drawing.Size(835, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse button_remove;
        private ButtonEllipse button_add;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_unitprice;
        private System.Windows.Forms.Label label_Quantity;
        private ButtonEllipse button_less;
        private System.Windows.Forms.TextBox QuantityTB;
    }
}
