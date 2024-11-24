using Auto_Rent.Data;
using Auto_Rent.Views.EmployeeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.ProviderView;

public partial class ProviderControl : UserControl
{
    public ApplicationDbContext _context;
    private ProviderAdd _providerAdd;
    private ProviderEdit _providerEdit;

    public ProviderControl()
    {
        _context = new ApplicationDbContext();
        _providerAdd = new ProviderAdd(this);

        InitializeComponent();
        InitializeData();

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }


    public void InitializeData()
    {
        dataGrid.Controls.Clear();
        var providers = _context.Provider.ToList();
        dataGrid.DataSource = providers;
    }


    private void Add(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        _providerAdd.visibility(true);
        groupBox.Controls.Add(_providerAdd);
    }

    private void Edit(object sender, EventArgs e)
    {

        if (dataGrid.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGrid.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _providerEdit = new ProviderEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_providerEdit);
    }
}
