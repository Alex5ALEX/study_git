namespace Auto_Rent.Views.AutoView
{
    partial class AutoAdd
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
            buttonAdd = new Button();
            labelCoast = new Label();
            labelCondition = new Label();
            labelYear = new Label();
            labelIdProvider = new Label();
            richTextBoxIdProvider = new RichTextBox();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(19, 179);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 21);
            labelPrice.TabIndex = 45;
            labelPrice.Text = "Price:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Segoe UI", 12F);
            textBoxPrice.Location = new Point(121, 171);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(210, 29);
            textBoxPrice.TabIndex = 44;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 16F);
            label.Location = new Point(19, 14);
            label.Name = "label";
            label.Size = new Size(155, 30);
            label.TabIndex = 43;
            label.Text = "Add New Auto";
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 12F);
            textBoxYear.Location = new Point(121, 319);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(210, 29);
            textBoxYear.TabIndex = 39;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Font = new Font("Segoe UI", 12F);
            textBoxCondition.Location = new Point(121, 269);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(210, 29);
            textBoxCondition.TabIndex = 37;
            // 
            // textBoxCoast
            // 
            textBoxCoast.Font = new Font("Segoe UI", 12F);
            textBoxCoast.Location = new Point(121, 219);
            textBoxCoast.Name = "textBoxCoast";
            textBoxCoast.Size = new Size(210, 29);
            textBoxCoast.TabIndex = 35;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 12F);
            labelModel.Location = new Point(19, 134);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(57, 21);
            labelModel.TabIndex = 34;
            labelModel.Text = "Model:";
            // 
            // textBoxModel
            // 
            textBoxModel.Font = new Font("Segoe UI", 12F);
            textBoxModel.Location = new Point(121, 126);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(210, 29);
            textBoxModel.TabIndex = 33;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 12F);
            labelBrand.Location = new Point(19, 83);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(54, 21);
            labelBrand.TabIndex = 32;
            labelBrand.Text = "Brand:";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Font = new Font("Segoe UI", 12F);
            textBoxBrand.Location = new Point(121, 75);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(210, 29);
            textBoxBrand.TabIndex = 31;
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
            // labelCoast
            // 
            labelCoast.AutoSize = true;
            labelCoast.Font = new Font("Segoe UI", 12F);
            labelCoast.Location = new Point(19, 227);
            labelCoast.Name = "labelCoast";
            labelCoast.Size = new Size(52, 21);
            labelCoast.TabIndex = 46;
            labelCoast.Text = "Coast:";
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Font = new Font("Segoe UI", 12F);
            labelCondition.Location = new Point(19, 277);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(81, 21);
            labelCondition.TabIndex = 47;
            labelCondition.Text = "Condition:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 12F);
            labelYear.Location = new Point(19, 327);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(43, 21);
            labelYear.TabIndex = 48;
            labelYear.Text = "Year:";
            // 
            // labelIdProvider
            // 
            labelIdProvider.AutoSize = true;
            labelIdProvider.Font = new Font("Segoe UI", 12F);
            labelIdProvider.Location = new Point(19, 415);
            labelIdProvider.Name = "labelIdProvider";
            labelIdProvider.Size = new Size(89, 21);
            labelIdProvider.TabIndex = 50;
            labelIdProvider.Text = "Id Provider:";
            // 
            // richTextBoxIdProvider
            // 
            richTextBoxIdProvider.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxIdProvider.Font = new Font("Segoe UI", 12F);
            richTextBoxIdProvider.Location = new Point(121, 372);
            richTextBoxIdProvider.Name = "richTextBoxIdProvider";
            richTextBoxIdProvider.Size = new Size(209, 64);
            richTextBoxIdProvider.TabIndex = 51;
            richTextBoxIdProvider.Text = "";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(271, 14);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 30);
            buttonBack.TabIndex = 80;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // AutoAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
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
            Controls.Add(buttonAdd);
            Name = "AutoAdd";
            Size = new Size(350, 530);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPrice;
        private TextBox textBoxPrice;
        private TextBox textBoxYear;
        private TextBox textBoxCondition;
        private TextBox textBoxCoast;
        private TextBox textBoxModel;
        private Label label;
        private TextBox textBoxAddres;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxAge;
        private Label labelModel;
        private TextBox textBoxSurname;
        private Label labelBrand;
        private TextBox textBoxBrand;
        private Button buttonAdd;
        private Label labelCoast;
        private Label labelCondition;
        private Label labelYear;
        private Label labelIdProvider;
        private RichTextBox richTextBoxIdProvider;
        private Button buttonBack;
    }
}
