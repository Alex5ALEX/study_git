namespace Auto_Rent.Views.EmployeeView
{
    partial class EmployeeEdit
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
            richTextBoxId = new RichTextBox();
            labelId = new Label();
            buttonDelete = new Button();
            label = new Label();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // richTextBoxId
            // 
            richTextBoxId.Font = new Font("Segoe UI", 12.1636362F);
            richTextBoxId.Location = new Point(138, 73);
            richTextBoxId.Name = "richTextBoxId";
            richTextBoxId.Size = new Size(239, 32);
            richTextBoxId.TabIndex = 47;
            richTextBoxId.Text = "";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12.1636362F);
            labelId.Location = new Point(23, 80);
            labelId.Name = "labelId";
            labelId.Size = new Size(32, 25);
            labelId.TabIndex = 46;
            labelId.Text = "Id:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(23, 583);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(146, 70);
            buttonDelete.TabIndex = 45;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(23, 17);
            label.Name = "label";
            label.Size = new Size(173, 35);
            label.TabIndex = 44;
            label.Text = "Edit Employee";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(192, 255, 192);
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(232, 583);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(146, 70);
            buttonEdit.TabIndex = 31;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // EmployeeEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBoxId);
            Controls.Add(labelId);
            Controls.Add(buttonDelete);
            Controls.Add(label);
            Controls.Add(buttonEdit);
            Name = "EmployeeEdit";
            Size = new Size(400, 670);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxId;
        private Label labelId;
        private Button buttonDelete;
        private Label label;
        private Button buttonEdit;
    }
}
