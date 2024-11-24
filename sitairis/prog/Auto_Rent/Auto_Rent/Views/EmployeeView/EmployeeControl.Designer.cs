using System.Windows.Forms;
using System.Xml.Linq;

namespace Auto_Rent.Views.EmployeeView;


partial class EmployeeControl
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
        dataGrid = new DataGridView();
        label1 = new Label();
        buttonAdd = new Button();
        buttonEdit = new Button();
        groupBox = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
        SuspendLayout();
        // 
        // dataGrid
        // 
        dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGrid.Location = new Point(399, 28);
        dataGrid.Name = "dataGrid";
        dataGrid.RowHeadersWidth = 47;
        dataGrid.Size = new Size(880, 662);
        dataGrid.TabIndex = 15;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F);
        label1.Location = new Point(31, 28);
        label1.Name = "label1";
        label1.Size = new Size(114, 30);
        label1.TabIndex = 13;
        label1.Text = "Employers";
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(17, 86);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(118, 40);
        buttonAdd.TabIndex = 16;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.Location = new Point(249, 86);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(118, 40);
        buttonEdit.TabIndex = 17;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // groupBox
        // 
        groupBox.Location = new Point(17, 132);
        groupBox.Name = "groupBox";
        groupBox.Size = new Size(350, 530);
        groupBox.TabIndex = 18;
        groupBox.TabStop = false;
        // 
        // EmployeeControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(buttonEdit);
        Controls.Add(groupBox);
        Controls.Add(buttonAdd);
        Controls.Add(dataGrid);
        Controls.Add(label1);
        Name = "EmployeeControl";
        Size = new Size(1265, 680);
        ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DataGridView dataGrid;
    private Label label1;
    private Button buttonAdd;
    private Button buttonEdit;
    private GroupBox groupBox;
}



