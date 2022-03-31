
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
            this.ProductLBL = new System.Windows.Forms.Label();
            this.TotalPriceLBL = new System.Windows.Forms.Label();
            this.UnitPriceLBL = new System.Windows.Forms.Label();
            this.QuantityLBL = new System.Windows.Forms.Label();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.LessBTN = new Veto.ButtonEllipse();
            this.AddBTN = new Veto.ButtonEllipse();
            this.RemoveBTN = new Veto.ButtonEllipse();
            this.SuspendLayout();
            // 
            // ProductLBL
            // 
            this.ProductLBL.AutoSize = true;
            this.ProductLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLBL.Location = new System.Drawing.Point(75, 23);
            this.ProductLBL.Name = "ProductLBL";
            this.ProductLBL.Size = new System.Drawing.Size(78, 21);
            this.ProductLBL.TabIndex = 3;
            this.ProductLBL.Text = "Produit 1 ";
            // 
            // TotalPriceLBL
            // 
            this.TotalPriceLBL.AutoSize = true;
            this.TotalPriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLBL.Location = new System.Drawing.Point(744, 23);
            this.TotalPriceLBL.Name = "TotalPriceLBL";
            this.TotalPriceLBL.Size = new System.Drawing.Size(80, 21);
            this.TotalPriceLBL.TabIndex = 2;
            this.TotalPriceLBL.Text = "Total : 30€";
            // 
            // UnitPriceLBL
            // 
            this.UnitPriceLBL.AutoSize = true;
            this.UnitPriceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLBL.Location = new System.Drawing.Point(606, 23);
            this.UnitPriceLBL.Name = "UnitPriceLBL";
            this.UnitPriceLBL.Size = new System.Drawing.Size(93, 21);
            this.UnitPriceLBL.TabIndex = 1;
            this.UnitPriceLBL.Text = "Prix /u : 15€";
            // 
            // QuantityLBL
            // 
            this.QuantityLBL.AutoSize = true;
            this.QuantityLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLBL.Location = new System.Drawing.Point(237, 23);
            this.QuantityLBL.Name = "QuantityLBL";
            this.QuantityLBL.Size = new System.Drawing.Size(81, 21);
            this.QuantityLBL.TabIndex = 0;
            this.QuantityLBL.Text = "Quantité : ";
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(388, 23);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(50, 20);
            this.QuantityTB.TabIndex = 7;
            this.QuantityTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTB_KeyPress);
            // 
            // LessBTN
            // 
            this.LessBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.LessBTN.FlatAppearance.BorderSize = 0;
            this.LessBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LessBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessBTN.ForeColor = System.Drawing.Color.White;
            this.LessBTN.Location = new System.Drawing.Point(342, 13);
            this.LessBTN.Name = "LessBTN";
            this.LessBTN.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.LessBTN.Size = new System.Drawing.Size(40, 40);
            this.LessBTN.TabIndex = 5;
            this.LessBTN.Text = "-";
            this.LessBTN.UseVisualStyleBackColor = false;
            this.LessBTN.Click += new System.EventHandler(this.button_less_Click);
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddBTN.FlatAppearance.BorderSize = 0;
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBTN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.Location = new System.Drawing.Point(444, 11);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Padding = new System.Windows.Forms.Padding(3, 0, 0, 2);
            this.AddBTN.Size = new System.Drawing.Size(40, 40);
            this.AddBTN.TabIndex = 6;
            this.AddBTN.Text = "+";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.button_add_Click);
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(9)))), ((int)(((byte)(8)))));
            this.RemoveBTN.FlatAppearance.BorderSize = 0;
            this.RemoveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBTN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBTN.ForeColor = System.Drawing.Color.White;
            this.RemoveBTN.Location = new System.Drawing.Point(10, 13);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.RemoveBTN.Size = new System.Drawing.Size(40, 40);
            this.RemoveBTN.TabIndex = 4;
            this.RemoveBTN.Text = "X";
            this.RemoveBTN.UseVisualStyleBackColor = false;
            this.RemoveBTN.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // ElementCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(218)))), ((int)(((byte)(209)))));
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.LessBTN);
            this.Controls.Add(this.QuantityLBL);
            this.Controls.Add(this.UnitPriceLBL);
            this.Controls.Add(this.TotalPriceLBL);
            this.Controls.Add(this.ProductLBL);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.RemoveBTN);
            this.Name = "ElementCart";
            this.Size = new System.Drawing.Size(835, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEllipse RemoveBTN;
        private ButtonEllipse AddBTN;
        private System.Windows.Forms.Label ProductLBL;
        private System.Windows.Forms.Label TotalPriceLBL;
        private System.Windows.Forms.Label UnitPriceLBL;
        private System.Windows.Forms.Label QuantityLBL;
        private ButtonEllipse LessBTN;
        private System.Windows.Forms.TextBox QuantityTB;
    }
}
