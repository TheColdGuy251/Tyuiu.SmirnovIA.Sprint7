namespace Tyuiu.SmirnovIA.Sprint7.Project.V14
{
    partial class FormRoute_SIA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxStats_SIA = new System.Windows.Forms.GroupBox();
            this.chartStats_SIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelVehicleAmount_SIA = new System.Windows.Forms.Label();
            this.labelMinTime_SIA = new System.Windows.Forms.Label();
            this.labelMaxTime_SIA = new System.Windows.Forms.Label();
            this.labelAvgTime_SIA = new System.Windows.Forms.Label();
            this.textBoxVehicleAmount_SIA = new System.Windows.Forms.TextBox();
            this.textBoxMinTime_SIA = new System.Windows.Forms.TextBox();
            this.textBoxMaxTime_SIA = new System.Windows.Forms.TextBox();
            this.textBoxAvgTime_SIA = new System.Windows.Forms.TextBox();
            this.groupBoxStats_SIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_SIA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStats_SIA
            // 
            this.groupBoxStats_SIA.Controls.Add(this.textBoxAvgTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMaxTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxMinTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.textBoxVehicleAmount_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelAvgTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelMaxTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelMinTime_SIA);
            this.groupBoxStats_SIA.Controls.Add(this.labelVehicleAmount_SIA);
            this.groupBoxStats_SIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxStats_SIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxStats_SIA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxStats_SIA.Name = "groupBoxStats_SIA";
            this.groupBoxStats_SIA.Size = new System.Drawing.Size(161, 448);
            this.groupBoxStats_SIA.TabIndex = 0;
            this.groupBoxStats_SIA.TabStop = false;
            this.groupBoxStats_SIA.Text = "Статистика";
            // 
            // chartStats_SIA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStats_SIA.ChartAreas.Add(chartArea1);
            this.chartStats_SIA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartStats_SIA.Legends.Add(legend1);
            this.chartStats_SIA.Location = new System.Drawing.Point(161, 0);
            this.chartStats_SIA.Name = "chartStats_SIA";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStats_SIA.Series.Add(series1);
            this.chartStats_SIA.Size = new System.Drawing.Size(593, 448);
            this.chartStats_SIA.TabIndex = 1;
            this.chartStats_SIA.Text = "chart1";
            // 
            // labelVehicleAmount_SIA
            // 
            this.labelVehicleAmount_SIA.AutoSize = true;
            this.labelVehicleAmount_SIA.Location = new System.Drawing.Point(35, 58);
            this.labelVehicleAmount_SIA.Name = "labelVehicleAmount_SIA";
            this.labelVehicleAmount_SIA.Size = new System.Drawing.Size(89, 18);
            this.labelVehicleAmount_SIA.TabIndex = 0;
            this.labelVehicleAmount_SIA.Text = "Кол-во т. с.";
            // 
            // labelMinTime_SIA
            // 
            this.labelMinTime_SIA.AutoSize = true;
            this.labelMinTime_SIA.Location = new System.Drawing.Point(2, 128);
            this.labelMinTime_SIA.Name = "labelMinTime_SIA";
            this.labelMinTime_SIA.Size = new System.Drawing.Size(153, 18);
            this.labelMinTime_SIA.TabIndex = 1;
            this.labelMinTime_SIA.Text = "Минимальное время";
            // 
            // labelMaxTime_SIA
            // 
            this.labelMaxTime_SIA.AutoSize = true;
            this.labelMaxTime_SIA.Location = new System.Drawing.Point(0, 205);
            this.labelMaxTime_SIA.Name = "labelMaxTime_SIA";
            this.labelMaxTime_SIA.Size = new System.Drawing.Size(161, 18);
            this.labelMaxTime_SIA.TabIndex = 2;
            this.labelMaxTime_SIA.Text = "Максимальное время";
            // 
            // labelAvgTime_SIA
            // 
            this.labelAvgTime_SIA.AutoSize = true;
            this.labelAvgTime_SIA.Location = new System.Drawing.Point(21, 274);
            this.labelAvgTime_SIA.Name = "labelAvgTime_SIA";
            this.labelAvgTime_SIA.Size = new System.Drawing.Size(115, 18);
            this.labelAvgTime_SIA.TabIndex = 3;
            this.labelAvgTime_SIA.Text = "Среднее время";
            // 
            // textBoxVehicleAmount_SIA
            // 
            this.textBoxVehicleAmount_SIA.Location = new System.Drawing.Point(16, 79);
            this.textBoxVehicleAmount_SIA.Name = "textBoxVehicleAmount_SIA";
            this.textBoxVehicleAmount_SIA.Size = new System.Drawing.Size(125, 24);
            this.textBoxVehicleAmount_SIA.TabIndex = 4;
            // 
            // textBoxMinTime_SIA
            // 
            this.textBoxMinTime_SIA.Location = new System.Drawing.Point(16, 149);
            this.textBoxMinTime_SIA.Name = "textBoxMinTime_SIA";
            this.textBoxMinTime_SIA.Size = new System.Drawing.Size(125, 24);
            this.textBoxMinTime_SIA.TabIndex = 5;
            // 
            // textBoxMaxTime_SIA
            // 
            this.textBoxMaxTime_SIA.Location = new System.Drawing.Point(16, 226);
            this.textBoxMaxTime_SIA.Name = "textBoxMaxTime_SIA";
            this.textBoxMaxTime_SIA.Size = new System.Drawing.Size(125, 24);
            this.textBoxMaxTime_SIA.TabIndex = 6;
            // 
            // textBoxAvgTime_SIA
            // 
            this.textBoxAvgTime_SIA.Location = new System.Drawing.Point(16, 295);
            this.textBoxAvgTime_SIA.Name = "textBoxAvgTime_SIA";
            this.textBoxAvgTime_SIA.Size = new System.Drawing.Size(125, 24);
            this.textBoxAvgTime_SIA.TabIndex = 7;
            // 
            // FormRoute_SIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 448);
            this.Controls.Add(this.chartStats_SIA);
            this.Controls.Add(this.groupBoxStats_SIA);
            this.MinimumSize = new System.Drawing.Size(546, 383);
            this.Name = "FormRoute_SIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRoute";
            this.Load += new System.EventHandler(this.FormRoute_Load);
            this.groupBoxStats_SIA.ResumeLayout(false);
            this.groupBoxStats_SIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats_SIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStats_SIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats_SIA;
        private System.Windows.Forms.TextBox textBoxAvgTime_SIA;
        private System.Windows.Forms.TextBox textBoxMaxTime_SIA;
        private System.Windows.Forms.TextBox textBoxMinTime_SIA;
        private System.Windows.Forms.TextBox textBoxVehicleAmount_SIA;
        private System.Windows.Forms.Label labelAvgTime_SIA;
        private System.Windows.Forms.Label labelMaxTime_SIA;
        private System.Windows.Forms.Label labelMinTime_SIA;
        private System.Windows.Forms.Label labelVehicleAmount_SIA;
    }
}