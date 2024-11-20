namespace Auto_Rent.Views.ClientView
{
    partial class ClientControl
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
            dataGridClient = new DataGridView();
            label1 = new Label();
            buttonAdd = new Button();
            buttonEdit = new Button();
            groupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridClient).BeginInit();
            SuspendLayout();
            // 
            // dataGridClient
            // 
            dataGridClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClient.Location = new Point(437, 16);
            dataGridClient.Margin = new Padding(3, 4, 3, 4);
            dataGridClient.Name = "dataGridClient";
            dataGridClient.RowHeadersWidth = 47;
            dataGridClient.Size = new Size(1006, 839);
            dataGridClient.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(88, 35);
            label1.TabIndex = 13;
            label1.Text = "Clients";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(19, 103);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 51);
            buttonAdd.TabIndex = 16;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(285, 103);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(135, 51);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Location = new Point(19, 161);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(400, 670);
            groupBox.TabIndex = 18;
            groupBox.TabStop = false;
            // 
            // ClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonEdit);
            Controls.Add(groupBox);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridClient);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientControl";
            Size = new Size(1446, 861);
            ((System.ComponentModel.ISupportInitialize)dataGridClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridClient;
        private Label label1;
        private Button buttonAdd;
        private Button buttonEdit;
        private GroupBox groupBox;
    }
}
