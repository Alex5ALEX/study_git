namespace Auto_Rent.Views.OrderView;

partial class OrderAdd
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
        richTextBoxIdEmployee = new RichTextBox();
        labelIdEmployee = new Label();
        label = new Label();
        buttonAdd = new Button();
        richTextBoxIdClient = new RichTextBox();
        labelIdClient = new Label();
        richTextBoxIdAuto = new RichTextBox();
        labelIdAuto = new Label();
        labelDeposit = new Label();
        textBoxDeposit = new TextBox();
        labelFinaleDate = new Label();
        textBoxFinalDate = new TextBox();
        labelDate = new Label();
        textBoxDate = new TextBox();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.Location = new Point(271, 14);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(60, 30);
        buttonBack.TabIndex = 97;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // richTextBoxIdEmployee
        // 
        richTextBoxIdEmployee.BorderStyle = BorderStyle.FixedSingle;
        richTextBoxIdEmployee.Font = new Font("Segoe UI", 12F);
        richTextBoxIdEmployee.Location = new Point(122, 391);
        richTextBoxIdEmployee.Name = "richTextBoxIdEmployee";
        richTextBoxIdEmployee.Size = new Size(209, 64);
        richTextBoxIdEmployee.TabIndex = 96;
        richTextBoxIdEmployee.Text = "";
        // 
        // labelIdEmployee
        // 
        labelIdEmployee.AutoSize = true;
        labelIdEmployee.Font = new Font("Segoe UI", 12F);
        labelIdEmployee.Location = new Point(19, 434);
        labelIdEmployee.Name = "labelIdEmployee";
        labelIdEmployee.Size = new Size(98, 21);
        labelIdEmployee.TabIndex = 95;
        labelIdEmployee.Text = "Id Employee:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 16F);
        label.Location = new Point(19, 14);
        label.Name = "label";
        label.Size = new Size(167, 30);
        label.TabIndex = 89;
        label.Text = "Add New Order";
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.FromArgb(192, 255, 192);
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(202, 461);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(128, 55);
        buttonAdd.TabIndex = 81;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // richTextBoxIdClient
        // 
        richTextBoxIdClient.BorderStyle = BorderStyle.FixedSingle;
        richTextBoxIdClient.Font = new Font("Segoe UI", 12F);
        richTextBoxIdClient.Location = new Point(122, 306);
        richTextBoxIdClient.Name = "richTextBoxIdClient";
        richTextBoxIdClient.Size = new Size(209, 64);
        richTextBoxIdClient.TabIndex = 99;
        richTextBoxIdClient.Text = "";
        // 
        // labelIdClient
        // 
        labelIdClient.AutoSize = true;
        labelIdClient.Font = new Font("Segoe UI", 12F);
        labelIdClient.Location = new Point(20, 349);
        labelIdClient.Name = "labelIdClient";
        labelIdClient.Size = new Size(70, 21);
        labelIdClient.TabIndex = 98;
        labelIdClient.Text = "Id Client:";
        // 
        // richTextBoxIdAuto
        // 
        richTextBoxIdAuto.BorderStyle = BorderStyle.FixedSingle;
        richTextBoxIdAuto.Font = new Font("Segoe UI", 12F);
        richTextBoxIdAuto.Location = new Point(121, 222);
        richTextBoxIdAuto.Name = "richTextBoxIdAuto";
        richTextBoxIdAuto.Size = new Size(209, 64);
        richTextBoxIdAuto.TabIndex = 101;
        richTextBoxIdAuto.Text = "";
        // 
        // labelIdAuto
        // 
        labelIdAuto.AutoSize = true;
        labelIdAuto.Font = new Font("Segoe UI", 12F);
        labelIdAuto.Location = new Point(19, 265);
        labelIdAuto.Name = "labelIdAuto";
        labelIdAuto.Size = new Size(63, 21);
        labelIdAuto.TabIndex = 100;
        labelIdAuto.Text = "Id Auto:";
        // 
        // labelDeposit
        // 
        labelDeposit.AutoSize = true;
        labelDeposit.Font = new Font("Segoe UI", 12F);
        labelDeposit.Location = new Point(17, 172);
        labelDeposit.Name = "labelDeposit";
        labelDeposit.Size = new Size(66, 21);
        labelDeposit.TabIndex = 113;
        labelDeposit.Text = "Deposit:";
        // 
        // textBoxDeposit
        // 
        textBoxDeposit.Font = new Font("Segoe UI", 12F);
        textBoxDeposit.Location = new Point(120, 164);
        textBoxDeposit.Name = "textBoxDeposit";
        textBoxDeposit.Size = new Size(210, 29);
        textBoxDeposit.TabIndex = 112;
        // 
        // labelFinaleDate
        // 
        labelFinaleDate.AutoSize = true;
        labelFinaleDate.Font = new Font("Segoe UI", 12F);
        labelFinaleDate.Location = new Point(18, 128);
        labelFinaleDate.Name = "labelFinaleDate";
        labelFinaleDate.Size = new Size(82, 21);
        labelFinaleDate.TabIndex = 111;
        labelFinaleDate.Text = "Final Date:";
        // 
        // textBoxFinalDate
        // 
        textBoxFinalDate.Font = new Font("Segoe UI", 12F);
        textBoxFinalDate.Location = new Point(120, 120);
        textBoxFinalDate.Name = "textBoxFinalDate";
        textBoxFinalDate.Size = new Size(210, 29);
        textBoxFinalDate.TabIndex = 110;
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(17, 84);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 109;
        labelDate.Text = "Date:";
        // 
        // textBoxDate
        // 
        textBoxDate.Font = new Font("Segoe UI", 12F);
        textBoxDate.Location = new Point(120, 76);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(210, 29);
        textBoxDate.TabIndex = 108;
        // 
        // OrderAdd
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(labelDeposit);
        Controls.Add(textBoxDeposit);
        Controls.Add(labelFinaleDate);
        Controls.Add(textBoxFinalDate);
        Controls.Add(labelDate);
        Controls.Add(textBoxDate);
        Controls.Add(richTextBoxIdAuto);
        Controls.Add(labelIdAuto);
        Controls.Add(richTextBoxIdClient);
        Controls.Add(labelIdClient);
        Controls.Add(buttonBack);
        Controls.Add(richTextBoxIdEmployee);
        Controls.Add(labelIdEmployee);
        Controls.Add(label);
        Controls.Add(buttonAdd);
        Name = "OrderAdd";
        Size = new Size(350, 530);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonBack;
    private RichTextBox richTextBoxIdEmployee;
    private Label labelIdEmployee;
    private Label label;
    private Button buttonAdd;
    private RichTextBox richTextBoxIdClient;
    private Label labelIdClient;
    private RichTextBox richTextBoxIdAuto;
    private Label labelIdAuto;
    private Label labelDeposit;
    private TextBox textBoxDeposit;
    private Label labelFinaleDate;
    private TextBox textBoxFinalDate;
    private Label labelDate;
    private TextBox textBoxDate;
}
