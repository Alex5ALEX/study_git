using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Auto_Rent.Views.Report.OrderRep;
using Auto_Rent.Views.Report.FinanaceRep;
namespace Auto_Rent.Views.Report;

public partial class ReportControl : UserControl
{
    public ReportControl()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new AutoReport());
    }

    private void button2_Click(object sender, EventArgs e)
    {
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new OrderReport());
    }

    private void button4_Click(object sender, EventArgs e)
    {
        groupBox1.Controls.Clear();
        groupBox1.Controls.Add(new FinanceReport());
    }
}
