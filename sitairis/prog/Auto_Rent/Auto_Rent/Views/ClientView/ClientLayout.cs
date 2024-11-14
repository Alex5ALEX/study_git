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


        button1.Click += SaveChanges;

    }

    private void SaveChanges(object? sender, EventArgs e)
    {



        //throw new NotImplementedException();
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        textBox5 = new TextBox();
        textBox6 = new TextBox();
        textBox7 = new TextBox();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        ((ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 28);
        label1.Name = "label1";
        label1.Size = new Size(50, 19);
        label1.TabIndex = 0;
        label1.Text = "Clients";
        // 
        // button1
        // 
        button1.Location = new Point(125, 533);
        button1.Name = "button1";
        button1.Size = new Size(115, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(385, 18);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 47;
        dataGridView1.Size = new Size(858, 662);
        dataGridView1.TabIndex = 2;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(172, 190);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(195, 26);
        textBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(172, 240);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(194, 26);
        textBox2.TabIndex = 4;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(172, 294);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(194, 26);
        textBox3.TabIndex = 5;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(172, 343);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(195, 26);
        textBox4.TabIndex = 6;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(172, 393);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(194, 26);
        textBox5.TabIndex = 7;
        // 
        // textBox6
        // 
        textBox6.Location = new Point(172, 445);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(195, 26);
        textBox6.TabIndex = 8;
        // 
        // textBox7
        // 
        textBox7.Location = new Point(34, 86);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(333, 26);
        textBox7.TabIndex = 9;
        // 
        // button2
        // 
        button2.Location = new Point(154, 118);
        button2.Name = "button2";
        button2.Size = new Size(86, 26);
        button2.TabIndex = 10;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(280, 118);
        button3.Name = "button3";
        button3.Size = new Size(86, 26);
        button3.TabIndex = 11;
        button3.Text = "button3";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(34, 118);
        button4.Name = "button4";
        button4.Size = new Size(86, 26);
        button4.TabIndex = 12;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        // 
        // ClientLayout
        // 
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(textBox7);
        Controls.Add(textBox6);
        Controls.Add(textBox5);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "ClientLayout";
        Size = new Size(1280, 700);
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private DataGridView dataGridView1;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private Button button2;
    private Button button3;
    private Button button4;
    private Label label1;
}
