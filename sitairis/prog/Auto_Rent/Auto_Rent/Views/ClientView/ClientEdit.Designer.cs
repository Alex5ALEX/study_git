namespace Auto_Rent.Views.ClientView
{
    partial class ClientEdit
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
            buttonEdit = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(20, 14);
            label.Name = "label";
            label.Size = new Size(110, 30);
            label.TabIndex = 27;
            label.Text = "Edit Client";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(20, 377);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 26;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(121, 369);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(210, 29);
            textBoxAddres.TabIndex = 25;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(20, 327);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 24;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(121, 319);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 29);
            textBoxEmail.TabIndex = 23;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(20, 277);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 22;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(121, 269);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(210, 29);
            textBoxPhone.TabIndex = 21;
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Segoe UI", 12F);
            labelAge.Location = new Point(20, 227);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(40, 21);
            labelAge.TabIndex = 20;
            labelAge.Text = "Age:";
            // 
            // textBoxAge
            // 
            textBoxAge.Font = new Font("Segoe UI", 12F);
            textBoxAge.Location = new Point(121, 219);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(210, 29);
            textBoxAge.TabIndex = 19;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(20, 177);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 18;
            labelSurname.Text = "Surname:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(121, 169);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(210, 29);
            textBoxSurname.TabIndex = 17;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(20, 127);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 16;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(121, 119);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 29);
            textBoxName.TabIndex = 15;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(192, 255, 192);
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(203, 461);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(128, 55);
            buttonEdit.TabIndex = 14;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(20, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 55);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // ClientEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
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
            Controls.Add(buttonEdit);
            Name = "ClientEdit";
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
        private Button buttonEdit;
        private Button buttonDelete;
    }
}
