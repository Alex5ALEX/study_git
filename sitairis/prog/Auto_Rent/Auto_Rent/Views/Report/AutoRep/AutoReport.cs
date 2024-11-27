using Auto_Rent.Data;
using Auto_Rent.Views.Report.AutoRep;
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

namespace Auto_Rent.Views.Report;

public partial class AutoReport : UserControl
{
    private ApplicationDbContext _context;


    public AutoReport()
    {
        _context = new ApplicationDbContext();
        
        InitializeComponent();
        InitializeData();

        SetupChart();

    }

    private void InitializeData()
    {
        foreach(var auto in _context.Auto)
        {
            flowLayoutPanel1.Controls.Add(new SmallAuto(auto));

        }


        label6.Text = _context.Auto.Count().ToString();
        label7.Text = ((double)_context.Auto.Sum( a => a.Coast)).ToString();
    }



    private void SetupChart()
    {
        var data = _context.Auto
            .GroupBy(a => a.Year)
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
            Name = "CarsPerYear",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Bar
        };
        chart1.Series.Add(series);

        // Добавляем данные в диаграмму
        foreach (var item in data)
        {
            series.Points.AddXY(item.Year, item.Count);
        }

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Год выпуска";
        chart1.ChartAreas[0].AxisY.Title = "Количество машин";

        // Заголовок диаграммы
        chart1.Titles.Add("Количество машин по годам выпуска");
    }
}
