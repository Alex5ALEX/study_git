namespace Auto_Rent.Views.ProviderView
{
    partial class ProviderAdd
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
            labelName = new Label();
            textBoxName = new TextBox();
            buttonAdd = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(19, 14);
            label.Name = "label";
            label.Size = new Size(191, 30);
            label.TabIndex = 43;
            label.Text = "Add New Provider";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(18, 247);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 42;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(120, 239);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(210, 29);
            textBoxAddres.TabIndex = 41;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(18, 197);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 40;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(120, 189);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 29);
            textBoxEmail.TabIndex = 39;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(18, 147);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 38;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(120, 139);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(210, 29);
            textBoxPhone.TabIndex = 37;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(19, 75);
            labelName.Name = "labelName";
            labelName.Size = new Size(77, 42);
            labelName.TabIndex = 32;
            labelName.Text = "Company\nName:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(120, 88);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 29);
            textBoxName.TabIndex = 31;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(202, 461);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(128, 55);
            buttonAdd.TabIndex = 30;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(270, 18);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 44;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // ProviderAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(label);
            Controls.Add(labelAddres);
            Controls.Add(textBoxAddres);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(buttonAdd);
            Name = "ProviderAdd";
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
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonAdd;
        private Button buttonBack;
    }
}
