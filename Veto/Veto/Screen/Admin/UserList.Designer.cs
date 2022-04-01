
namespace Veto
{
    partial class UserList
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
            this.AddBTN = new System.Windows.Forms.Button();
            this.CenterPNL = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel2.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel2
            // 
            this.SidePNL.Panel2.Controls.Add(this.AddBTN);
            // 
            // AddBTN
            // 
            this.AddBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.AddBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.Location = new System.Drawing.Point(78, 16);
            this.AddBTN.Margin = new System.Windows.Forms.Padding(2);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(127, 41);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "AJOUTER EMPLOYÉ";
            this.AddBTN.UseVisualStyleBackColor = false;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // CenterPNL
            // 
            this.CenterPNL.AutoScroll = true;
            this.CenterPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPNL.Location = new System.Drawing.Point(300, 86);
            this.CenterPNL.Name = "CenterPNL";
            this.CenterPNL.Size = new System.Drawing.Size(764, 595);
            this.CenterPNL.TabIndex = 8;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.CenterPNL);
            this.Name = "UserList";
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.CenterPNL, 0);
            this.SidePNL.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.FlowLayoutPanel CenterPNL;
    }
}
