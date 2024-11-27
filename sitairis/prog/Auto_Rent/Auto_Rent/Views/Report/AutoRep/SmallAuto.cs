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

namespace Auto_Rent.Views.Report.AutoRep;

public partial class SmallAuto : UserControl
{
    public SmallAuto(AutoEntity auto)
    {
        InitializeComponent();


        label4.Text = auto.Id.ToString();
        label5.Text = auto.Brand;
        label6.Text = auto.Model;
    }
}
