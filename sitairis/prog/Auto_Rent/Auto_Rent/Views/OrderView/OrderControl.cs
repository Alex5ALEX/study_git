using Auto_Rent.Data;
using Auto_Rent.Views.AutoView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.OrderView;

public partial class OrderControl : UserControl
{
    public ApplicationDbContext _context;
    private OrderAdd _orderAdd;
    private OrderEdit _orderEdit;

    public OrderControl()
    {
        _context = new ApplicationDbContext();
        _orderAdd = new OrderAdd(this);

        InitializeComponent();
        InitializeData();

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }


    public void InitializeData()
    {
        dataGrid.Controls.Clear();
        var order = _context.Order.ToList();
        dataGrid.DataSource = order;
        dataGrid.Columns["Date"].DefaultCellStyle.Format = "dd-MM-yyyy";
        dataGrid.Columns["RentalPeriod"].DefaultCellStyle.Format = "dd-MM-yyyy";
        dataGrid.Columns["StartDeposit"].DefaultCellStyle.Format = "0.00";
        dataGrid.Columns["Auto"].Visible = false;
        dataGrid.Columns["Client"].Visible = false;
        dataGrid.Columns["Employee"].Visible = false;
    }


    private void Add(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        _orderAdd.visibility(true);
        groupBox.Controls.Add(_orderAdd);
    }

    private void Edit(object sender, EventArgs e)
    {

        if (dataGrid.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGrid.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _orderEdit = new OrderEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_orderEdit);
    }
}
