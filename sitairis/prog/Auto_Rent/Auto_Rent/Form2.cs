using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return;
        }
        private void orderPanel(object sender, EventArgs e)
        {
            return;
        }

        private void autoPanel(object sender, EventArgs e)
        {
            // Удалите текущий Layout
            //this.Controls.Clear();

            // Добавьте новый Layout
            var newLayout = new AutoLayout();
            newLayout.Dock = DockStyle.Fill; // Для адаптивности
            groupBox2.Controls.Add(newLayout);
            //this.Controls.Add(newLayout);
            return;
        }

        private void providerPanel(object sender, EventArgs e)
        {
            return;
        }

        private void employeePanel(object sendet, EventArgs e)
        {
            return;
        }



    }
}
