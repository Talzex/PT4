
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
            this.buttonEllipse1 = new Veto.ButtonEllipse();
            this.buttonEllipse_previous = new Veto.ButtonEllipse();
            this.label_stock = new System.Windows.Forms.Label();
            this.panel_Allproducts = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.SidePNL.Panel2.Controls.Add(this.button1);
            this.SidePNL.Size = new System.Drawing.Size(229, 595);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
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
            // panel_Allproducts
            // 
            this.panel_Allproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Allproducts.Location = new System.Drawing.Point(229, 255);
            this.panel_Allproducts.Name = "panel_Allproducts";
            this.panel_Allproducts.Size = new System.Drawing.Size(835, 426);
            this.panel_Allproducts.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(33, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "AJOUTER  AU CATALOGUE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel_Allproducts);
            this.Controls.Add(this.panel1);
            this.Name = "Stock";
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel_Allproducts, 0);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Panel panel_Allproducts;
        private System.Windows.Forms.Button button1;
    }
}
