
namespace Veto
{
    partial class ScreenEmployee
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
            this.CalendarBTN = new System.Windows.Forms.Button();
            this.CartBTN = new System.Windows.Forms.Button();
            this.ClientsBTN = new System.Windows.Forms.Button();
            this.StatsBTN = new System.Windows.Forms.Button();
            this.StocksBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.Panel1.SuspendLayout();
            this.SidePNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePNL
            // 
            // 
            // SidePNL.Panel1
            // 
            this.SidePNL.Panel1.Controls.Add(this.StocksBTN);
            this.SidePNL.Panel1.Controls.Add(this.StatsBTN);
            this.SidePNL.Panel1.Controls.Add(this.ClientsBTN);
            this.SidePNL.Panel1.Controls.Add(this.CalendarBTN);
            this.SidePNL.Panel1.Controls.Add(this.CartBTN);
            // 
            // CalendarBTN
            // 
            this.CalendarBTN.Location = new System.Drawing.Point(70, 109);
            this.CalendarBTN.Name = "CalendarBTN";
            this.CalendarBTN.Size = new System.Drawing.Size(127, 35);
            this.CalendarBTN.TabIndex = 8;
            this.CalendarBTN.Text = "Calendrier";
            this.CalendarBTN.UseVisualStyleBackColor = true;
            // 
            // CartBTN
            // 
            this.CartBTN.Location = new System.Drawing.Point(70, 232);
            this.CartBTN.Name = "CartBTN";
            this.CartBTN.Size = new System.Drawing.Size(127, 35);
            this.CartBTN.TabIndex = 9;
            this.CartBTN.Text = "Panier";
            this.CartBTN.UseVisualStyleBackColor = true;
            // 
            // ClientsBTN
            // 
            this.ClientsBTN.Location = new System.Drawing.Point(70, 150);
            this.ClientsBTN.Name = "ClientsBTN";
            this.ClientsBTN.Size = new System.Drawing.Size(127, 35);
            this.ClientsBTN.TabIndex = 10;
            this.ClientsBTN.Text = "Clients";
            this.ClientsBTN.UseVisualStyleBackColor = true;
            // 
            // StatsBTN
            // 
            this.StatsBTN.Location = new System.Drawing.Point(70, 273);
            this.StatsBTN.Name = "StatsBTN";
            this.StatsBTN.Size = new System.Drawing.Size(127, 35);
            this.StatsBTN.TabIndex = 9;
            this.StatsBTN.Text = "Statistiques";
            this.StatsBTN.UseVisualStyleBackColor = true;
            // 
            // StocksBTN
            // 
            this.StocksBTN.Location = new System.Drawing.Point(70, 191);
            this.StocksBTN.Name = "StocksBTN";
            this.StocksBTN.Size = new System.Drawing.Size(127, 35);
            this.StocksBTN.TabIndex = 9;
            this.StocksBTN.Text = "Stocks";
            this.StocksBTN.UseVisualStyleBackColor = true;
            // 
            // ScreenEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1419, 838);
            this.Name = "ScreenEmployee";
            this.SidePNL.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalendarBTN;
        private System.Windows.Forms.Button StocksBTN;
        private System.Windows.Forms.Button StatsBTN;
        private System.Windows.Forms.Button ClientsBTN;
        private System.Windows.Forms.Button CartBTN;
    }
}
