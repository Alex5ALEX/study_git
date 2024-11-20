namespace Auto_Rent.Views.ClientView
{
    partial class ClientAdd
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
            buttonAdd = new Button();
            textBoxName = new TextBox();
            labelName = new Label();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            labelAge = new Label();
            textBoxAge = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelAddres = new Label();
            textBoxAddres = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(226, 580);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(146, 70);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(133, 91);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(239, 32);
            textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(17, 101);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(17, 165);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(91, 25);
            labelSurname.TabIndex = 4;
            labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(133, 155);
            textBoxSurname.Margin = new Padding(3, 4, 3, 4);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(239, 32);
            textBoxSurname.TabIndex = 3;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(17, 228);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(49, 25);
            labelAge.TabIndex = 6;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F);
            textBoxAge.Location = new Point(133, 218);
            textBoxAge.Margin = new Padding(3, 4, 3, 4);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(239, 32);
            textBoxAge.TabIndex = 5;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(17, 291);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(70, 25);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(133, 281);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(239, 32);
            textBoxPhone.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(17, 355);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 25);
            labelEmail.TabIndex = 10;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(133, 345);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 32);
            textBoxEmail.TabIndex = 9;
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(17, 418);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(75, 25);
            labelAddres.TabIndex = 12;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(133, 408);
            textBoxAddres.Margin = new Padding(3, 4, 3, 4);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(239, 32);
            textBoxAddres.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(17, 14);
            label.Name = "label";
            label.Size = new Size(187, 35);
            label.TabIndex = 13;
            label.Text = "Add New Client";
            // 
            // ClientAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientAdd";
            Size = new Size(400, 670);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelAge;
        private TextBox textBoxAge;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelAddres;
        private TextBox textBoxAddres;
        private Label label;
    }
}
