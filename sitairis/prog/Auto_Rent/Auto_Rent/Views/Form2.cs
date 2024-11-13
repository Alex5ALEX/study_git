using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_Rent.Views.AutoView;
using Auto_Rent.Views.ClientView;
using Auto_Rent.Views.EmployeeView;
using Auto_Rent.Views.OrderView;
using Auto_Rent.Views.ProviderView;


namespace Auto_Rent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            buttonExit.Click += exitButton;

            buttonClient.Click += clientPanel;
            buttonOrder.Click += orderPanel;
            buttonAuto.Click += autoPanel;
            buttonProvider.Click += providerPanel;
            buttonEmployee.Click += employeePanel;


        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }



        private void clientPanel(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            var newLayout = new ClientLayout();

            groupBox2.Controls.Add(newLayout);

            return;
        }

        private void orderPanel(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            var newLayout = new OrderLayout(); 

            groupBox2.Controls.Add(newLayout);

            return;
        }

        private void autoPanel(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            var newLayout = new AutoLayout();

            groupBox2.Controls.Add(newLayout);
            
            return;
        }

        private void providerPanel(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            var newLayout = new ProviderLayout();

            groupBox2.Controls.Add(newLayout);

            return;
        }

        private void employeePanel(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();

            var newLayout = new EmployeeLayout();

            groupBox2.Controls.Add(newLayout);

            return;
        }

        


    }
}
