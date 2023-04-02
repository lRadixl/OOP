using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Введення користувача для 1D масиву
            int[] arr1D = Array.Empty<int>();
            string input = Interaction.InputBox("Введіть 1D-масив, розділивши елементи пробілами:");
            try
            {
                arr1D = Array.ConvertAll(input.Split(' '), int.Parse);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильні дані! Будь ласка, введіть цілі числа, розділені пробілами.");
                return;
            }

            // Задача а) - розрахувати max елемент за модулем
            int max = Math.Abs(arr1D[0]);
            for (int i = 1; i < arr1D.Length; i++)
            {
                int absValue = Math.Abs(arr1D[i]);
                if (absValue > max)
                {
                    max = absValue;
                }
            }
            string maxAbsValueStr = $"Максимальний елемент за абсолютною величиною: {max} \n";

            // Задача b) - обчислити суму елементів між першим і другим додатними елементами
            int sum = 0;
            bool firstPositiveFound = false;
            for (int i = 0; i < arr1D.Length; i++)
            {
                if (arr1D[i] > 0)
                {
                    if (!firstPositiveFound)
                    {
                        firstPositiveFound = true;
                    }
                    else
                    {
                        for (int j = i - 1; j >= 0 && arr1D[j] > 0; j--)
                        {
                            sum += arr1D[j];
                        }
                        break;
                    }
                }
            }
            string sumBetweenPositivesStr = $"Сума елементів між першим і другим позитивними елементами: {sum} \n";

            // Перетворення масиву шляхом переміщення нулів у кінець
            int zeroCount = 0;
            for (int i = 0; i < arr1D.Length; i++)
            {
                if (arr1D[i] == 0)
                {
                    zeroCount++;
                }
                else if (zeroCount > 0)
                {
                    arr1D[i - zeroCount] = arr1D[i];
                    arr1D[i] = 0;
                }
            }
            string transformedArrStr = $"Трансформований масив: {string.Join(" ", arr1D)}";

            // Показувати результати у вікнах повідомлень
            string message = string.Join(maxAbsValueStr, sumBetweenPositivesStr, transformedArrStr);
            MessageBox.Show(message);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Введення користувача для 2D масиву
            int rows = 0;
            int columns = 0;
            string[,] arr2D = null;

            while (true)
            {
                string inputRows = Interaction.InputBox("Введіть кількість рядків у масиві:");
                if (int.TryParse(inputRows, out rows))
                {
                    break;
                }
                MessageBox.Show("Неправильні дані! Введіть дійсне ціле число для кількості рядків.");
            }

            while (true)
            {
                string inputColumns = Interaction.InputBox("Введіть кількість стовпців у масиві:");
                if (int.TryParse(inputColumns, out columns))
                {
                    break;
                }
                MessageBox.Show("Неправильні дані! Введіть дійсне ціле число для кількості стовпців.");
            }

            arr2D = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    string inputElement = Interaction.InputBox($"Введіть елемент ({i + 1}, {j + 1}):");
                    arr2D[i, j] = inputElement;
                }
            }

            // Завдання 2а - обчислити суму будь-яких двох елементів у другому рядку
            int rowSum = int.Parse(arr2D[1, 0]) + int.Parse(arr2D[1, columns - 1]);
            string rowSumStr = $"Сума будь-яких двох елементів у другому рядку: {rowSum} \n";

            // Завдання 2б – обчислити добуток будь-яких двох елементів п’ятого стовпця
            int colProduct = int.Parse(arr2D[0, 4]) * int.Parse(arr2D[rows - 1, 4]);
            string colProductStr = $"Добуток будь-яких двох елементів у п’ятому стовпці: {colProduct} \n";

            // Відображення результатів у вікнах повідомлень
            MessageBox.Show(rowSumStr);
            MessageBox.Show(colProductStr);
        }
    }
}
