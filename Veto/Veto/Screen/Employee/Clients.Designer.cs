
namespace Veto
{
    partial class Clients
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
            this.TitleLBL = new System.Windows.Forms.Label();
            this.PrevPageBTN = new Veto.ButtonEllipse();
            this.NextPageBTN = new Veto.ButtonEllipse();
            this.ItemsPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.CenterPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CenterPNL
            // 
            this.CenterPNL.Controls.Add(this.ItemsPNL);
            this.CenterPNL.Controls.Add(this.panel1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLBL);
            this.panel1.Controls.Add(this.PrevPageBTN);
            this.panel1.Controls.Add(this.NextPageBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 100);
            this.panel1.TabIndex = 0;
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.TitleLBL.Location = new System.Drawing.Point(265, 33);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(207, 37);
            this.TitleLBL.TabIndex = 2;
            this.TitleLBL.Text = "Tout les clients";
            // 
            // PrevPageBTN
            // 
            this.PrevPageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.PrevPageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevPageBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.PrevPageBTN.ForeColor = System.Drawing.Color.White;
            this.PrevPageBTN.Location = new System.Drawing.Point(16, 33);
            this.PrevPageBTN.Name = "PrevPageBTN";
            this.PrevPageBTN.Size = new System.Drawing.Size(50, 50);
            this.PrevPageBTN.TabIndex = 1;
            this.PrevPageBTN.Text = "<";
            this.PrevPageBTN.UseVisualStyleBackColor = false;
            this.PrevPageBTN.Click += new System.EventHandler(this.PrevPageBTN_Click);
            // 
            // NextPageBTN
            // 
            this.NextPageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextPageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.NextPageBTN.ForeColor = System.Drawing.Color.White;
            this.NextPageBTN.Location = new System.Drawing.Point(696, 33);
            this.NextPageBTN.Name = "NextPageBTN";
            this.NextPageBTN.Size = new System.Drawing.Size(50, 50);
            this.NextPageBTN.TabIndex = 0;
            this.NextPageBTN.Text = ">";
            this.NextPageBTN.UseVisualStyleBackColor = false;
            this.NextPageBTN.Click += new System.EventHandler(this.NextPageBTN_Click);
            // 
            // ItemsPNL
            // 
            this.ItemsPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPNL.Location = new System.Drawing.Point(0, 100);
            this.ItemsPNL.Name = "ItemsPNL";
            this.ItemsPNL.Size = new System.Drawing.Size(764, 495);
            this.ItemsPNL.TabIndex = 1;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Name = "Clients";
            this.Activated += new System.EventHandler(this.Clients_Activated);
            this.CenterPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonEllipse PrevPageBTN;
        private ButtonEllipse NextPageBTN;
        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.FlowLayoutPanel ItemsPNL;
    }
}
