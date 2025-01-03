﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Auto_Rent.Data;
namespace Auto_Rent.Views.ClientView;

public partial class ClientControl : UserControl
{
    public ApplicationDbContext _context;
    private ClientAdd _clientAdd;
    private ClientEdit _clientEdit;

    public ClientControl()
    {
        _context = new ApplicationDbContext();
        _clientAdd = new ClientAdd(this);
        //_clientEdit = new ClientEdit(this);


        InitializeComponent();
        InitializeData();

        buttonAdd.Click += Add;
        buttonEdit.Click += Edit;
    }


    public void InitializeData()
    {
        dataGrid.Controls.Clear();
        var clients = _context.Client.ToList();
        dataGrid.DataSource = clients;
    }


    private void Add(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        _clientAdd.visibility(true);
        groupBox.Controls.Add(_clientAdd);
    }

    private void Edit(object sender, EventArgs e)
    {

        if (dataGrid.CurrentRow == null)
        {
            return;
        }

        var selectedRow = dataGrid.CurrentRow;


        Guid Id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

        _clientEdit = new ClientEdit(this, Id);

        groupBox.Controls.Clear();
        groupBox.Controls.Add(_clientEdit);
    }


}