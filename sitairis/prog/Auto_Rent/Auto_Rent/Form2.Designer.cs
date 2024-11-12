namespace Auto_Rent
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            clientEntityBindingSource = new BindingSource(components);
            applicationDbContextBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            buttonExit = new Button();
            buttonAuto = new Button();
            buttonClient = new Button();
            buttonEmployee = new Button();
            buttonProvider = new Button();
            buttonOrder = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(784, 461);
            splitContainer1.SplitterDistance = 136;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(buttonOrder);
            groupBox1.Controls.Add(buttonProvider);
            groupBox1.Controls.Add(buttonEmployee);
            groupBox1.Controls.Add(buttonClient);
            groupBox1.Controls.Add(buttonAuto);
            groupBox1.Controls.Add(buttonExit);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 468);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(6, 423);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonAuto
            // 
            buttonAuto.Location = new Point(0, 83);
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Size = new Size(130, 23);
            buttonAuto.TabIndex = 1;
            buttonAuto.Text = "Auto";
            buttonAuto.UseVisualStyleBackColor = true;
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(0, 112);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(130, 23);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "Clients";
            buttonClient.UseVisualStyleBackColor = true;
            // 
            // buttonEmployee
            // 
            buttonEmployee.Location = new Point(0, 141);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(130, 23);
            buttonEmployee.TabIndex = 3;
            buttonEmployee.Text = "Employee";
            buttonEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonProvider
            // 
            buttonProvider.Location = new Point(0, 170);
            buttonProvider.Name = "buttonProvider";
            buttonProvider.Size = new Size(130, 23);
            buttonProvider.TabIndex = 4;
            buttonProvider.Text = "Providers";
            buttonProvider.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(0, 199);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(130, 23);
            buttonOrder.TabIndex = 5;
            buttonOrder.Text = "Orders";
            buttonOrder.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 458);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            Name = "Form2";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)applicationDbContextBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private BindingSource applicationDbContextBindingSource;
        private BindingSource clientEntityBindingSource;
        private GroupBox groupBox1;
        private Button buttonOrder;
        private Button buttonProvider;
        private Button buttonEmployee;
        private Button buttonClient;
        private Button buttonAuto;
        private Button buttonExit;
        private GroupBox groupBox2;
    }
}