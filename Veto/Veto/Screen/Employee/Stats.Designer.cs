
namespace Veto
{
    partial class Stats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TitleLB = new System.Windows.Forms.Label();
            this.StatsCB = new System.Windows.Forms.ComboBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PreviousBT = new Veto.ButtonEllipse();
            this.NextBT = new Veto.ButtonEllipse();
            this.NextYearLB = new System.Windows.Forms.Label();
            this.PreviousYearLB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).BeginInit();
            this.SidePNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLB
            // 
            this.TitleLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLB.Location = new System.Drawing.Point(319, 15);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(145, 32);
            this.TitleLB.TabIndex = 8;
            this.TitleLB.Text = "Statistiques";
            this.TitleLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatsCB
            // 
            this.StatsCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatsCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(156)))), ((int)(((byte)(130)))));
            this.StatsCB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StatsCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsCB.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.StatsCB.FormattingEnabled = true;
            this.StatsCB.Items.AddRange(new object[] {
            "Ventes",
            "Nombre de Clients",
            "Nombre de Rendez-vous"});
            this.StatsCB.Location = new System.Drawing.Point(16, 24);
            this.StatsCB.Name = "StatsCB";
            this.StatsCB.Size = new System.Drawing.Size(121, 23);
            this.StatsCB.TabIndex = 9;
            // 
            // Chart
            // 
            this.Chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(16, 172);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(714, 359);
            this.Chart.TabIndex = 10;
            this.Chart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.PreviousYearLB);
            this.panel1.Controls.Add(this.NextYearLB);
            this.panel1.Controls.Add(this.NextBT);
            this.panel1.Controls.Add(this.PreviousBT);
            this.panel1.Controls.Add(this.StatsCB);
            this.panel1.Controls.Add(this.Chart);
            this.panel1.Controls.Add(this.TitleLB);
            this.panel1.Location = new System.Drawing.Point(306, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 557);
            this.panel1.TabIndex = 11;
            // 
            // PreviousBT
            // 
            this.PreviousBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.PreviousBT.FlatAppearance.BorderSize = 0;
            this.PreviousBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBT.ForeColor = System.Drawing.Color.White;
            this.PreviousBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PreviousBT.Location = new System.Drawing.Point(16, 116);
            this.PreviousBT.Name = "PreviousBT";
            this.PreviousBT.Size = new System.Drawing.Size(50, 50);
            this.PreviousBT.TabIndex = 19;
            this.PreviousBT.Text = "<";
            this.PreviousBT.UseVisualStyleBackColor = false;
            // 
            // NextBT
            // 
            this.NextBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.NextBT.FlatAppearance.BorderSize = 0;
            this.NextBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBT.ForeColor = System.Drawing.Color.White;
            this.NextBT.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextBT.Location = new System.Drawing.Point(678, 116);
            this.NextBT.Margin = new System.Windows.Forms.Padding(0);
            this.NextBT.Name = "NextBT";
            this.NextBT.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.NextBT.Size = new System.Drawing.Size(52, 52);
            this.NextBT.TabIndex = 20;
            this.NextBT.Text = ">";
            this.NextBT.UseVisualStyleBackColor = false;
            // 
            // NextYearLB
            // 
            this.NextYearLB.AutoSize = true;
            this.NextYearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextYearLB.Location = new System.Drawing.Point(623, 132);
            this.NextYearLB.Name = "NextYearLB";
            this.NextYearLB.Size = new System.Drawing.Size(52, 21);
            this.NextYearLB.TabIndex = 21;
            this.NextYearLB.Text = "label1";
            // 
            // PreviousYearLB
            // 
            this.PreviousYearLB.AutoSize = true;
            this.PreviousYearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousYearLB.Location = new System.Drawing.Point(72, 132);
            this.PreviousYearLB.Name = "PreviousYearLB";
            this.PreviousYearLB.Size = new System.Drawing.Size(52, 21);
            this.PreviousYearLB.TabIndex = 23;
            this.PreviousYearLB.Text = "label1";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel1);
            this.Name = "Stats";
            this.Controls.SetChildIndex(this.TopPNL, 0);
            this.Controls.SetChildIndex(this.SidePNL, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.SidePNL)).EndInit();
            this.SidePNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLB;
        private System.Windows.Forms.ComboBox StatsCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Panel panel1;
        private ButtonEllipse PreviousBT;
        private ButtonEllipse NextBT;
        private System.Windows.Forms.Label PreviousYearLB;
        private System.Windows.Forms.Label NextYearLB;
    }
}
