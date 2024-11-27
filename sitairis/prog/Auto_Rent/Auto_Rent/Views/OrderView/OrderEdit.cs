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

public partial class OrderEdit : UserControl
{
    private Guid _id { get; set; }
    private OrderControl _mainController;

    public OrderEdit(OrderControl _mainController, Guid Id)
    {
        this._mainController = _mainController;
        this._id = Id;

        InitializeComponent();
        InitializeData();


        buttonEdit.Click += edit;
        buttonDelete.Click += delete;
        buttonBack.Click += back;
    }


    public void InitializeData()
    {
        var order = _mainController._context.Order.FirstOrDefault(c => c.Id == _id);

        if (order != null)
        {
            richTextBoxId.Text = order.Id.ToString();
            richTextBoxIdAuto.Text = order.Id_Auto.ToString();
            richTextBoxIdClient.Text = order.Id_Client.ToString();
            richTextBoxIdEmployee.Text = order.Id_Employee.ToString();

            
            textBoxDeposit.Text = ((double)order.StartDeposit).ToString();
            
            textBoxDate.Text = order.Date.ToString("d M yyyy");
            textBoxFinalDate.Text = order.RentalPeriod.ToString("d M yyyy");
        }
    }

    private void edit(object sender, EventArgs e)
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
            if (_mainController._context.Auto.FirstOrDefault(a => a.Id == idAuto) == null)
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



        var order = _mainController._context.Order.FirstOrDefault(a => a.Id == _id);
        
        if(order== null) { return; }

        order.Date = date;
        order.RentalPeriod = rentalPeriod;
        order.StartDeposit = decimal.Parse(textBoxDeposit.Text);
        order.Id_Auto = idAuto;
        order.Id_Client = idClient;
        order.Id_Employee = idEmployee;

        _mainController._context.SaveChanges();

        _mainController.InitializeData();
    }


    private void delete(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want ot delete?", "Yes", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            return;
        }

        var order = _mainController._context.Order.FirstOrDefault(c => c.Id == _id);

        if (order != null)
        {
            _mainController._context.Remove(order);
            _mainController._context.SaveChanges();
            _mainController.InitializeData();

            this.Visible = false;
        }
    }


    private void back(object sender, EventArgs e)
    {
        this.Visible = false;
    }
}
