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


            




        }

        private void exitButton(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}
