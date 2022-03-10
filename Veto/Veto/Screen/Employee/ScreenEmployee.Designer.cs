
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
            this.SidePNL.Size = new System.Drawing.Size(300, 595);
            this.SidePNL.SplitterDistance = 358;
            // 
            // CalendarBTN
            // 
            this.CalendarBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.CalendarBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalendarBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarBTN.ForeColor = System.Drawing.Color.White;
            this.CalendarBTN.Location = new System.Drawing.Point(33, 74);
            this.CalendarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CalendarBTN.Name = "CalendarBTN";
            this.CalendarBTN.Size = new System.Drawing.Size(143, 23);
            this.CalendarBTN.TabIndex = 8;
            this.CalendarBTN.Text = "CALENDRIER";
            this.CalendarBTN.UseVisualStyleBackColor = false;
            this.CalendarBTN.Click += new System.EventHandler(this.CalendarBTN_Click);
            // 
            // CartBTN
            // 
            this.CartBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.CartBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CartBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBTN.ForeColor = System.Drawing.Color.White;
            this.CartBTN.Location = new System.Drawing.Point(33, 209);
            this.CartBTN.Margin = new System.Windows.Forms.Padding(2);
            this.CartBTN.Name = "CartBTN";
            this.CartBTN.Size = new System.Drawing.Size(143, 23);
            this.CartBTN.TabIndex = 9;
            this.CartBTN.Text = "PANIER";
            this.CartBTN.UseVisualStyleBackColor = false;
            this.CartBTN.Click += new System.EventHandler(this.CartBTN_Click);
            // 
            // ClientsBTN
            // 
            this.ClientsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.ClientsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClientsBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsBTN.ForeColor = System.Drawing.Color.White;
            this.ClientsBTN.Location = new System.Drawing.Point(33, 164);
            this.ClientsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.ClientsBTN.Name = "ClientsBTN";
            this.ClientsBTN.Size = new System.Drawing.Size(143, 23);
            this.ClientsBTN.TabIndex = 10;
            this.ClientsBTN.Text = "CLIENTS";
            this.ClientsBTN.UseVisualStyleBackColor = false;
            this.ClientsBTN.Click += new System.EventHandler(this.ClientsBTN_Click);
            // 
            // StatsBTN
            // 
            this.StatsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.StatsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatsBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsBTN.ForeColor = System.Drawing.Color.White;
            this.StatsBTN.Location = new System.Drawing.Point(33, 254);
            this.StatsBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StatsBTN.Name = "StatsBTN";
            this.StatsBTN.Size = new System.Drawing.Size(143, 23);
            this.StatsBTN.TabIndex = 9;
            this.StatsBTN.Text = "STATISTIQUES";
            this.StatsBTN.UseVisualStyleBackColor = false;
            this.StatsBTN.Click += new System.EventHandler(this.StatsBTN_Click);
            // 
            // StocksBTN
            // 
            this.StocksBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(4)))));
            this.StocksBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StocksBTN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocksBTN.ForeColor = System.Drawing.Color.White;
            this.StocksBTN.Location = new System.Drawing.Point(33, 119);
            this.StocksBTN.Margin = new System.Windows.Forms.Padding(2);
            this.StocksBTN.Name = "StocksBTN";
            this.StocksBTN.Size = new System.Drawing.Size(143, 23);
            this.StocksBTN.TabIndex = 9;
            this.StocksBTN.Text = "STOCKS";
            this.StocksBTN.UseVisualStyleBackColor = false;
            this.StocksBTN.Click += new System.EventHandler(this.StocksBTN_Click);
            // 
            // ScreenEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "ScreenEmployee";
            this.SidePNL.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalendarBTN;
        private System.Windows.Forms.Button StocksBTN;
        private System.Windows.Forms.Button StatsBTN;
        private System.Windows.Forms.Button ClientsBTN;
        private System.Windows.Forms.Button CartBTN;
    }
}
