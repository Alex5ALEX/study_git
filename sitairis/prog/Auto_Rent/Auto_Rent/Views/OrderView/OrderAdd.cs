using Auto_Rent.Models;
using Auto_Rent.Views.AutoView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.OrderView;

public partial class OrderAdd : UserControl
{
    private OrderControl _mainController;

    public OrderAdd(OrderControl _mainController)
    {
        this._mainController = _mainController;

        InitializeComponent();

        buttonAdd.Click += add;
        buttonBack.Click += back;
    }


    private void add(object senser, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(richTextBoxIdAuto.Text) ||
        string.IsNullOrWhiteSpace(richTextBoxIdClient.Text) ||
        string.IsNullOrWhiteSpace(richTextBoxIdEmployee.Text) ||
        string.IsNullOrWhiteSpace(textBoxDate.Text) ||
        string.IsNullOrWhiteSpace(textBoxFinalDate.Text) ||
        string.IsNullOrWhiteSpace(textBoxDeposit.Text))
        {
            MessageBox.Show("Пожалуйста, заполните все поля.");
            return;
        }




        DateTime date = DateTime.Now;
        DateTime rentalPeriod = DateTime.Now;

        if (!DateTime.TryParseExact(textBoxDate.Text, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
        {
            MessageBox.Show("Date incorrect input. Input date in format dd MM yyyy");
            return;
        }

        if (!DateTime.TryParseExact(textBoxFinalDate.Text, "d M yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out rentalPeriod))
        {
            MessageBox.Show("Date incorrect input. Input date in format dd MM yyyy");
            return;
        }



        Guid idAuto = Guid.Empty;
        Guid idClient = Guid.Empty;
        Guid idEmployee = Guid.Empty;

        if (!Guid.TryParse(richTextBoxIdAuto.Text, out idAuto))
        {
            MessageBox.Show("id Auto incorrect input");
            return;
        }
        else
        {
            if(_mainController._context.Auto.FirstOrDefault(a => a.Id == idAuto) == null)
            {
                MessageBox.Show("this Auto does not exist");
                return;
            }
        }


        if (!Guid.TryParse(richTextBoxIdClient.Text, out idClient))
        {
            MessageBox.Show("id Client incorrect input");
            return;
        }
        else
        {
            if (_mainController._context.Client.FirstOrDefault(a => a.Id == idClient) == null)
            {
                MessageBox.Show("this Client does not exist");
                return;
            }
        }


        if (!Guid.TryParse(richTextBoxIdEmployee.Text, out idEmployee))
        {
            MessageBox.Show("id Employee incorrect input");
            return;
        }
        else
        {
            if (_mainController._context.Employee.FirstOrDefault(a => a.Id == idEmployee) == null)
            {
                MessageBox.Show("this Employee does not exist");
                return;
            }
        }



        var order = new OrderEntity()
        {
            Date = date,
            RentalPeriod = rentalPeriod,
            StartDeposit = decimal.Parse(textBoxDeposit.Text),
            Id_Auto = idAuto,
            Id_Client = idClient,
            Id_Employee = idEmployee
        };

        _mainController._context.Order.Add(order);
        _mainController._context.SaveChanges();

        _mainController.InitializeData();


        richTextBoxIdAuto.Text = string.Empty;
        richTextBoxIdClient.Text = string.Empty;
        richTextBoxIdEmployee.Text = string.Empty;
        textBoxDate.Text = string.Empty;
        textBoxFinalDate.Text = string.Empty;
        textBoxDeposit.Text = string.Empty;
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
