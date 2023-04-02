using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання дати з текстового поля та розбиття її на складові
            string dateString = textBoxDate.Text;
            string[] dateParts = dateString.Split('.');
            int year = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int day = int.Parse(dateParts[2]);

            // Обчислення дня тижня за допомогою методу DateTime.DayOfWeek
            DateTime date = new DateTime(year, month, day);
            DayOfWeek dayOfWeek = date.DayOfWeek;

            // Вивід результату в текстове поле
            lblResult.Text = dayOfWeek.ToString();
        }
    }
}
