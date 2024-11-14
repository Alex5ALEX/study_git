using Auto_Rent.Views.AutoView;
using Auto_Rent.Views.ClientView;
using Auto_Rent.Views.EmployeeView;
using Auto_Rent.Views.OrderView;
using Auto_Rent.Views.ProviderView;




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Auto_Rent.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            InitializePages();


            this.FormClosing += new FormClosingEventHandler(CloseApplication);
        }

        private void InitializePages()
        {
            InitializePageAuto();
            InitializePageClient();
            InitializePageEmployee();
            InitializePageOrder();
            InitializePageProvider();
        }



        private void InitializePageProvider()
        {
            tabPage5.Controls.Clear();

            var newLayout = new ProviderLayout();

            tabPage5.Controls.Add(newLayout);
        }

        private void InitializePageOrder()
        {
            tabPage4.Controls.Clear();

            var newLayout = new OrderLayout();

            tabPage4.Controls.Add(newLayout);
        }

        private void InitializePageEmployee()
        {
            tabPage3.Controls.Clear();

            var newLayout = new EmployeeLayout();

            tabPage3.Controls.Add(newLayout);
        }

        private void InitializePageClient()
        {
            tabPage2.Controls.Clear();

            var newLayout = new ClientLayout();

            tabPage2.Controls.Add(newLayout);
        }

        private void InitializePageAuto()
        {
            tabPage1.Controls.Clear();

            var newLayout = new AutoLayout();

            tabPage1.Controls.Add(newLayout);
        }



        private void CloseApplication(object sender, FormClosingEventArgs e) {

            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.YesNo);

            // Если пользователь выбрал "Нет", отменяем закрытие
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

    }
}
