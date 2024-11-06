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


            button1.Click += exitButton;
            button2.Click += clientPanel;
            button3.Click += orderPanel;
            button4.Click += autoPanel;
            button5.Click += providerPanel;
            button6.Click += employeePanel;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientPanel(object sender, EventArgs e)
        {

        }
        private void orderPanel(object sender, EventArgs e)
        {

        }

        private void autoPanel(object sender, EventArgs e)
        {

        }

        private void providerPanel(object sender, EventArgs e)
        {

        }

        private void employeePanel(object sendet, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
