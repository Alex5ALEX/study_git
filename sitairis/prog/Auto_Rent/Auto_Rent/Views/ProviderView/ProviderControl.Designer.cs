namespace Auto_Rent.Views.ProviderView
{
    partial class ProviderControl
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
            buttonEdit = new Button();
            groupBox = new GroupBox();
            buttonAdd = new Button();
            dataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(242, 77);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(118, 40);
            buttonEdit.TabIndex = 22;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Location = new Point(10, 123);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(350, 530);
            groupBox.TabIndex = 23;
            groupBox.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(10, 77);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(118, 40);
            buttonAdd.TabIndex = 21;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(375, 9);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 47;
            dataGrid.Size = new Size(880, 662);
            dataGrid.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 19;
            label1.Text = "Providers";
            // 
            // ProviderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonEdit);
            Controls.Add(groupBox);
            Controls.Add(buttonAdd);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Name = "ProviderControl";
            Size = new Size(1265, 680);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private GroupBox groupBox;
        private Button buttonAdd;
        private DataGridView dataGrid;
        private Label label1;
    }
}
