using Auto_Rent.Views.ClientView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.EmployeeView;

public partial class EmployeeEdit : UserControl
{

    private Guid _id { get; set; }
    private EmployeeControl _mainController;

    public EmployeeEdit(EmployeeControl _mainController, Guid Id)
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
        var employee = _mainController._context.Employee.FirstOrDefault(c => c.Id == _id);

        if (employee != null)
        {
            richTextBoxId.Text = _id.ToString();
            textBoxName.Text = employee?.Name;
            textBoxSurname.Text = employee?.Surname;
            textBoxJobtitle.Text = employee?.JobTitle;
            textBoxAge.Text = employee?.Age.ToString();
            textBoxPhone.Text = employee?.Phone.ToString();
            textBoxEmail.Text = employee?.Email;
            textBoxAddres.Text = employee?.Addres.ToString();
        }
    }

    private void edit(object sender, EventArgs e)
    {
        var employee = _mainController._context.Employee.FirstOrDefault(c => c.Id == _id);

        if (employee != null)
        {
            employee.Name = textBoxName.Text;
            employee.Surname = textBoxSurname.Text;
            employee.JobTitle = textBoxJobtitle.Text;
            if (int.TryParse(textBoxAge.Text, out int result))
            {
                employee.Age = result;
            }
            employee.Phone = textBoxPhone.Text;
            employee.Email = textBoxEmail.Text;
            employee.Addres = textBoxAddres.Text;

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


        var employee = _mainController._context.Employee.FirstOrDefault(c => c.Id == _id);

        if (employee != null)
        {
            _mainController._context.Remove(employee);
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
