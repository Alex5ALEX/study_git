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

namespace Auto_Rent;

internal class AutoLayout : UserControl
{
    public AutoLayout()
    {
        InitializeComponent();


        using (var context = new ApplicationDbContext())
        {
            var Auto = context.Auto.ToList();
            dataGridView1.DataSource = Auto;
        }





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

