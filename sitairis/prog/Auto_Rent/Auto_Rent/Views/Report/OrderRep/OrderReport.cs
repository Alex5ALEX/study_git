using Auto_Rent.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Auto_Rent.Views.Report.OrderRep;


public partial class OrderReport : UserControl
{
    private ApplicationDbContext _context;


    public OrderReport()
    {
        _context = new ApplicationDbContext();
        
        InitializeComponent();
        InitializeData();

        SetupChart();

    }

    private void InitializeData()
    {
        foreach(var order in _context.Order)
        {
            flowLayoutPanel1.Controls.Add(new SmallOrder(order));

        }


        label6.Text = _context.Order.Count().ToString();

        double time = 0;

        foreach(var item in _context.Order)
        {
            time += (item.RentalPeriod - item.Date).Days;
        }



        label7.Text = (time/_context.Order.Count()).ToString() + "  days";
    }



    private void SetupChart()
    {
        // Получаем количество заказов по годам
        var orderCounts = _context.Order
            .GroupBy(o => o.Date.Year)
            .Select(g => new
            {
                Year = g.Key,
                Count = g.Count()
            })
            .ToList();

        // Настройка диаграммы
        chart1.Series.Clear();
        Series series = new Series
        {
            Name = "OrdersPerYear",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Bar // Используем горизонтальную диаграмму
        };
        chart1.Series.Add(series);

        // Добавляем данные в диаграмму
        foreach (var item in orderCounts)
        {
            series.Points.AddXY(item.Year, item.Count);
        }

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Год";
        chart1.ChartAreas[0].AxisY.Title = "Количество заказов";

        // Заголовок диаграммы
        chart1.Titles.Add("Количество заказов по годам");
    }
}

