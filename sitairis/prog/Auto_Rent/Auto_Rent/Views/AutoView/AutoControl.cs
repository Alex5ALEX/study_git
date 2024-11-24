using Auto_Rent.Data;
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

namespace Auto_Rent.Views.AutoView;

public partial class AutoControl : UserControl
{
    public ApplicationDbContext _context;
    private AutoAdd _autoAdd;
    private AutoEdit _autoEdit;

    public AutoControl()
    {
        _context = new ApplicationDbContext();
        _autoAdd = new AutoAdd(this);

        InitializeComponent();
        InitializeData();

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }


    public void InitializeData()
    {
        dataGrid.Controls.Clear();
        var auto = _context.Auto.ToList();
        dataGrid.DataSource = auto;
        dataGrid.Columns["Price"].DefaultCellStyle.Format = "0.00";
        dataGrid.Columns["Coast"].DefaultCellStyle.Format = "0.00";
        dataGrid.Columns["Year"].DefaultCellStyle.Format = "yyyy";
        dataGrid.Columns["Provider"].Visible = false;
    }


    private void Add(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        _autoAdd.visibility(true);
        groupBox.Controls.Add(_autoAdd);
    }

    private void Edit(object sender, EventArgs e)
    {

        if (dataGrid.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGrid.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _autoEdit = new AutoEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_autoEdit);
    }
}
