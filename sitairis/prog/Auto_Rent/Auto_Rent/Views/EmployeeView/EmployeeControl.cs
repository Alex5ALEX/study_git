using Auto_Rent.Data;
using Auto_Rent.Views.ClientView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.EmployeeView;

public partial class EmployeeControl : UserControl
{
    public ApplicationDbContext _context;
    private EmployeeAdd _employeeAdd;
    private EmployeeEdit _employeeEdit;

    public EmployeeControl()
    {
        _context = new ApplicationDbContext();
        _employeeAdd = new EmployeeAdd(this);
        //_clientEdit = new ClientEdit(this);


        InitializeComponent();
        InitializeData();

        buttonAdd.Click += AddEmployee;
        buttonEdit.Click += EditEmployee;
    }


    public void InitializeData()
    {
        dataGridEmployee.Controls.Clear();
        var employers = _context.Employee.ToList();
        dataGridEmployee.DataSource = employers;
    }


    private void AddEmployee(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        groupBox.Controls.Add(_clientAdd);
    }

    private void EditEmployee(object sender, EventArgs e)
    {

        if (dataGridEmployee.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGridEmployee.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _employeeEdit = new ClientEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_clientEdit);
    }
}
