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
    private Guid _id { get; set; }
    private ClientControl _mainController;

    public ClientEdit(ClientControl _mainController, Guid Id)
    {
        this._mainController = _mainController;
        this._id = Id;

        InitializeComponent();
        InitializeData();


        buttonEdit.Click += editClient;
        buttonDelete.Click += deleteClient;
    }


    public void InitializeData()
    {
        var customer = _mainController._context.Client.FirstOrDefault(c => c.Id == _id);

        if (customer != null)
        {
            richTextBoxId.Text = _id.ToString();
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
        var customer = _mainController._context.Client.FirstOrDefault(c => c.Id == _id);

        if (customer != null)
        {
            customer.Name = textBoxName.Text;
            customer.Surname = textBoxSurname.Text;
            if (int.TryParse(textBoxAge.Text, out int result))
            {
                customer.Age = result;
            }
            customer.Phone = textBoxPhone.Text; 
            customer.Email = textBoxEmail.Text;
            customer.Addres = textBoxAddres.Text;

            _mainController._context.SaveChanges();
            _mainController.InitializeData();

        }

    }


    private void deleteClient(object sender, EventArgs e)
    {
        var customer = _mainController._context.Client.FirstOrDefault(c => c.Id == _id);

        if (customer != null)
        {
            _mainController._context.Remove(customer);
            _mainController._context.SaveChanges();
            _mainController.InitializeData();

            this.Visible = false;
        }


    }
}
