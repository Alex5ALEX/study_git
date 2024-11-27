namespace Auto_Rent.Views
{
    partial class MainForm 
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            tabPageMain = new TabControl();
            tabPageAuto = new TabPage();
            tabPageClient = new TabPage();
            tabPageEmployee = new TabPage();
            tabPageOrder = new TabPage();
            tabPageProvider = new TabPage();
            tabPageReport = new TabPage();
            tabPageMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(tabPageAuto);
            tabPageMain.Controls.Add(tabPageClient);
            tabPageMain.Controls.Add(tabPageEmployee);
            tabPageMain.Controls.Add(tabPageOrder);
            tabPageMain.Controls.Add(tabPageProvider);
            tabPageMain.Controls.Add(tabPageReport);
            tabPageMain.Font = new Font("Segoe UI", 10F);
            tabPageMain.Location = new Point(0, 0);
            tabPageMain.Margin = new Padding(3, 2, 3, 2);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.SelectedIndex = 0;
            tabPageMain.Size = new Size(1265, 680);
            tabPageMain.TabIndex = 0;
            // 
            // tabPageAuto
            // 
            tabPageAuto.Location = new Point(4, 26);
            tabPageAuto.Margin = new Padding(3, 2, 3, 2);
            tabPageAuto.Name = "tabPageAuto";
            tabPageAuto.Padding = new Padding(3, 2, 3, 2);
            tabPageAuto.Size = new Size(1257, 650);
            tabPageAuto.TabIndex = 0;
            tabPageAuto.Text = "Auto";
            tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            tabPageClient.Location = new Point(4, 26);
            tabPageClient.Margin = new Padding(3, 2, 3, 2);
            tabPageClient.Name = "tabPageClient";
            tabPageClient.Padding = new Padding(3, 2, 3, 2);
            tabPageClient.Size = new Size(1257, 650);
            tabPageClient.TabIndex = 1;
            tabPageClient.Text = "Client";
            tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployee
            // 
            tabPageEmployee.Location = new Point(4, 26);
            tabPageEmployee.Margin = new Padding(3, 2, 3, 2);
            tabPageEmployee.Name = "tabPageEmployee";
            tabPageEmployee.Padding = new Padding(3, 2, 3, 2);
            tabPageEmployee.Size = new Size(1257, 650);
            tabPageEmployee.TabIndex = 1;
            tabPageEmployee.Text = "Employee";
            tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // tabPageOrder
            // 
            tabPageOrder.Location = new Point(4, 26);
            tabPageOrder.Margin = new Padding(3, 2, 3, 2);
            tabPageOrder.Name = "tabPageOrder";
            tabPageOrder.Padding = new Padding(3, 2, 3, 2);
            tabPageOrder.Size = new Size(1257, 650);
            tabPageOrder.TabIndex = 1;
            tabPageOrder.Text = "Order";
            tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageProvider
            // 
            tabPageProvider.Location = new Point(4, 26);
            tabPageProvider.Margin = new Padding(3, 2, 3, 2);
            tabPageProvider.Name = "tabPageProvider";
            tabPageProvider.Padding = new Padding(3, 2, 3, 2);
            tabPageProvider.Size = new Size(1257, 650);
            tabPageProvider.TabIndex = 1;
            tabPageProvider.Text = "Provider";
            tabPageProvider.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            tabPageReport.Location = new Point(4, 26);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Padding = new Padding(3);
            tabPageReport.Size = new Size(1257, 650);
            tabPageReport.TabIndex = 2;
            tabPageReport.Text = "Report";
            tabPageReport.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tabPageMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainFomr";
            tabPageMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPageMain;
        private TabPage tabPageAuto;
        private TabPage tabPageClient;
        private TabPage tabPageEmployee;
        private TabPage tabPageOrder;
        private TabPage tabPageProvider;
        private TabPage tabPageReport;
    }
}