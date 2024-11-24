namespace Auto_Rent.Views.ProviderView
{
    partial class ProviderEdit
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
            labelAddres = new Label();
            textBoxAddres = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            richTextBoxId = new RichTextBox();
            labelId = new Label();
            buttonDelete = new Button();
            label = new Label();
            buttonEdit = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(19, 283);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 78;
            labelAddres.Text = "Addres:";
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(121, 275);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(210, 29);
            textBoxAddres.TabIndex = 77;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(19, 233);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 76;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(121, 225);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 29);
            textBoxEmail.TabIndex = 75;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(19, 183);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 74;
            labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(121, 175);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(210, 29);
            textBoxPhone.TabIndex = 73;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(19, 112);
            labelName.Name = "labelName";
            labelName.Size = new Size(77, 42);
            labelName.TabIndex = 68;
            labelName.Text = "Company\nName:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(121, 125);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(210, 29);
            textBoxName.TabIndex = 67;
            // 
            // richTextBoxId
            // 
            richTextBoxId.Font = new Font("Segoe UI", 12.1636362F);
            richTextBoxId.Location = new Point(121, 59);
            richTextBoxId.Margin = new Padding(3, 2, 3, 2);
            richTextBoxId.Name = "richTextBoxId";
            richTextBoxId.Size = new Size(210, 26);
            richTextBoxId.TabIndex = 66;
            richTextBoxId.Text = "";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12.1636362F);
            labelId.Location = new Point(20, 64);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 23);
            labelId.TabIndex = 65;
            labelId.Text = "Id:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(20, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 55);
            buttonDelete.TabIndex = 64;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(20, 14);
            label.Name = "label";
            label.Size = new Size(137, 30);
            label.TabIndex = 63;
            label.Text = "Edit Provider";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(192, 255, 192);
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(203, 461);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(128, 55);
            buttonEdit.TabIndex = 62;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(271, 14);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 79;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // ProviderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(labelAddres);
            Controls.Add(textBoxAddres);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPhone);
            Controls.Add(textBoxPhone);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(richTextBoxId);
            Controls.Add(labelId);
            Controls.Add(buttonDelete);
            Controls.Add(label);
            Controls.Add(buttonEdit);
            Name = "ProviderEdit";
            Size = new Size(350, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAddres;
        private TextBox textBoxAddres;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelName;
        private TextBox textBoxName;
        private RichTextBox richTextBoxId;
        private Label labelId;
        private Button buttonDelete;
        private Label label;
        private Button buttonEdit;
        private Button buttonBack;
    }
}
