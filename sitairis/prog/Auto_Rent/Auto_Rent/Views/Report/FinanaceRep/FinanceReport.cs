using Auto_Rent.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Auto_Rent.Views.Report.FinanaceRep;

public partial class FinanceReport : UserControl
{
    private ApplicationDbContext _context;

    public FinanceReport()
    {
        _context = new ApplicationDbContext();

        InitializeComponent();
        InitializeData();
    }
    public void InitializeData()
    {
        InitGroup1();
        InitGroup2();
    }

    public void InitGroup1()
    {

        Dictionary<int, double> profitYear = new Dictionary<int, double>();

        double general = 0;
        var context2 = new ApplicationDbContext();
        foreach(var item in _context.Order)
        {
            double price = 0;

            if(context2.Auto.FirstOrDefault(a => a.Id == item.Id_Auto) == null)
            {
                continue;
            }
            else
            {
                price = (double)context2.Auto.FirstOrDefault(a => a.Id == item.Id_Auto).Price;
            }
 

            double rentCost = price * (item.RentalPeriod - item.Date).Days;
            general += rentCost;

            int Year = item.Date.Year;

            if (profitYear.ContainsKey(Year))
            {
                profitYear[Year] += rentCost;
            }
            else
            {
                profitYear.Add(Year, rentCost);
            }
        }


        label6.Text = general.ToString();

        // Настройка диаграммы
        chart2.Series.Clear();
        Series series = new Series
        {
            Name = "TotalProfitPerYear",
            Color = System.Drawing.Color.Green,
            ChartType = SeriesChartType.Bar // Столбчатая диаграмма
        };
        chart2.Series.Add(series);

        // Добавляем данные в диаграмму
        foreach (var item in profitYear)
        {
            series.Points.AddXY(item.Key, item.Value);
        }

        // Настройка осей
        chart2.ChartAreas[0].AxisX.Title = "Год";
        chart2.ChartAreas[0].AxisY.Title = "Общая прибыль";

        // Заголовок диаграммы
        chart2.Titles.Add("Общая прибыль по годам");




    }



    public void InitGroup2()
    {
        label3.Text = ((double)_context.Auto.Sum(a => a.Coast)).ToString();



        // Получаем общую стоимость автомобилей по годам
        var yearlyCost = _context.Auto
            .GroupBy(auto => auto.Year.Year) // Группируем по году
            .Select(g => new
            {
                Year = g.Key,
                TotalCost = g.Sum(auto => auto.Coast) // Суммируем стоимость
            })
            .ToList();

        // Настройка диаграммы
        chart1.Series.Clear();
        Series series = new Series
        {
            Name = "TotalCostPerYear",
            Color = System.Drawing.Color.Red,
            ChartType = SeriesChartType.Bar // Столбчатая диаграмма
        };
        chart1.Series.Add(series);

        // Добавляем данные в диаграмму
        foreach (var item in yearlyCost)
        {
            series.Points.AddXY(item.Year, item.TotalCost);
        }

        // Настройка осей
        chart1.ChartAreas[0].AxisX.Title = "Год";
        chart1.ChartAreas[0].AxisY.Title = "Общая стоимость";

        // Заголовок диаграммы
        chart1.Titles.Add("Общая стоимость автомобилей по годам");
    }
}
