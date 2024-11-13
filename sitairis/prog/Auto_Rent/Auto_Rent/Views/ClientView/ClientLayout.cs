using Auto_Rent.Data;
using Auto_Rent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Rent.Views.ClientView;

internal class ClientLayout : UserControl
{
    ApplicationDbContext _context;

    public ClientLayout()
    {
        _context = new ApplicationDbContext();

        InitializeComponent();

        InitializeDataGridView();
    }


    private void InitializeDataGridView()
    {
        updateDataGridView();

        dataGridView1.CellBeginEdit += cell_event;
    }


    private void updateDataGridView()
    {
        var _auto = new BindingList<ClientEntity>(_context.Client.ToList());
        dataGridView1.DataSource = _auto;
    }



    private void cell_event(object? sender, DataGridViewCellCancelEventArgs e)
    {
        int lastRowIndex = e.RowIndex;

        // Проверяем, что индекс строки корректен
        if (lastRowIndex >= 0)
        {
            // Получаем значение Guid из ячейки "Id"
            var cellValue = dataGridView1.Rows[lastRowIndex].Cells["Id"].Value;

            // Проверяем, что значение не равно null
            if (cellValue != null && Guid.TryParse(cellValue.ToString(), out Guid GuidValue))
            {
                // Находим клиента по Id в контексте
                var client = _context.Client.Find(GuidValue);

                // Проверяем, существует ли клиент и его Id
                if (client != null && client.Id == GuidValue)
                {
                    // Логика, если Id совпадает
                    updateRow(lastRowIndex);
                }
                else
                {
                    addNewRow(lastRowIndex);
                }
            }
        }


        
        //throw new NotImplementedException();
    }


    private void addNewRow(int lastRowIndex)
    {
        ClientEntity client = new ClientEntity();
        /*
        if (dataGridView1.Rows[lastRowIndex].Cells["Name"].Value != null )
        {
            client.Name = dataGridView1.Rows[lastRowIndex].Cells["Name"].Value.ToString();
        }

        if (dataGridView1.Rows[lastRowIndex].Cells["Surname"].Value != null)
        {
            client.Surname = dataGridView1.Rows[lastRowIndex].Cells["Surname"].Value.ToString();
        }

        if (dataGridView1.Rows[lastRowIndex].Cells["Age"].Value != null &&
            int.TryParse(dataGridView1.Rows[lastRowIndex].Cells["Age"].Value.ToString(), out int AgeValue))
        {
            client.Age = AgeValue;
        }


        if (dataGridView1.Rows[lastRowIndex].Cells["Phone"].Value != null)
        {
            client.Phone = dataGridView1.Rows[lastRowIndex].Cells["Phone"].Value.ToString();
        }


        if (dataGridView1.Rows[lastRowIndex].Cells["Email"].Value != null)
        {
            client.Email = dataGridView1.Rows[lastRowIndex].Cells["Email"].Value.ToString();
        }


        if (dataGridView1.Rows[lastRowIndex].Cells["Addres"].Value != null)
        {
            client.Addres = dataGridView1.Rows[lastRowIndex].Cells["Addres"].Value.ToString();
        }*/


        if (dataGridView1.Rows[lastRowIndex].Cells["Name"].Value != null &&
            dataGridView1.Rows[lastRowIndex].Cells["Surname"].Value != null &&
            (dataGridView1.Rows[lastRowIndex].Cells["Age"].Value != null &&
            int.TryParse(dataGridView1.Rows[lastRowIndex].Cells["Age"].Value.ToString(), out int AgeValue)) &&
            dataGridView1.Rows[lastRowIndex].Cells["Phone"].Value != null &&
            dataGridView1.Rows[lastRowIndex].Cells["Email"].Value != null &&
            dataGridView1.Rows[lastRowIndex].Cells["Addres"].Value != null)
        {
            client.Name = dataGridView1.Rows[lastRowIndex].Cells["Name"].Value?.ToString();
            client.Surname = dataGridView1.Rows[lastRowIndex].Cells["Surname"].Value?.ToString();
            client.Age = AgeValue; // AgeValue уже определен в предыдущем условии
            client.Phone = dataGridView1.Rows[lastRowIndex].Cells["Phone"].Value?.ToString();
            client.Email = dataGridView1.Rows[lastRowIndex].Cells["Email"].Value?.ToString();
            client.Addres = dataGridView1.Rows[lastRowIndex].Cells["Addres"].Value?.ToString();
        }
        else
        {
            return;
        }
        _context.Client.Add(client);

        SaveChanges();
        updateDataGridView();
    }

    private void updateRow(int lastRowIndex)
    { 
    
    }




    private void SaveChanges()
    {
        // Сохранение изменений в базе данных
        _context.SaveChanges();
    }






    private void InitializeComponent()
    {
        label1 = new Label();
        button1 = new Button();
        dataGridView1 = new DataGridView();
        ((ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(29, 27);
        label1.Name = "label1";
        label1.Size = new Size(43, 15);
        label1.TabIndex = 0;
        label1.Text = "Clients";
        // 
        // button1
        // 
        button1.Location = new Point(496, 27);
        button1.Name = "button1";
        button1.Size = new Size(115, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(29, 63);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(582, 363);
        dataGridView1.TabIndex = 2;
        // 
        // ClientLayout
        // 
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "ClientLayout";
        Size = new Size(630, 450);
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private DataGridView dataGridView1;
    private Label label1;
}
