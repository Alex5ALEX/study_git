namespace Auto_Rent.Views.EmployeeView
{
    partial class EmployeeAdd
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
            label = new Label();
            labelAddres = new Label();
            textBoxAddres = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelAge = new Label();
            textBoxAge = new TextBox();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            labelJobtitle = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(23, 17);
            label.Name = "label";
            label.Size = new Size(234, 35);
            label.TabIndex = 27;
            label.Text = "Add New Employee";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(23, 476);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(75, 25);
            labelAddres.TabIndex = 26;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(139, 466);
            textBoxAddres.Margin = new Padding(3, 4, 3, 4);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(239, 32);
            textBoxAddres.TabIndex = 25;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(23, 413);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 25);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(139, 403);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 32);
            textBoxEmail.TabIndex = 23;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(23, 349);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(70, 25);
            labelPhone.TabIndex = 22;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(139, 339);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(239, 32);
            textBoxPhone.TabIndex = 21;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(23, 286);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(49, 25);
            labelAge.TabIndex = 20;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F);
            textBoxAge.Location = new Point(139, 276);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(239, 32);
            textBoxAge.TabIndex = 19;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(23, 168);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(91, 25);
            labelSurname.TabIndex = 18;
            labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(139, 158);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(239, 32);
            textBoxSurname.TabIndex = 17;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(23, 104);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 25);
            labelName.TabIndex = 16;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(139, 94);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(239, 32);
            textBoxName.TabIndex = 15;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(232, 583);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(146, 70);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelJobtitle
            // 
            labelJobtitle.AutoSize = true;
            labelJobtitle.Font = new Font("Segoe UI", 12F);
            labelJobtitle.Location = new Point(23, 225);
            labelJobtitle.Name = "labelJobtitle";
            labelJobtitle.Size = new Size(49, 25);
            labelJobtitle.TabIndex = 29;
            labelJobtitle.Text = "Age:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(139, 215);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 32);
            textBox1.TabIndex = 28;
            // 
            // EmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelJobtitle);
            Controls.Add(textBox1);
            Controls.Add(label);
            Controls.Add(labelAddres);
            Controls.Add(textBoxAddres);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelAge);
            Controls.Add(textBoxAge);
            Controls.Add(labelSurname);
            Controls.Add(textBoxSurname);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "EmployeeAdd";
            Size = new Size(400, 670);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label labelAddres;
        private TextBox textBoxAddres;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelAge;
        private TextBox textBoxAge;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Label labelJobtitle;
        private TextBox textBox1;
    }
}
