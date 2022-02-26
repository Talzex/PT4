
namespace Veto
{
    partial class ScreenAdmin
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
            this.AddUserBTN = new System.Windows.Forms.Button();
            this.LogsBTN = new System.Windows.Forms.Button();
            this.SidePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            this.SidePNL.Controls.Add(this.LogsBTN);
            this.SidePNL.Controls.Add(this.AddUserBTN);
            // 
            // AddUserBTN
            // 
            this.AddUserBTN.Location = new System.Drawing.Point(56, 29);
            this.AddUserBTN.Name = "AddUserBTN";
            this.AddUserBTN.Size = new System.Drawing.Size(141, 32);
            this.AddUserBTN.TabIndex = 6;
            this.AddUserBTN.Text = "Ajouter";
            this.AddUserBTN.UseVisualStyleBackColor = true;
            // 
            // LogsBTN
            // 
            this.LogsBTN.Location = new System.Drawing.Point(56, 96);
            this.LogsBTN.Name = "LogsBTN";
            this.LogsBTN.Size = new System.Drawing.Size(141, 32);
            this.LogsBTN.TabIndex = 7;
            this.LogsBTN.Text = "Logs";
            this.LogsBTN.UseVisualStyleBackColor = true;
            // 
            // ScreenAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Name = "ScreenAdmin";
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserBTN;
        private System.Windows.Forms.Button LogsBTN;
    }
}
