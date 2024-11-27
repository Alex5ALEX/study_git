namespace Auto_Rent.Views.Report.FinanaceRep
{
    partial class FinanceReport
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            label5 = new Label();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(985, 610);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(chart1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 12F);
            groupBox3.Location = new Point(497, 52);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 552);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Consumption";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 122);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 3;
            label4.Text = "Потери в год:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(19, 160);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(433, 386);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 78);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 40);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 0;
            label2.Text = "Общие потери:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(chart2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(6, 52);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 552);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Income";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 1;
            label1.Text = "Finance Report";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 122);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 7;
            label5.Text = "Прибыль в год:";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(17, 160);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(433, 386);
            chart2.TabIndex = 6;
            chart2.Text = "chart2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 78);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 40);
            label7.Name = "label7";
            label7.Size = new Size(130, 21);
            label7.TabIndex = 4;
            label7.Text = "Общая прибыль:";
            // 
            // FinanceReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "FinanceReport";
            Size = new Size(985, 610);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label6;
        private Label label7;
    }
}
