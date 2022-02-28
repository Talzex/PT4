
namespace Veto
{
    partial class Cart
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_validate = new System.Windows.Forms.Button();
            this.button_bill = new System.Windows.Forms.Button();
            this.button_empty = new System.Windows.Forms.Button();
            this.label_discount = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_signin = new System.Windows.Forms.Button();
            this.label_cart = new System.Windows.Forms.Label();
            this.panel_bottombill = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEllipse_previous = new Veto.ButtonEllipse();
            this.buttonEllipse1 = new Veto.ButtonEllipse();
            this.Panel_AllProducts = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            this.panel_bottombill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            this.SidePNL.Size = new System.Drawing.Size(225, 657);
            this.SidePNL.SplitterDistance = 345;
            // 
            // button_validate
            // 
            this.button_validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_validate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_validate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_validate.ForeColor = System.Drawing.Color.White;
            this.button_validate.Location = new System.Drawing.Point(17, 183);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(143, 23);
            this.button_validate.TabIndex = 8;
            this.button_validate.Text = "VALIDER";
            this.button_validate.UseVisualStyleBackColor = false;
            // 
            // button_bill
            // 
            this.button_bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_bill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_bill.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bill.ForeColor = System.Drawing.Color.White;
            this.button_bill.Location = new System.Drawing.Point(166, 183);
            this.button_bill.Name = "button_bill";
            this.button_bill.Size = new System.Drawing.Size(143, 23);
            this.button_bill.TabIndex = 9;
            this.button_bill.Text = "IMPRIMER FACTURE";
            this.button_bill.UseVisualStyleBackColor = false;
            // 
            // button_empty
            // 
            this.button_empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.button_empty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_empty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empty.ForeColor = System.Drawing.Color.White;
            this.button_empty.Location = new System.Drawing.Point(682, 183);
            this.button_empty.Name = "button_empty";
            this.button_empty.Size = new System.Drawing.Size(143, 23);
            this.button_empty.TabIndex = 10;
            this.button_empty.Text = "VIDER";
            this.button_empty.UseVisualStyleBackColor = false;
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_discount.Location = new System.Drawing.Point(13, 123);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(78, 21);
            this.label_discount.TabIndex = 11;
            this.label_discount.Text = "Remise : -";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(13, 91);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(118, 21);
            this.label_total.TabIndex = 12;
            this.label_total.Text = "Total : 120.95€";
            // 
            // label_customer
            // 
            this.label_customer.AutoSize = true;
            this.label_customer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.Location = new System.Drawing.Point(13, 13);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(91, 21);
            this.label_customer.TabIndex = 13;
            this.label_customer.Text = "Client : xxx1";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(110, 14);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(123, 23);
            this.button_login.TabIndex = 14;
            this.button_login.Text = "IDENTIFIER";
            this.button_login.UseVisualStyleBackColor = false;
            // 
            // button_signin
            // 
            this.button_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            this.button_signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_signin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signin.ForeColor = System.Drawing.Color.White;
            this.button_signin.Location = new System.Drawing.Point(239, 14);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(123, 23);
            this.button_signin.TabIndex = 15;
            this.button_signin.Text = "CREER UN COMPTE";
            this.button_signin.UseVisualStyleBackColor = false;
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cart.Location = new System.Drawing.Point(322, 5);
            this.label_cart.Name = "label_cart";
            this.label_cart.Size = new System.Drawing.Size(212, 37);
            this.label_cart.TabIndex = 16;
            this.label_cart.Text = "Panier en cours";
            // 
            // panel_bottombill
            // 
            this.panel_bottombill.Controls.Add(this.label_customer);
            this.panel_bottombill.Controls.Add(this.button_login);
            this.panel_bottombill.Controls.Add(this.button_empty);
            this.panel_bottombill.Controls.Add(this.label_discount);
            this.panel_bottombill.Controls.Add(this.button_bill);
            this.panel_bottombill.Controls.Add(this.label_total);
            this.panel_bottombill.Controls.Add(this.button_validate);
            this.panel_bottombill.Controls.Add(this.button_signin);
            this.panel_bottombill.Location = new System.Drawing.Point(230, 460);
            this.panel_bottombill.Name = "panel_bottombill";
            this.panel_bottombill.Size = new System.Drawing.Size(838, 221);
            this.panel_bottombill.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEllipse1);
            this.panel1.Controls.Add(this.buttonEllipse_previous);
            this.panel1.Controls.Add(this.label_cart);
            this.panel1.Location = new System.Drawing.Point(230, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 58);
            this.panel1.TabIndex = 17;
            // 
            // buttonEllipse_previous
            // 
            this.buttonEllipse_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.buttonEllipse_previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEllipse_previous.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse_previous.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse_previous.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEllipse_previous.Location = new System.Drawing.Point(3, 5);
            this.buttonEllipse_previous.Name = "buttonEllipse_previous";
            this.buttonEllipse_previous.Size = new System.Drawing.Size(50, 50);
            this.buttonEllipse_previous.TabIndex = 18;
            this.buttonEllipse_previous.Text = "<";
            this.buttonEllipse_previous.UseVisualStyleBackColor = false;
            // 
            // buttonEllipse1
            // 
            this.buttonEllipse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.buttonEllipse1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEllipse1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse1.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEllipse1.Location = new System.Drawing.Point(762, 5);
            this.buttonEllipse1.Name = "buttonEllipse1";
            this.buttonEllipse1.Size = new System.Drawing.Size(50, 50);
            this.buttonEllipse1.TabIndex = 19;
            this.buttonEllipse1.Text = ">";
            this.buttonEllipse1.UseVisualStyleBackColor = false;
            // 
            // Panel_AllProducts
            // 
            this.Panel_AllProducts.Location = new System.Drawing.Point(230, 139);
            this.Panel_AllProducts.Name = "Panel_AllProducts";
            this.Panel_AllProducts.Size = new System.Drawing.Size(825, 315);
            this.Panel_AllProducts.TabIndex = 18;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 657);
            this.Controls.Add(this.Panel_AllProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_bottombill);
            this.Name = "Cart";
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.panel_bottombill, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.Panel_AllProducts, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel_bottombill.ResumeLayout(false);
            this.panel_bottombill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_bill;
        private System.Windows.Forms.Button button_empty;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.Panel panel_bottombill;
        private System.Windows.Forms.Panel panel1;
        private ButtonEllipse buttonEllipse_previous;
        private ButtonEllipse buttonEllipse1;
        private System.Windows.Forms.FlowLayoutPanel Panel_AllProducts;
    }
}
