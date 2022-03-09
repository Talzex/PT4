
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
            this.CenterPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBTN = new System.Windows.Forms.Button();
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
            // CenterPNL
            // 
            this.CenterPNL.AutoScroll = true;
            this.CenterPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPNL.Location = new System.Drawing.Point(347, 86);
            this.CenterPNL.Name = "CenterPNL";
            this.CenterPNL.Size = new System.Drawing.Size(1072, 752);
            this.CenterPNL.TabIndex = 5;
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(104, 20);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(169, 50);
            this.AddBTN.TabIndex = 0;
            this.AddBTN.Text = "Ajouter Employé";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1419, 838);
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

        private System.Windows.Forms.FlowLayoutPanel CenterPNL;
        private System.Windows.Forms.Button AddBTN;
    }
}
