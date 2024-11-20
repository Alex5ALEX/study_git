using System;
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
        _clientEdit = new ClientEdit(this);


        InitializeComponent();
        InitializeData();

        buttonAdd.Click += AddClient;
        buttonEdit.Click += EditClient;
        dataGridClient.SelectionChanged += changeSelected;
    }


    public void InitializeData()
    {
        dataGridClient.Controls.Clear();
        var clients = _context.Client.ToList();
        dataGridClient.DataSource = clients;
    }


    private void AddClient(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        groupBox.Controls.Add(_clientAdd);
    }

    private void EditClient(object sender, EventArgs e)
    {
        groupBox.Controls.Clear();
        groupBox.Controls.Add(_clientEdit);
    }



    private void changeSelected(object sender, EventArgs e)
    {
        /*
        if (dataGridClient.CurrentRow != null)
        {
            // Получаем выделенную строку
            var selectedRow = dataGridClient.CurrentRow;

            // Получаем данные из выделенной строки

            string id = selectedRow.Cells["Id"].Value.ToString();
            _clientEdit._id = Guid.Parse(id);
            _clientEdit.InitializeData();

            //MessageBox.Show($"Выделенная строка: ID = {id}, Name = {name}");
        }
        //_clientEdit._id*/
    }



}