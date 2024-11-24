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

namespace Auto_Rent.Views.ProviderView;

public partial class ProviderEdit : UserControl
{

    private Guid _id { get; set; }
    private ProviderControl _mainController;

    public ProviderEdit(ProviderControl _mainController, Guid Id)
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
        var provider = _mainController._context.Provider.FirstOrDefault(c => c.Id == _id);

        if (provider != null)
        {
            richTextBoxId.Text = _id.ToString();
            textBoxName.Text = provider?.CompanyName;
            textBoxPhone.Text = provider?.Phone.ToString();
            textBoxEmail.Text = provider?.Email;
            textBoxAddres.Text = provider?.Addres.ToString();
        }
    }

    private void edit(object sender, EventArgs e)
    {
        var provider = _mainController._context.Provider.FirstOrDefault(c => c.Id == _id);

        if (provider != null)
        {
            provider.CompanyName = textBoxName.Text;
            provider.Phone = textBoxPhone.Text;
            provider.Email = textBoxEmail.Text;
            provider.Addres = textBoxAddres.Text;

            _mainController._context.SaveChanges();
            _mainController.InitializeData();

        }

    }


    private void delete(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Are you sure want ot delete?", "Yes", MessageBoxButtons.YesNo);

        if (result == DialogResult.No)
        {
            return;
        }

        var provider = _mainController._context.Provider.FirstOrDefault(c => c.Id == _id);

        if (provider != null)
        {
            _mainController._context.Remove(provider);
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
