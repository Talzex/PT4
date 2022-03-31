
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
            this.ValidateBTN = new System.Windows.Forms.Button();
            this.BillBTN = new System.Windows.Forms.Button();
            this.EmptyBTN = new System.Windows.Forms.Button();
            this.TotalLBL = new System.Windows.Forms.Label();
            this.CustomerLBL = new System.Windows.Forms.Label();
            this.LoginBTN = new System.Windows.Forms.Button();
            this.label_cart = new System.Windows.Forms.Label();
            this.panel_bottombill = new System.Windows.Forms.Panel();
            this.PrinterCB = new System.Windows.Forms.ComboBox();
            this.ClientsCB = new System.Windows.Forms.ComboBox();
            this.panel_title = new System.Windows.Forms.Panel();
            this.NextBTN = new Veto.ButtonEllipse();
            this.PreviousBTN = new Veto.ButtonEllipse();
            this.Panel_AllProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.button_addconsultation = new System.Windows.Forms.Button();
            this.button_addoperation = new System.Windows.Forms.Button();
            this.button_addnight = new System.Windows.Forms.Button();
            this.CenterPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.panel_bottombill.SuspendLayout();
            this.panel_title.SuspendLayout();
            this.Panel_AllProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPNL
            // 
            this.CenterPNL.Controls.Add(this.Panel_AllProducts);
            this.CenterPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.CenterPNL.Location = new System.Drawing.Point(225, 86);
            this.CenterPNL.Size = new System.Drawing.Size(839, 595);
            // 
            // SidePNL
            // 
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
            // ValidateBTN
            // 
            this.ValidateBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ValidateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ValidateBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBTN.ForeColor = System.Drawing.Color.White;
            this.ValidateBTN.Location = new System.Drawing.Point(17, 183);
            this.ValidateBTN.Name = "ValidateBTN";
            this.ValidateBTN.Size = new System.Drawing.Size(143, 23);
            this.ValidateBTN.TabIndex = 8;
            this.ValidateBTN.Text = "VALIDER";
            this.ValidateBTN.UseVisualStyleBackColor = false;
            this.ValidateBTN.Click += new System.EventHandler(this.button_validate_Click);
            // 
            // BillBTN
            // 
            this.BillBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.BillBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BillBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillBTN.ForeColor = System.Drawing.Color.White;
            this.BillBTN.Location = new System.Drawing.Point(166, 183);
            this.BillBTN.Name = "BillBTN";
            this.BillBTN.Size = new System.Drawing.Size(143, 23);
            this.BillBTN.TabIndex = 9;
            this.BillBTN.Text = "IMPRIMER FACTURE";
            this.BillBTN.UseVisualStyleBackColor = false;
            this.BillBTN.Click += new System.EventHandler(this.button_bill_Click);
            // 
            // EmptyBTN
            // 
            this.EmptyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.EmptyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmptyBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmptyBTN.ForeColor = System.Drawing.Color.White;
            this.EmptyBTN.Location = new System.Drawing.Point(682, 183);
            this.EmptyBTN.Name = "EmptyBTN";
            this.EmptyBTN.Size = new System.Drawing.Size(143, 23);
            this.EmptyBTN.TabIndex = 10;
            this.EmptyBTN.Text = "VIDER";
            this.EmptyBTN.UseVisualStyleBackColor = false;
            this.EmptyBTN.Click += new System.EventHandler(this.button_empty_Click);
            // 
            // TotalLBL
            // 
            this.TotalLBL.AutoSize = true;
            this.TotalLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLBL.Location = new System.Drawing.Point(13, 91);
            this.TotalLBL.Name = "TotalLBL";
            this.TotalLBL.Size = new System.Drawing.Size(56, 21);
            this.TotalLBL.TabIndex = 12;
            this.TotalLBL.Text = "Total :";
            // 
            // CustomerLBL
            // 
            this.CustomerLBL.AutoSize = true;
            this.CustomerLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLBL.Location = new System.Drawing.Point(13, 12);
            this.CustomerLBL.Name = "CustomerLBL";
            this.CustomerLBL.Size = new System.Drawing.Size(95, 21);
            this.CustomerLBL.TabIndex = 13;
            this.CustomerLBL.Text = "Aucun client";
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(97)))), ((int)(((byte)(50)))));
            this.LoginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.White;
            this.LoginBTN.Location = new System.Drawing.Point(268, 12);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(123, 23);
            this.LoginBTN.TabIndex = 14;
            this.LoginBTN.Text = "IDENTIFIER";
            this.LoginBTN.UseVisualStyleBackColor = false;
            this.LoginBTN.Click += new System.EventHandler(this.button_login_Click);
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
            this.panel_bottombill.Controls.Add(this.PrinterCB);
            this.panel_bottombill.Controls.Add(this.ClientsCB);
            this.panel_bottombill.Controls.Add(this.CustomerLBL);
            this.panel_bottombill.Controls.Add(this.LoginBTN);
            this.panel_bottombill.Controls.Add(this.EmptyBTN);
            this.panel_bottombill.Controls.Add(this.BillBTN);
            this.panel_bottombill.Controls.Add(this.TotalLBL);
            this.panel_bottombill.Controls.Add(this.ValidateBTN);
            this.panel_bottombill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottombill.Location = new System.Drawing.Point(225, 438);
            this.panel_bottombill.Name = "panel_bottombill";
            this.panel_bottombill.Size = new System.Drawing.Size(839, 219);
            this.panel_bottombill.TabIndex = 11;
            // 
            // PrinterCB
            // 
            this.PrinterCB.FormattingEnabled = true;
            this.PrinterCB.Location = new System.Drawing.Point(315, 185);
            this.PrinterCB.Name = "PrinterCB";
            this.PrinterCB.Size = new System.Drawing.Size(121, 21);
            this.PrinterCB.TabIndex = 17;
            // 
            // ClientsCB
            // 
            this.ClientsCB.FormattingEnabled = true;
            this.ClientsCB.Location = new System.Drawing.Point(10, 37);
            this.ClientsCB.Name = "ClientsCB";
            this.ClientsCB.Size = new System.Drawing.Size(121, 21);
            this.ClientsCB.TabIndex = 16;
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.NextBTN);
            this.panel_title.Controls.Add(this.PreviousBTN);
            this.panel_title.Controls.Add(this.label_cart);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(3, 3);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(839, 155);
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
            this.Panel_AllProducts.AutoScroll = true;
            this.Panel_AllProducts.Controls.Add(this.panel_title);
            this.Panel_AllProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AllProducts.Location = new System.Drawing.Point(0, 0);
            this.Panel_AllProducts.Name = "Panel_AllProducts";
            this.Panel_AllProducts.Size = new System.Drawing.Size(839, 595);
            this.Panel_AllProducts.TabIndex = 18;
            // 
            // button_addconsultation
            // 
            this.button_addconsultation.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_addconsultation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button_addconsultation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addconsultation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addconsultation.ForeColor = System.Drawing.Color.White;
            this.button_addconsultation.Location = new System.Drawing.Point(12, 19);
            this.button_addconsultation.Name = "button_addconsultation";
            this.button_addconsultation.Size = new System.Drawing.Size(191, 23);
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
            this.button_addoperation.Location = new System.Drawing.Point(12, 48);
            this.button_addoperation.Name = "button_addoperation";
            this.button_addoperation.Size = new System.Drawing.Size(191, 23);
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
            this.button_addnight.Location = new System.Drawing.Point(12, 77);
            this.button_addnight.Name = "button_addnight";
            this.button_addnight.Size = new System.Drawing.Size(191, 23);
            this.button_addnight.TabIndex = 3;
            this.button_addnight.Text = "AJOUTER NUIT";
            this.button_addnight.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 657);
            this.Controls.Add(this.panel_bottombill);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cart";
            this.Activated += new System.EventHandler(this.Cart_Activated);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.CenterPNL, 0);
            this.Controls.SetChildIndex(this.panel_bottombill, 0);
            this.CenterPNL.ResumeLayout(false);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel_bottombill.ResumeLayout(false);
            this.panel_bottombill.PerformLayout();
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.Panel_AllProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValidateBTN;
        private System.Windows.Forms.Button BillBTN;
        private System.Windows.Forms.Button EmptyBTN;
        private System.Windows.Forms.Label TotalLBL;
        private System.Windows.Forms.Label CustomerLBL;
        private System.Windows.Forms.Button LoginBTN;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.Panel panel_bottombill;
        private System.Windows.Forms.Panel panel_title;
        private ButtonEllipse PreviousBTN;
        private ButtonEllipse NextBTN;
        private System.Windows.Forms.FlowLayoutPanel Panel_AllProducts;
        private System.Windows.Forms.Button button_addnight;
        private System.Windows.Forms.Button button_addoperation;
        private System.Windows.Forms.Button button_addconsultation;
        private System.Windows.Forms.ComboBox ClientsCB;
        private System.Windows.Forms.ComboBox PrinterCB;
    }
}
