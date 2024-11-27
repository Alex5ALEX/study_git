using Auto_Rent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.Report.OrderRep;

public partial class SmallOrder : UserControl
{
    public SmallOrder(OrderEntity oreder)
    {
        InitializeComponent();


        label4.Text = oreder.Id.ToString();
        label5.Text = oreder.Date.ToString("dd MM yyyy") + "  -  " +oreder.RentalPeriod.ToString("dd MM yyyy");
        label6.Text = ((double)oreder.StartDeposit).ToString();
    }
}
