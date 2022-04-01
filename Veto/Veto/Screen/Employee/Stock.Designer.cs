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
            this.FilterCB = new System.Windows.Forms.ComboBox();
            this.FilterLBL = new System.Windows.Forms.Label();
            this.ResearchTB = new System.Windows.Forms.TextBox();
            this.NextBTN = new Veto.ButtonEllipse();
            this.PreviousBTN = new Veto.ButtonEllipse();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.AddProductBTN = new System.Windows.Forms.Button();
            this.AllProductsPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.CenterPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.ManagementPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPNL
            // 
            this.CenterPNL.Controls.Add(this.ManagementPNL);
            this.CenterPNL.Dock = System.Windows.Forms.DockStyle.None;
            this.CenterPNL.Location = new System.Drawing.Point(298, 0);
            this.CenterPNL.Size = new System.Drawing.Size(766, 681);
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.AddProductBTN);
            // 
            // ManagementPNL
            // 
            this.ManagementPNL.Controls.Add(this.FilterCB);
            this.ManagementPNL.Controls.Add(this.FilterLBL);
            this.ManagementPNL.Controls.Add(this.ResearchTB);
            this.ManagementPNL.Controls.Add(this.NextBTN);
            this.ManagementPNL.Controls.Add(this.PreviousBTN);
            this.ManagementPNL.Controls.Add(this.TitleLBL);
            this.ManagementPNL.Location = new System.Drawing.Point(0, 86);
            this.ManagementPNL.Name = "ManagementPNL";
            this.ManagementPNL.Size = new System.Drawing.Size(763, 169);
            this.ManagementPNL.TabIndex = 8;
            // 
            // FilterCB
            // 
            this.FilterCB.FormattingEnabled = true;
            this.FilterCB.Items.AddRange(new object[] {
            "Quantité Décroissant",
            "Quantité Croissant",
            "Nom Croissant",
            "Nom Décroissant"});
            this.FilterCB.Location = new System.Drawing.Point(536, 108);
            this.FilterCB.Name = "FilterCB";
            this.FilterCB.Size = new System.Drawing.Size(121, 21);
            this.FilterCB.TabIndex = 10;
            this.FilterCB.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // FilterLBL
            // 
            this.FilterLBL.AutoSize = true;
            this.FilterLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLBL.Location = new System.Drawing.Point(435, 108);
            this.FilterLBL.Name = "FilterLBL";
            this.FilterLBL.Size = new System.Drawing.Size(79, 21);
            this.FilterLBL.TabIndex = 21;
            this.FilterLBL.Text = "Trier par : ";
            // 
            // ResearchTB
            // 
            this.ResearchTB.Location = new System.Drawing.Point(65, 108);
            this.ResearchTB.Name = "ResearchTB";
            this.ResearchTB.Size = new System.Drawing.Size(170, 20);
            this.ResearchTB.TabIndex = 9;
            this.ResearchTB.TextChanged += new System.EventHandler(this.textBoxResearch_TextChanged);
            // 
            // NextBTN
            // 
            this.NextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextBTN.FlatAppearance.BorderSize = 0;
            this.NextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBTN.ForeColor = System.Drawing.Color.White;
            this.NextBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextBTN.Location = new System.Drawing.Point(677, 112);
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
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.Location = new System.Drawing.Point(293, 17);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(253, 37);
            this.TitleLBL.TabIndex = 17;
            this.TitleLBL.Text = "Gestion des stocks";
            // 
            // AddProductBTN
            // 
            this.AddProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddProductBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductBTN.ForeColor = System.Drawing.Color.White;
            this.AddProductBTN.Location = new System.Drawing.Point(54, 18);
            this.AddProductBTN.Name = "AddProductBTN";
            this.AddProductBTN.Size = new System.Drawing.Size(191, 23);
            this.AddProductBTN.TabIndex = 0;
            this.AddProductBTN.Text = "AJOUTER  AU CATALOGUE";
            this.AddProductBTN.UseVisualStyleBackColor = false;
            this.AddProductBTN.Click += new System.EventHandler(this.addProductBTN_Click);
            // 
            // AllProductsPNL
            // 
            this.AllProductsPNL.Location = new System.Drawing.Point(298, 253);
            this.AllProductsPNL.Name = "AllProductsPNL";
            this.AllProductsPNL.Size = new System.Drawing.Size(766, 428);
            this.AllProductsPNL.TabIndex = 9;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.AllProductsPNL);
            this.Name = "Stock";
            this.Controls.SetChildIndex(this.CenterPNL, 0);
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.AllProductsPNL, 0);
            this.CenterPNL.ResumeLayout(false);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ManagementPNL.ResumeLayout(false);
            this.ManagementPNL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManagementPNL;
        private System.Windows.Forms.Label TitleLBL;
        private ButtonEllipse PreviousBTN;
        private ButtonEllipse NextBTN;
        private System.Windows.Forms.Label FilterLBL;
        private System.Windows.Forms.TextBox ResearchTB;
        private System.Windows.Forms.ComboBox FilterCB;
        private System.Windows.Forms.Button AddProductBTN;
        private System.Windows.Forms.FlowLayoutPanel AllProductsPNL;
    }
}
