using Auto_Rent.Data;
using Auto_Rent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Rent.Views.AutoView;

internal class AutoLayout : UserControl
{

    ApplicationDbContext _context;

    public AutoLayout()
    {
        InitializeComponent();

        InitializeDataGridView();

    }



    private void InitializeDataGridView()
    {
        _context = new ApplicationDbContext();

        var _auto = new BindingList<AutoEntity>(_context.Auto.ToList());
        dataGridView1.DataSource = _auto;

        /*
        // Настройка DataGridView
        dataGridView1.Columns.Add("Id", "ID");
        dataGridView1.Columns.Add("Brand", "Бренд");
        dataGridView1.Columns.Add("Model", "Модель");
        dataGridView1.Columns.Add("Price", "Цена");
        dataGridView1.Columns.Add("Coast", "Стоимость");
        dataGridView1.Columns.Add("Condition", "Состояние");
        dataGridView1.Columns.Add("Year", "Год");
        dataGridView1.Columns.Add("Id_Provider", "ID Поставщика");

        // Заполнение данными
        LoadData();*/



        // Подписка на события
        dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        dataGridView1.RowValidated += DataGridView1_RowValidated;
    }

    private void DataGridView1_RowValidated(object? sender, DataGridViewCellEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void LoadData()
    {
        /*
        using (var context = new ApplicationDbContext())
        {
            var Auto = context.Auto.ToList();

            foreach (var item in Auto) {
                
                dataGridView1.Rows.Add(
                    item.Id,
                    item.Brand,
                    item.Model,
                    item.Price,
                    item.Coast,
                    item.Condition,
                    item.Year,
                    item.Id_Provider);

            }

            
            dataGridView1.ReadOnly = false;

        }*/


    }


    private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        // Если ячейка изменена, сохраняем изменения
        SaveChanges();
    }

    private void DataGridView1_RowValidated(object sender, DataGridViewCellCancelEventArgs e)
    {
        // Сохраняем изменения при завершении редактирования строки
        SaveChanges();
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
        label1.Size = new Size(33, 15);
        label1.TabIndex = 0;
        label1.Text = "Auto";
        // 
        // button1
        // 
        button1.Location = new Point(496, 27);
        button1.Name = "button1";
        button1.Size = new Size(115, 23);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(29, 63);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(582, 363);
        dataGridView1.TabIndex = 2;
        // 
        // AutoLayout
        // 
        Controls.Add(dataGridView1);
        Controls.Add(button1);
        Controls.Add(label1);
        Name = "AutoLayout";
        Size = new Size(630, 450);
        ((ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Button button1;
    private DataGridView dataGridView1;
    private Label label1;

    private void button1_Click(object sender, EventArgs e)
    {/*
        using (var context = new ApplicationDbContext())
        {
            foreach (AutoEntity auto in dataGridView1.DataSource)
            {
                context.Entry(auto).State = auto.Id == 0 ? EntityState.Added : EntityState.Modified;
            }
            context.SaveChanges();
        }*/
    }
}

