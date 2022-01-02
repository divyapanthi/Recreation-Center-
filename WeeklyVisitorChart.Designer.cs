
namespace cw_recreation_center
{
    partial class WeeklyVisitorChart
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklyVisitorReportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChooseDate = new System.Windows.Forms.Label();
            this.dateTimePickerChoose = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyVisitorReportChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(276, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weekly Visitor Chart";
            // 
            // weeklyVisitorReportChart
            // 
            chartArea1.Name = "ChartArea1";
            this.weeklyVisitorReportChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.weeklyVisitorReportChart.Legends.Add(legend1);
            this.weeklyVisitorReportChart.Location = new System.Drawing.Point(12, 144);
            this.weeklyVisitorReportChart.Name = "weeklyVisitorReportChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Earning";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Number of Visitor";
            this.weeklyVisitorReportChart.Series.Add(series1);
            this.weeklyVisitorReportChart.Series.Add(series2);
            this.weeklyVisitorReportChart.Size = new System.Drawing.Size(788, 468);
            this.weeklyVisitorReportChart.TabIndex = 19;
            this.weeklyVisitorReportChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 62);
            this.panel1.TabIndex = 18;
            // 
            // labelChooseDate
            // 
            this.labelChooseDate.AutoSize = true;
            this.labelChooseDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChooseDate.Location = new System.Drawing.Point(44, 91);
            this.labelChooseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChooseDate.Name = "labelChooseDate";
            this.labelChooseDate.Size = new System.Drawing.Size(121, 19);
            this.labelChooseDate.TabIndex = 17;
            this.labelChooseDate.Text = "Choose Date:";
            // 
            // dateTimePickerChoose
            // 
            this.dateTimePickerChoose.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerChoose.Location = new System.Drawing.Point(210, 87);
            this.dateTimePickerChoose.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerChoose.Name = "dateTimePickerChoose";
            this.dateTimePickerChoose.Size = new System.Drawing.Size(341, 23);
            this.dateTimePickerChoose.TabIndex = 16;
            // 
            // WeeklyVisitorChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 691);
            this.Controls.Add(this.weeklyVisitorReportChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelChooseDate);
            this.Controls.Add(this.dateTimePickerChoose);
            this.Name = "WeeklyVisitorChart";
            this.Text = "WeeklyVisitorChart";
            ((System.ComponentModel.ISupportInitialize)(this.weeklyVisitorReportChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklyVisitorReportChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelChooseDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerChoose;
    }
}