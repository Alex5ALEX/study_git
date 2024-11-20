using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.ClientView;

public partial class ClientEdit : UserControl
{
    public Guid _id { get; set; } = new Guid();
    private ClientControl _mainController;

    public ClientEdit(ClientControl _mainController)
    {
        this._mainController = _mainController;


        InitializeComponent();
        //InitializeData();


        buttonEdit.Click += editClient;
    }


    public void InitializeData()
    {
        var customer = _mainController._context.Client.FirstOrDefault(c => c.Id == _id);

        if (customer != null)
        {
            textBoxName.Text = customer?.Name;
            textBoxSurname.Text = customer?.Surname;
            textBoxAge.Text = customer?.Age.ToString();
            textBoxPhone.Text = customer?.Phone.ToString();
            textBoxEmail.Text = customer?.Email;
            textBoxAddres.Text = customer?.Addres.ToString();
        }
    }

    private void editClient(object sender, EventArgs e)
    {
        //_mainController

    }
}
