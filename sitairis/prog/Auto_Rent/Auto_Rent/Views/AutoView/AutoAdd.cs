using Auto_Rent.Models;
using Auto_Rent.Views.ProviderView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.AutoView;

public partial class AutoAdd : UserControl
{
    private AutoControl _mainController;

    public AutoAdd(AutoControl _mainController)
    {
        this._mainController = _mainController;

        InitializeComponent();

        buttonAdd.Click += add;
        buttonBack.Click += back;
    }


    private void add(object senser, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxBrand.Text) ||
        string.IsNullOrWhiteSpace(textBoxModel.Text) ||
        string.IsNullOrWhiteSpace(textBoxPrice.Text) ||
        string.IsNullOrWhiteSpace(textBoxCoast.Text) ||
        string.IsNullOrWhiteSpace(textBoxCondition.Text) ||
        string.IsNullOrWhiteSpace(textBoxYear.Text) ||
        string.IsNullOrWhiteSpace(richTextBoxIdProvider.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }


        DateTime dateTime = DateTime.Now;

        DateTime.TryParseExact(textBoxYear.Text, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);


        Guid idProvider = Guid.Empty;

        if (!Guid.TryParse(richTextBoxIdProvider.Text, out idProvider))
        {
            MessageBox.Show("id provider incorrect input");
            return;
        }

        var provider = _mainController._context.Provider.FirstOrDefault(c => c.Id == idProvider);

        if (provider == null)
        {
            MessageBox.Show("id provider with this id does not exist");
            return;
        }


        var auto = new AutoEntity()
        {
            Brand = textBoxBrand.Text,
            Model = textBoxModel.Text,
            Price = decimal.Parse(textBoxPrice.Text),
            Coast = decimal.Parse(textBoxCoast.Text),
            Condition = textBoxCondition.Text,
            Year = dateTime,
            Id_Provider = idProvider
            
        };

        _mainController._context.Auto.Add(auto);
        _mainController._context.SaveChanges();

        _mainController.InitializeData();


        textBoxBrand.Text = string.Empty;
        textBoxModel.Text = string.Empty;
        textBoxPrice.Text = string.Empty;
        textBoxCoast.Text = string.Empty;
        textBoxCondition.Text = string.Empty;
        textBoxYear.Text = string.Empty;
        richTextBoxIdProvider.Text = string.Empty;
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
