namespace Auto_Rent.Views.Report.OrderRep;

partial class OrderReport
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
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        label7 = new Label();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(chart1);
        groupBox1.Controls.Add(label7);
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(984, 610);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(flowLayoutPanel1);
        groupBox2.Location = new Point(520, 66);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(458, 522);
        groupBox2.TabIndex = 10;
        groupBox2.TabStop = false;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(6, 19);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(446, 497);
        flowLayoutPanel1.TabIndex = 2;
        // 
        // chart1
        // 
        chartArea3.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea3);
        legend3.Name = "Legend1";
        chart1.Legends.Add(legend3);
        chart1.Location = new Point(31, 239);
        chart1.Name = "chart1";
        series3.ChartArea = "ChartArea1";
        series3.Legend = "Legend1";
        series3.Name = "Series1";
        chart1.Series.Add(series3);
        chart1.Size = new Size(470, 349);
        chart1.TabIndex = 9;
        chart1.Text = "chart1";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F);
        label7.Location = new Point(177, 144);
        label7.Name = "label7";
        label7.Size = new Size(52, 21);
        label7.TabIndex = 7;
        label7.Text = "label7";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 12F);
        label6.Location = new Point(177, 91);
        label6.Name = "label6";
        label6.Size = new Size(52, 21);
        label6.TabIndex = 6;
        label6.Text = "label6";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 14F);
        label5.Location = new Point(31, 198);
        label5.Name = "label5";
        label5.Size = new Size(60, 25);
        label5.TabIndex = 5;
        label5.Text = "Years:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 14F);
        label4.Location = new Point(31, 141);
        label4.Name = "label4";
        label4.Size = new Size(128, 25);
        label4.TabIndex = 4;
        label4.Text = "General Time:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 16F);
        label3.Location = new Point(520, 19);
        label3.Name = "label3";
        label3.Size = new Size(76, 30);
        label3.TabIndex = 3;
        label3.Text = "Order:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F);
        label2.Location = new Point(31, 87);
        label2.Name = "label2";
        label2.Size = new Size(67, 25);
        label2.TabIndex = 1;
        label2.Text = "Count:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F);
        label1.Location = new Point(6, 19);
        label1.Name = "label1";
        label1.Size = new Size(142, 30);
        label1.TabIndex = 0;
        label1.Text = "Order Report";
        // 
        // OrderReport
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "OrderReport";
        Size = new Size(984, 610);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Label label1;
    private Label label2;
    private FlowLayoutPanel flowLayoutPanel1;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private GroupBox groupBox2;
    private System.ComponentModel.BackgroundWorker backgroundWorker2;
}
