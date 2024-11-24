using Auto_Rent.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Auto_Rent.Views.ProviderView;

public partial class ProviderAdd : UserControl
{

    private ProviderControl _mainController;

    public ProviderAdd(ProviderControl _mainController)
    {
        this._mainController = _mainController;

        InitializeComponent();

        buttonAdd.Click += add;
        buttonBack.Click += back;
    }


    private void add(object senser, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
        string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
        string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
        string.IsNullOrWhiteSpace(textBoxAddres.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }

        var provider = new ProviderEntity()
        {
            CompanyName = textBoxName.Text,
            Phone = textBoxPhone.Text,
            Email = textBoxEmail.Text,
            Addres = textBoxAddres.Text
        };

        _mainController._context.Provider.Add(provider);
        _mainController._context.SaveChanges();

        _mainController.InitializeData();


        textBoxName.Text = string.Empty;
        textBoxPhone.Text = string.Empty;
        textBoxEmail.Text = string.Empty;
        textBoxAddres.Text = string.Empty;
    }


    public void visibility(bool temp)
    {
        if (temp) { this.Visible = true; }
        else { this.Visible = false; }
    }

    private void back(object senser, EventArgs e)
    {
        visibility(false);
    }

}
