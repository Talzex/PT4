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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NextBTN = new Veto.ButtonEllipse();
            this.PreviousBTN = new Veto.ButtonEllipse();
            this.label_stock = new System.Windows.Forms.Label();
            this.panel_Allproducts = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            this.SidePNL.SplitterDistance = 440;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.NextBTN);
            this.panel1.Controls.Add(this.PreviousBTN);
            this.panel1.Controls.Add(this.label_stock);
            this.panel1.Location = new System.Drawing.Point(385, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 169);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 9;
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
            // panel_Allproducts
            // 
            this.panel_Allproducts.Location = new System.Drawing.Point(1033, 471);
            this.panel_Allproducts.Name = "panel_Allproducts";
            this.panel_Allproducts.Size = new System.Drawing.Size(816, 419);
            this.panel_Allproducts.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Allproducts);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Stock";
            this.Activated += new System.EventHandler(this.Stock_Activated);
            this.Controls.SetChildIndex(this.panel_Allproducts, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_stock;
        private ButtonEllipse PreviousBTN;
        private ButtonEllipse NextBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Panel panel_Allproducts;
    }
}
