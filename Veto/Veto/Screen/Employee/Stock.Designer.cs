namespace Veto
{
    partial class Stock
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
            this.ManagementPNL = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResearch = new System.Windows.Forms.TextBox();
            this.NextBTN = new Veto.ButtonEllipse();
            this.PreviousBTN = new Veto.ButtonEllipse();
            this.label_stock = new System.Windows.Forms.Label();
            this.addProductBTN = new System.Windows.Forms.Button();
            this.panel_Allproducts = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.ManagementPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPNL
            // 
            this.CenterPNL.Location = new System.Drawing.Point(0, 0);
            this.CenterPNL.Size = new System.Drawing.Size(1064, 681);
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.addProductBTN);
            this.SidePNL.Size = new System.Drawing.Size(229, 595);
            // 
            // ManagementPNL
            // 
            this.ManagementPNL.Controls.Add(this.comboBoxFilter);
            this.ManagementPNL.Controls.Add(this.label1);
            this.ManagementPNL.Controls.Add(this.textBoxResearch);
            this.ManagementPNL.Controls.Add(this.NextBTN);
            this.ManagementPNL.Controls.Add(this.PreviousBTN);
            this.ManagementPNL.Controls.Add(this.label_stock);
            this.ManagementPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManagementPNL.Location = new System.Drawing.Point(229, 86);
            this.ManagementPNL.Name = "ManagementPNL";
            this.ManagementPNL.Size = new System.Drawing.Size(835, 169);
            this.ManagementPNL.TabIndex = 8;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Quantité Décroissant",
            "Quantité Croissant",
            "Nom Croissant",
            "Nom Décroissant"});
            this.comboBoxFilter.Location = new System.Drawing.Point(632, 108);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 10;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Trier par : ";
            // 
            // textBoxResearch
            // 
            this.textBoxResearch.Location = new System.Drawing.Point(65, 108);
            this.textBoxResearch.Name = "textBoxResearch";
            this.textBoxResearch.Size = new System.Drawing.Size(170, 20);
            this.textBoxResearch.TabIndex = 9;
            this.textBoxResearch.TextChanged += new System.EventHandler(this.textBoxResearch_TextChanged);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextBTN.FlatAppearance.BorderSize = 0;
            this.NextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.ForeColor = System.Drawing.Color.White;
            this.NextBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextBTN.Location = new System.Drawing.Point(773, 112);
            this.NextBTN.Margin = new System.Windows.Forms.Padding(0);
            this.NextBTN.Name = "NextBTN";
            this.NextBTN.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.NextBTN.Size = new System.Drawing.Size(52, 52);
            this.NextBTN.TabIndex = 20;
            this.NextBTN.Text = ">";
            this.NextBTN.UseVisualStyleBackColor = false;
            this.NextBTN.Click += new System.EventHandler(this.NextBTN_Click);
            // 
            // PreviousBTN
            // 
            this.PreviousBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.PreviousBTN.FlatAppearance.BorderSize = 0;
            this.PreviousBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBTN.ForeColor = System.Drawing.Color.White;
            this.PreviousBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviousBTN.Location = new System.Drawing.Point(9, 113);
            this.PreviousBTN.Name = "PreviousBTN";
            this.PreviousBTN.Size = new System.Drawing.Size(50, 50);
            this.PreviousBTN.TabIndex = 19;
            this.PreviousBTN.Text = "<";
            this.PreviousBTN.UseVisualStyleBackColor = false;
            this.PreviousBTN.Click += new System.EventHandler(this.PreviousBTN_Click);
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stock.Location = new System.Drawing.Point(293, 17);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(253, 37);
            this.label_stock.TabIndex = 17;
            this.label_stock.Text = "Gestion des stocks";
            // 
            // addProductBTN
            // 
            this.addProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.addProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductBTN.ForeColor = System.Drawing.Color.White;
            this.addProductBTN.Location = new System.Drawing.Point(33, 15);
            this.addProductBTN.Name = "addProductBTN";
            this.addProductBTN.Size = new System.Drawing.Size(155, 23);
            this.addProductBTN.TabIndex = 0;
            this.addProductBTN.Text = "AJOUTER  AU CATALOGUE";
            this.addProductBTN.UseVisualStyleBackColor = false;
            this.addProductBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // panel_Allproducts
            // 
            this.panel_Allproducts.Location = new System.Drawing.Point(229, 255);
            this.panel_Allproducts.Name = "panel_Allproducts";
            this.panel_Allproducts.Size = new System.Drawing.Size(835, 426);
            this.panel_Allproducts.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel_Allproducts);
            this.Controls.Add(this.ManagementPNL);
            this.Name = "Stock";
            this.Controls.SetChildIndex(this.CenterPNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.ManagementPNL, 0);
            this.Controls.SetChildIndex(this.panel_Allproducts, 0);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ManagementPNL.ResumeLayout(false);
            this.ManagementPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagementPNL;
        private System.Windows.Forms.Label label_stock;
        private ButtonEllipse PreviousBTN;
        private ButtonEllipse NextBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button addProductBTN;
        private System.Windows.Forms.FlowLayoutPanel panel_Allproducts;
    }
}
