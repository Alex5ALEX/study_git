namespace Auto_Rent.Views.OrderView
{
    partial class OrderEdit
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
            buttonBack = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            label = new Label();
            richTextBoxIdAuto = new RichTextBox();
            labelIdAuto = new Label();
            richTextBoxIdClient = new RichTextBox();
            labelIdClient = new Label();
            richTextBoxIdEmployee = new RichTextBox();
            labelIdEmployee = new Label();
            labelDeposit = new Label();
            textBoxDeposit = new TextBox();
            labelFinaleDate = new Label();
            textBoxFinalDate = new TextBox();
            labelDate = new Label();
            textBoxDate = new TextBox();
            richTextBoxId = new RichTextBox();
            labelId = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(270, 14);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 100;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(20, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 55);
            buttonDelete.TabIndex = 99;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(192, 255, 192);
            buttonEdit.Font = new Font("Segoe UI", 12F);
            buttonEdit.Location = new Point(202, 461);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(128, 55);
            buttonEdit.TabIndex = 98;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(19, 14);
            label.Name = "label";
            label.Size = new Size(113, 30);
            label.TabIndex = 88;
            label.Text = "Edit Order";
            // 
            // richTextBoxIdAuto
            // 
            richTextBoxIdAuto.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxIdAuto.Font = new Font("Segoe UI", 12F);
            richTextBoxIdAuto.Location = new Point(121, 225);
            richTextBoxIdAuto.Name = "richTextBoxIdAuto";
            richTextBoxIdAuto.Size = new Size(210, 64);
            richTextBoxIdAuto.TabIndex = 113;
            richTextBoxIdAuto.Text = "";
            // 
            // labelIdAuto
            // 
            labelIdAuto.AutoSize = true;
            labelIdAuto.Font = new Font("Segoe UI", 12F);
            labelIdAuto.Location = new Point(18, 268);
            labelIdAuto.Name = "labelIdAuto";
            labelIdAuto.Size = new Size(63, 21);
            labelIdAuto.TabIndex = 112;
            labelIdAuto.Text = "Id Auto:";
            // 
            // richTextBoxIdClient
            // 
            richTextBoxIdClient.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxIdClient.Font = new Font("Segoe UI", 12F);
            richTextBoxIdClient.Location = new Point(121, 309);
            richTextBoxIdClient.Name = "richTextBoxIdClient";
            richTextBoxIdClient.Size = new Size(210, 64);
            richTextBoxIdClient.TabIndex = 111;
            richTextBoxIdClient.Text = "";
            // 
            // labelIdClient
            // 
            labelIdClient.AutoSize = true;
            labelIdClient.Font = new Font("Segoe UI", 12F);
            labelIdClient.Location = new Point(19, 352);
            labelIdClient.Name = "labelIdClient";
            labelIdClient.Size = new Size(70, 21);
            labelIdClient.TabIndex = 110;
            labelIdClient.Text = "Id Client:";
            // 
            // richTextBoxIdEmployee
            // 
            richTextBoxIdEmployee.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxIdEmployee.Font = new Font("Segoe UI", 12F);
            richTextBoxIdEmployee.Location = new Point(121, 394);
            richTextBoxIdEmployee.Name = "richTextBoxIdEmployee";
            richTextBoxIdEmployee.Size = new Size(210, 64);
            richTextBoxIdEmployee.TabIndex = 109;
            richTextBoxIdEmployee.Text = "";
            // 
            // labelIdEmployee
            // 
            labelIdEmployee.AutoSize = true;
            labelIdEmployee.Font = new Font("Segoe UI", 12F);
            labelIdEmployee.Location = new Point(18, 437);
            labelIdEmployee.Name = "labelIdEmployee";
            labelIdEmployee.Size = new Size(98, 21);
            labelIdEmployee.TabIndex = 108;
            labelIdEmployee.Text = "Id Employee:";
            // 
            // labelDeposit
            // 
            labelDeposit.AutoSize = true;
            labelDeposit.Font = new Font("Segoe UI", 12F);
            labelDeposit.Location = new Point(18, 189);
            labelDeposit.Name = "labelDeposit";
            labelDeposit.Size = new Size(66, 21);
            labelDeposit.TabIndex = 107;
            labelDeposit.Text = "Deposit:";
            // 
            // textBoxDeposit
            // 
            textBoxDeposit.Font = new Font("Segoe UI", 12F);
            textBoxDeposit.Location = new Point(121, 181);
            textBoxDeposit.Name = "textBoxDeposit";
            textBoxDeposit.Size = new Size(210, 29);
            textBoxDeposit.TabIndex = 106;
            // 
            // labelFinaleDate
            // 
            labelFinaleDate.AutoSize = true;
            labelFinaleDate.Font = new Font("Segoe UI", 12F);
            labelFinaleDate.Location = new Point(19, 145);
            labelFinaleDate.Name = "labelFinaleDate";
            labelFinaleDate.Size = new Size(82, 21);
            labelFinaleDate.TabIndex = 105;
            labelFinaleDate.Text = "Final Date:";
            // 
            // textBoxFinalDate
            // 
            textBoxFinalDate.Font = new Font("Segoe UI", 12F);
            textBoxFinalDate.Location = new Point(121, 137);
            textBoxFinalDate.Name = "textBoxFinalDate";
            textBoxFinalDate.Size = new Size(210, 29);
            textBoxFinalDate.TabIndex = 104;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F);
            labelDate.Location = new Point(18, 101);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(45, 21);
            labelDate.TabIndex = 103;
            labelDate.Text = "Date:";
            // 
            // textBoxDate
            // 
            textBoxDate.Font = new Font("Segoe UI", 12F);
            textBoxDate.Location = new Point(121, 93);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(210, 29);
            textBoxDate.TabIndex = 102;
            // 
            // richTextBoxId
            // 
            richTextBoxId.Font = new Font("Segoe UI", 12.1636362F);
            richTextBoxId.Location = new Point(121, 49);
            richTextBoxId.Margin = new Padding(3, 2, 3, 2);
            richTextBoxId.Name = "richTextBoxId";
            richTextBoxId.Size = new Size(210, 26);
            richTextBoxId.TabIndex = 115;
            richTextBoxId.Text = "";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12.1636362F);
            labelId.Location = new Point(20, 54);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 23);
            labelId.TabIndex = 114;
            labelId.Text = "Id:";
            // 
            // OrderEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(richTextBoxId);
            Controls.Add(labelId);
            Controls.Add(richTextBoxIdAuto);
            Controls.Add(labelIdAuto);
            Controls.Add(richTextBoxIdClient);
            Controls.Add(labelIdClient);
            Controls.Add(richTextBoxIdEmployee);
            Controls.Add(labelIdEmployee);
            Controls.Add(labelDeposit);
            Controls.Add(textBoxDeposit);
            Controls.Add(labelFinaleDate);
            Controls.Add(textBoxFinalDate);
            Controls.Add(labelDate);
            Controls.Add(textBoxDate);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(label);
            Name = "OrderEdit";
            Size = new Size(350, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonDelete;
        private Button buttonEdit;
        private Label label;
        private RichTextBox richTextBoxIdAuto;
        private Label labelIdAuto;
        private RichTextBox richTextBoxIdClient;
        private Label labelIdClient;
        private RichTextBox richTextBoxIdEmployee;
        private Label labelIdEmployee;
        private Label labelDeposit;
        private TextBox textBoxDeposit;
        private Label labelFinaleDate;
        private TextBox textBoxFinalDate;
        private Label labelDate;
        private TextBox textBoxDate;
        private RichTextBox richTextBoxId;
        private Label labelId;
    }
}
