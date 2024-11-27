using Auto_Rent.Views.AutoView;
using Auto_Rent.Views.ClientView;
using Auto_Rent.Views.EmployeeView;
using Auto_Rent.Views.OrderView;
using Auto_Rent.Views.ProviderView;


using Auto_Rent.Data;
using Auto_Rent.Views.Report;
namespace Auto_Rent.Views;

public partial class MainForm : Form
{
    private ApplicationDbContext _context;

    private AutoControl _autoControl;
    private ClientControl _clientControl;
    private EmployeeControl _employeeControl;
    private OrderControl _orderControl;
    private ProviderControl _providerControl;
    private ReportControl _reportControl;

    public MainForm()
    {
        _context = new ApplicationDbContext();

        InitializeComponent();
        InitializePages();

        this.FormClosing += new FormClosingEventHandler(CloseApplication);
    }

    private void InitializePages()
    {
        _autoControl = new AutoControl();
        _clientControl = new ClientControl();
        _employeeControl = new EmployeeControl();
        _orderControl = new OrderControl();
        _providerControl = new ProviderControl();
        _reportControl = new ReportControl();


        tabPageAuto.Controls.Add(_autoControl);
        tabPageClient.Controls.Add(_clientControl);
        tabPageEmployee.Controls.Add(_employeeControl);
        tabPageOrder.Controls.Add(_orderControl);
        tabPageProvider.Controls.Add(_providerControl);
        tabPageReport.Controls.Add(_reportControl);
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
