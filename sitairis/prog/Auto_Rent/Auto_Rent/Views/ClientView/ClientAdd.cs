using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_Rent.Models;
namespace Auto_Rent.Views.ClientView;

public partial class ClientAdd : UserControl
{
    private ClientControl _mainController;

    public ClientAdd(ClientControl _mainController)
    {
        this._mainController = _mainController;


        InitializeComponent();


        buttonAdd.Click += addClient;
    }





    private void addClient(object senser, EventArgs e)
    {
        var client = new ClientEntity() { 
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            Age = int.Parse(textBoxAge.Text),
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Addres = textBoxAddres.Text
        };

        _mainController._context.Client.Add(client);
        _mainController._context.SaveChanges();

        _mainController.InitializeData();

        textBoxName.Text = String.Empty;
        textBoxSurname.Text = String.Empty;
        textBoxAge.Text = String.Empty;
        textBoxPhone.Text = String.Empty;
        textBoxEmail.Text = String.Empty;
        textBoxAddres.Text = String.Empty  ;
    }
}
