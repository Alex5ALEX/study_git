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


using Auto_Rent.Data;
namespace Auto_Rent.Views;

public partial class MainForm : Form
{
    private ApplicationDbContext _context;

    private AutoLayout _autoLayout;
    private ClientControl _clientControl;
    private EmployeeLayout _employeeLayout;
    private OrderLayout _orderLayout;
    private ProviderLayout _providerLayout;

    public MainForm()
    {
        _context = new ApplicationDbContext();

        InitializeComponent();
        InitializePages();

        this.FormClosing += new FormClosingEventHandler(CloseApplication);
    }

    private void InitializePages()
    {
        _autoLayout = new AutoLayout();
        _clientControl = new ClientControl();
        _employeeLayout = new EmployeeLayout();
        _orderLayout = new OrderLayout();
        _providerLayout = new ProviderLayout();


        tabPageAuto.Controls.Add(_autoLayout);
        tabPageClient.Controls.Add(_clientControl);
        tabPageEmployee.Controls.Add(_employeeLayout);
        tabPageOrder.Controls.Add(_orderLayout);
        tabPageProvider.Controls.Add(_providerLayout);

    }





    private void CloseApplication(object sender, FormClosingEventArgs e)
    {
        DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButtons.YesNo);

        // Если пользователь выбрал "Нет", отменяем закрытие
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }

        _context.SaveChanges();
    }


}
