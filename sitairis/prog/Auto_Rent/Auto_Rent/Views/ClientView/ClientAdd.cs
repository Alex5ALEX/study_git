﻿using Auto_Rent.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Auto_Rent.Views.ClientView;

public partial class ClientAdd : UserControl
{
    private ClientControl _mainController;

    public ClientAdd(ClientControl _mainController)
    {
        this._mainController = _mainController;


        InitializeComponent();


        buttonAdd.Click += addClient;
        buttonBack.Click += back;
    }





    private void addClient(object senser, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxSurname.Text) ||
        string.IsNullOrWhiteSpace(textBoxAge.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        int age = 0;

        if(!int.TryParse(textBoxAge.Text, out age))
        {
            MessageBox.Show("Возрост введен не верно!");
            return;
        }

        var client = new ClientEntity() { 
            Name = textBoxName.Text,
            Surname = textBoxSurname.Text,
            Age = age,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Addres = textBoxAddres.Text
        };

        _mainController._context.Client.Add(client);
        _mainController._context.SaveChanges();

        _mainController.InitializeData();

        textBoxName.Text = string.Empty;
        textBoxSurname.Text = string.Empty;
        textBoxAge.Text = string.Empty;
        textBoxPhone.Text = string.Empty;
        textBoxEmail.Text = string.Empty;
        textBoxAddres.Text = string.Empty;
    }


    public void visibility(bool temp)
    {
        if (temp){this.Visible = true;}
        else { this.Visible = false; }
    }

    private void back(object senser, EventArgs e)
    { 
       visibility(false);
    }

}
