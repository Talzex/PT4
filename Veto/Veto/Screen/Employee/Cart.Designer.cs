
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
            this.panel_title = new System.Windows.Forms.Panel();
            this.NextBTN = new Veto.ButtonEllipse();
            this.PreviousBTN = new Veto.ButtonEllipse();
            this.Panel_AllProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.button_addconsultation = new System.Windows.Forms.Button();
            this.button_addoperation = new System.Windows.Forms.Button();
            this.button_addnight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.panel_bottombill.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            this.SidePNL.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.button_addnight);
            this.SidePNL.Panel2.Controls.Add(this.button_addoperation);
            this.SidePNL.Panel2.Controls.Add(this.button_addconsultation);
            this.SidePNL.Size = new System.Drawing.Size(225, 571);
            this.SidePNL.SplitterDistance = 298;
            this.SidePNL.SplitterWidth = 6;
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
            this.panel_bottombill.Location = new System.Drawing.Point(230, 426);
            this.panel_bottombill.Name = "panel_bottombill";
            this.panel_bottombill.Size = new System.Drawing.Size(838, 219);
            this.panel_bottombill.TabIndex = 11;
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.NextBTN);
            this.panel_title.Controls.Add(this.PreviousBTN);
            this.panel_title.Controls.Add(this.label_cart);
            this.panel_title.Location = new System.Drawing.Point(230, 75);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(838, 58);
            this.panel_title.TabIndex = 17;
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextBTN.FlatAppearance.BorderSize = 0;
            this.NextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.ForeColor = System.Drawing.Color.White;
            this.NextBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextBTN.Location = new System.Drawing.Point(770, 3);
            this.NextBTN.Margin = new System.Windows.Forms.Padding(0);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.NextBTN.Size = new System.Drawing.Size(52, 52);
            this.NextBTN.TabIndex = 19;
            this.NextBTN.Text = ">";
            this.NextBTN.UseVisualStyleBackColor = false;
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.PreviousBTN.FlatAppearance.BorderSize = 0;
            this.PreviousBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBTN.ForeColor = System.Drawing.Color.White;
            this.PreviousBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviousBTN.Location = new System.Drawing.Point(3, 5);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(50, 50);
            this.PreviousBTN.TabIndex = 18;
            this.PreviousBTN.Text = "<";
            this.PreviousBTN.UseVisualStyleBackColor = false;
            // 
            // Panel_AllProducts
            // 
            this.Panel_AllProducts.Location = new System.Drawing.Point(230, 139);
            this.Panel_AllProducts.Name = "Panel_AllProducts";
            this.Panel_AllProducts.Size = new System.Drawing.Size(838, 281);
            this.Panel_AllProducts.TabIndex = 18;
            // 
            // button_addconsultation
            // 
            this.button_addconsultation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_addconsultation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_addconsultation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addconsultation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addconsultation.ForeColor = System.Drawing.Color.White;
            this.button_addconsultation.Location = new System.Drawing.Point(35, 3);
            this.button_addconsultation.Name = "button_addconsultation";
            this.button_addconsultation.Size = new System.Drawing.Size(152, 23);
            this.button_addconsultation.TabIndex = 1;
            this.button_addconsultation.Text = "AJOUTER CONSULTATION";
            this.button_addconsultation.UseVisualStyleBackColor = false;
            // 
            // button_addoperation
            // 
            this.button_addoperation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_addoperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_addoperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addoperation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addoperation.ForeColor = System.Drawing.Color.White;
            this.button_addoperation.Location = new System.Drawing.Point(35, 32);
            this.button_addoperation.Name = "button_addoperation";
            this.button_addoperation.Size = new System.Drawing.Size(152, 23);
            this.button_addoperation.TabIndex = 2;
            this.button_addoperation.Text = "AJOUTER OPÉRATION";
            this.button_addoperation.UseVisualStyleBackColor = false;
            // 
            // button_addnight
            // 
            this.button_addnight.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_addnight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_addnight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addnight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addnight.ForeColor = System.Drawing.Color.White;
            this.button_addnight.Location = new System.Drawing.Point(35, 61);
            this.button_addnight.Name = "button_addnight";
            this.button_addnight.Size = new System.Drawing.Size(152, 23);
            this.button_addnight.TabIndex = 3;
            this.button_addnight.Text = "AJOUTER NUIT";
            this.button_addnight.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 657);
            this.Controls.Add(this.Panel_AllProducts);
            this.Controls.Add(this.panel_title);
            this.Controls.Add(this.panel_bottombill);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cart";
            this.Activated += new System.EventHandler(this.Cart_Activated);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.panel_bottombill, 0);
            this.Controls.SetChildIndex(this.panel_title, 0);
            this.Controls.SetChildIndex(this.Panel_AllProducts, 0);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel_bottombill.ResumeLayout(false);
            this.panel_bottombill.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_title;
        private ButtonEllipse PreviousBTN;
        private ButtonEllipse NextBTN;
        private System.Windows.Forms.FlowLayoutPanel Panel_AllProducts;
        private System.Windows.Forms.Button button_addnight;
        private System.Windows.Forms.Button button_addoperation;
        private System.Windows.Forms.Button button_addconsultation;
    }
}
