namespace Auto_Rent.Views.Report
{
    partial class ReportControl
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
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 115);
            button1.Name = "button1";
            button1.Size = new Size(218, 48);
            button1.TabIndex = 0;
            button1.Text = "Auto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 189);
            button2.Name = "button2";
            button2.Size = new Size(218, 48);
            button2.TabIndex = 1;
            button2.Text = "Orders";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(6, 264);
            button4.Name = "button4";
            button4.Size = new Size(218, 48);
            button4.TabIndex = 3;
            button4.Text = "Finance";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(251, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 610);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(14, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 610);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // ReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReportControl";
            Size = new Size(1250, 650);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
