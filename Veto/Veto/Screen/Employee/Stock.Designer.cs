﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResearch = new System.Windows.Forms.TextBox();
            this.buttonEllipse1 = new Veto.ButtonEllipse();
            this.buttonEllipse_previous = new Veto.ButtonEllipse();
            this.label_stock = new System.Windows.Forms.Label();
            this.addProductBTN = new System.Windows.Forms.Button();
            this.all_productsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.addProductBTN);
            this.SidePNL.Size = new System.Drawing.Size(229, 595);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxResearch);
            this.panel1.Controls.Add(this.buttonEllipse1);
            this.panel1.Controls.Add(this.buttonEllipse_previous);
            this.panel1.Controls.Add(this.label_stock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(229, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 169);
            this.panel1.TabIndex = 8;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Quantité Décroissant",
            "Quantité Croissant",
            "Nom Croissant",
            "Nom Décroissant"});
            this.comboBoxFilter.Location = new System.Drawing.Point(646, 107);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter.TabIndex = 10;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 104);
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
            // buttonEllipse1
            // 
            this.buttonEllipse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.buttonEllipse1.FlatAppearance.BorderSize = 0;
            this.buttonEllipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse1.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEllipse1.Location = new System.Drawing.Point(773, 112);
            this.buttonEllipse1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEllipse1.Name = "buttonEllipse1";
            this.buttonEllipse1.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.buttonEllipse1.Size = new System.Drawing.Size(52, 52);
            this.buttonEllipse1.TabIndex = 20;
            this.buttonEllipse1.Text = ">";
            this.buttonEllipse1.UseVisualStyleBackColor = false;
            // 
            // buttonEllipse_previous
            // 
            this.buttonEllipse_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.buttonEllipse_previous.FlatAppearance.BorderSize = 0;
            this.buttonEllipse_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEllipse_previous.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipse_previous.ForeColor = System.Drawing.Color.White;
            this.buttonEllipse_previous.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEllipse_previous.Location = new System.Drawing.Point(9, 113);
            this.buttonEllipse_previous.Name = "buttonEllipse_previous";
            this.buttonEllipse_previous.Size = new System.Drawing.Size(50, 50);
            this.buttonEllipse_previous.TabIndex = 19;
            this.buttonEllipse_previous.Text = "<";
            this.buttonEllipse_previous.UseVisualStyleBackColor = false;
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
            // all_productsPanel
            // 
            this.all_productsPanel.Location = new System.Drawing.Point(229, 255);
            this.all_productsPanel.Name = "all_productsPanel";
            this.all_productsPanel.Size = new System.Drawing.Size(835, 426);
            this.all_productsPanel.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.all_productsPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Stock";
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.all_productsPanel, 0);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_stock;
        private ButtonEllipse buttonEllipse_previous;
        private ButtonEllipse buttonEllipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button addProductBTN;
        private System.Windows.Forms.FlowLayoutPanel all_productsPanel;
    }
}
