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

namespace Lab9_2
{
    public partial class Form1 : Form
    {
        private double coeff; // Змінна для зберігання коефіцієнта
        public Form1()
        {
            InitializeComponent();

            // Очищення всіх серій і областей діаграми
            chart.Series.Clear();
            chart.ChartAreas.Clear();

            // Створення нової області діаграми
            ChartArea area = new ChartArea("Area1");

            // Встановлення мінімальних і максимальних значень для осей
            area.AxisX.Minimum = -10;
            area.AxisX.Maximum = 10;
            area.AxisY.Minimum = -10;
            area.AxisY.Maximum = 10;

            // Встановлення назв осей
            area.AxisX.Title = "X";
            area.AxisY.Title = "Y";

            // Додавання області до діаграми
            chart.ChartAreas.Add(area);

            // Створення нової серії даних
            Series series = new Series("Function");

            // Встановлення типу серії даних
            series.ChartType = SeriesChartType.Line;

            // Додавання серії до діаграми
            chart.Series.Add(series);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Перетворення значення з текстового поля в число і зберігання його в змінній coeff
            double.TryParse(textBoxCoeff.Text, out coeff);

            // Очищення всіх точок серії
            chart.Series[0].Points.Clear();

            // Розрахунок значень для серії даних
            for (double t = -Math.PI; t <= Math.PI; t += 0.01)
            {
                // Розрахунок значень X і Y за допомогою параметричних рівнянь
                double x = Math.Pow(t, 2) * Math.Sin(t);
                double y = t * Math.Pow(Math.Cos(t), 2);

                // Додавання точок до серії даних
                chart.Series[0].Points.AddXY(x * coeff, y * coeff);
            }
        }
    }
}
