﻿namespace Auto_Rent.Views.EmployeeView
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
            textBoxJobtitle = new TextBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(20, 13);
            label.Name = "label";
            label.Size = new Size(205, 30);
            label.TabIndex = 27;
            label.Text = "Add New Employee";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(20, 376);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 26;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(122, 368);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(210, 29);
            textBoxAddres.TabIndex = 25;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(20, 326);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(122, 318);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 29);
            textBoxEmail.TabIndex = 23;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(20, 276);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 22;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(122, 268);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(210, 29);
            textBoxPhone.TabIndex = 21;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(20, 226);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(40, 21);
            labelAge.TabIndex = 20;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F);
            textBoxAge.Location = new Point(122, 218);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(210, 29);
            textBoxAge.TabIndex = 19;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(20, 133);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 18;
            labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(122, 125);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(210, 29);
            textBoxSurname.TabIndex = 17;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(20, 82);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 16;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(122, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 29);
            textBoxName.TabIndex = 15;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(203, 460);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(128, 55);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelJobtitle
            // 
            labelJobtitle.AutoSize = true;
            labelJobtitle.Font = new Font("Segoe UI", 12F);
            labelJobtitle.Location = new Point(20, 178);
            labelJobtitle.Name = "labelJobtitle";
            labelJobtitle.Size = new Size(63, 21);
            labelJobtitle.TabIndex = 29;
            labelJobtitle.Text = "Jobtitle:";
            // 
            // textBoxJobtitle
            // 
            textBoxJobtitle.Font = new Font("Segoe UI", 12F);
            textBoxJobtitle.Location = new Point(122, 170);
            textBoxJobtitle.Name = "textBoxJobtitle";
            textBoxJobtitle.Size = new Size(210, 29);
            textBoxJobtitle.TabIndex = 28;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(271, 13);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 45;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // EmployeeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(labelJobtitle);
            Controls.Add(textBoxJobtitle);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeAdd";
            Size = new Size(350, 530);
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
        private TextBox textBoxJobtitle;
        private Button buttonBack;
    }
}
