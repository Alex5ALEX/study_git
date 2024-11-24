namespace Auto_Rent.Views.AutoView
{
    partial class AutoEdit
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
            richTextBoxIdProvider = new RichTextBox();
            labelIdProvider = new Label();
            labelYear = new Label();
            labelCondition = new Label();
            labelCoast = new Label();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            label = new Label();
            textBoxYear = new TextBox();
            textBoxCondition = new TextBox();
            textBoxCoast = new TextBox();
            labelModel = new Label();
            textBoxModel = new TextBox();
            labelBrand = new Label();
            textBoxBrand = new TextBox();
            richTextBoxId = new RichTextBox();
            labelId = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // richTextBoxIdProvider
            // 
            richTextBoxIdProvider.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxIdProvider.Font = new Font("Segoe UI", 12F);
            richTextBoxIdProvider.Location = new Point(121, 407);
            richTextBoxIdProvider.Name = "richTextBoxIdProvider";
            richTextBoxIdProvider.Size = new Size(209, 29);
            richTextBoxIdProvider.TabIndex = 67;
            richTextBoxIdProvider.Text = "";
            // 
            // labelIdProvider
            // 
            labelIdProvider.AutoSize = true;
            labelIdProvider.Font = new Font("Segoe UI", 12F);
            labelIdProvider.Location = new Point(19, 415);
            labelIdProvider.Name = "labelIdProvider";
            labelIdProvider.Size = new Size(89, 21);
            labelIdProvider.TabIndex = 66;
            labelIdProvider.Text = "Id Provider:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F);
            labelYear.Location = new Point(19, 363);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(43, 21);
            labelYear.TabIndex = 65;
            labelYear.Text = "Year:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 12F);
            labelCondition.Location = new Point(19, 313);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(81, 21);
            labelCondition.TabIndex = 64;
            labelCondition.Text = "Condition:";
            // 
            // labelCoast
            // 
            labelCoast.AutoSize = true;
            labelCoast.Font = new Font("Segoe UI", 12F);
            labelCoast.Location = new Point(19, 263);
            labelCoast.Name = "labelCoast";
            labelCoast.Size = new Size(52, 21);
            labelCoast.TabIndex = 63;
            labelCoast.Text = "Coast:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(19, 215);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 21);
            labelPrice.TabIndex = 62;
            labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F);
            textBoxPrice.Location = new Point(121, 207);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(210, 29);
            textBoxPrice.TabIndex = 61;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(19, 14);
            label.Name = "label";
            label.Size = new Size(101, 30);
            label.TabIndex = 60;
            label.Text = "Edit Auto";
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 12F);
            textBoxYear.Location = new Point(121, 355);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(210, 29);
            textBoxYear.TabIndex = 59;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 12F);
            textBoxCondition.Location = new Point(121, 305);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(210, 29);
            textBoxCondition.TabIndex = 58;
            // 
            // textBoxCoast
            // 
            textBoxCoast.Font = new Font("Segoe UI", 12F);
            textBoxCoast.Location = new Point(121, 255);
            textBoxCoast.Name = "textBoxCoast";
            textBoxCoast.Size = new Size(210, 29);
            textBoxCoast.TabIndex = 57;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F);
            labelModel.Location = new Point(19, 170);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(57, 21);
            labelModel.TabIndex = 56;
            labelModel.Text = "Model:";
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI", 12F);
            textBoxModel.Location = new Point(121, 162);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(210, 29);
            textBoxModel.TabIndex = 55;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F);
            labelBrand.Location = new Point(19, 119);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(54, 21);
            labelBrand.TabIndex = 54;
            labelBrand.Text = "Brand:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Segoe UI", 12F);
            textBoxBrand.Location = new Point(121, 111);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(210, 29);
            textBoxBrand.TabIndex = 53;
            // 
            // richTextBoxId
            // 
            richTextBoxId.Font = new Font("Segoe UI", 12.1636362F);
            richTextBoxId.Location = new Point(121, 58);
            richTextBoxId.Margin = new Padding(3, 2, 3, 2);
            richTextBoxId.Name = "richTextBoxId";
            richTextBoxId.Size = new Size(210, 26);
            richTextBoxId.TabIndex = 69;
            richTextBoxId.Text = "";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12.1636362F);
            labelId.Location = new Point(20, 63);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 23);
            labelId.TabIndex = 68;
            labelId.Text = "Id:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(255, 128, 128);
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(20, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 55);
            buttonDelete.TabIndex = 71;
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
            buttonEdit.TabIndex = 70;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(270, 14);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 80;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // AutoEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(richTextBoxId);
            Controls.Add(labelId);
            Controls.Add(richTextBoxIdProvider);
            Controls.Add(labelIdProvider);
            Controls.Add(labelYear);
            Controls.Add(labelCondition);
            Controls.Add(labelCoast);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(label);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxCondition);
            Controls.Add(textBoxCoast);
            Controls.Add(labelModel);
            Controls.Add(textBoxModel);
            Controls.Add(labelBrand);
            Controls.Add(textBoxBrand);
            Name = "AutoEdit";
            Size = new Size(350, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxIdProvider;
        private Label labelIdProvider;
        private Label labelYear;
        private Label labelCondition;
        private Label labelCoast;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label label;
        private TextBox textBoxYear;
        private TextBox textBoxCondition;
        private TextBox textBoxCoast;
        private Label labelModel;
        private TextBox textBoxModel;
        private Label labelBrand;
        private TextBox textBoxBrand;
        private RichTextBox richTextBoxId;
        private Label labelId;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonBack;
    }
}
