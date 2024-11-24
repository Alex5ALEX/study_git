using Auto_Rent.Views.ProviderView;
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

namespace Auto_Rent.Views.AutoView;

public partial class AutoEdit : UserControl
{
    private Guid _id { get; set; }
    private AutoControl _mainController;

    public AutoEdit(AutoControl _mainController, Guid Id)
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
        var auto = _mainController._context.Auto.FirstOrDefault(c => c.Id == _id);

        if (auto != null)
        {
            richTextBoxId.Text = auto.Id.ToString();
            textBoxBrand.Text = auto.Brand;
            textBoxModel.Text = auto.Model;
            textBoxPrice.Text = ((double)auto.Price).ToString();
            textBoxCoast.Text = ((double)auto.Coast).ToString();
            textBoxCondition.Text = auto.Condition;
            textBoxYear.Text = auto.Year.Year.ToString();
            richTextBoxIdProvider.Text = auto.Id_Provider.ToString();
        }
    }

    private void edit(object sender, EventArgs e)
    {
        var auto = _mainController._context.Auto.FirstOrDefault(c => c.Id == _id);

        if (auto == null) { return;}

        auto.Brand = textBoxBrand.Text;
        auto.Model = textBoxModel.Text;
        auto.Condition = textBoxCondition.Text;

        decimal price;
        if(decimal.TryParse(textBoxPrice.Text,out price)) { auto.Price = price; }

        decimal coast;
        if (decimal.TryParse(textBoxCoast.Text, out coast)) { auto.Coast = coast; }

        DateTime year = DateTime.Now;
        if(DateTime.TryParseExact(textBoxYear.Text, "yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out year))
        {
            auto.Year = year;
        }

        Guid idProvider = Guid.Empty;
        if (Guid.TryParse(richTextBoxIdProvider.Text, out idProvider))
        {
            if (_mainController._context.Provider.FirstOrDefault(c => c.Id == idProvider) != null)
            {
                auto.Id_Provider = idProvider;
            }
        }

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

        var auto = _mainController._context.Auto.FirstOrDefault(c => c.Id == _id);

        if (auto != null)
        {
            _mainController._context.Remove(auto);
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
