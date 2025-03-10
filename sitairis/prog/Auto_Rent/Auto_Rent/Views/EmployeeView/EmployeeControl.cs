﻿using Auto_Rent.Data;
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

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }


    public void InitializeData()
    {
        dataGrid.Controls.Clear();
        var employers = _context.Employee.ToList();
        dataGrid.DataSource = employers;
    }


    private void Add(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        _employeeAdd.visibility(true);
        groupBox.Controls.Add(_employeeAdd);
    }

    private void Edit(object sender, EventArgs e)
    {

        if (dataGrid.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGrid.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _employeeEdit = new EmployeeEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_employeeEdit);
    }

}
