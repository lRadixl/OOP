using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Створення двох комплексних чисел і виконання деяких арифметичних операцій
            ComplexNumber a = new ComplexNumber(3, 2);
            ComplexNumber b = new ComplexNumber(-1, 4);
            ComplexNumber c = a + b;
            ComplexNumber d = a * b;
            ComplexNumber f = a.Power(3);

            // Виведіть результати
            textBox1.Text = $"a = {a}\r\n";
            textBox1.AppendText($"b = {b}\r\n");
            textBox1.AppendText($"a + b = {c}\r\n");
            textBox1.AppendText($"a * b = {d}\r\n");
            textBox1.AppendText($"a^3 = {f}\r\n");

            // Обчислення суми сусідніх комплексних чисел із вхідного масиву
            ComplexNumber[] A = { new ComplexNumber(2, 3), new ComplexNumber(-1, 5), new ComplexNumber(0, -2) };
            ComplexNumber[] C = ComplexNumber.SumOfNeighbors(A);

            // Вивести результат
            textBox2.Text = "Input array: ";
            foreach (ComplexNumber num in A)
            {
                textBox2.AppendText(num + ", ");
            }
            textBox2.AppendText("\r\n");

            textBox2.AppendText("Moduli of neighboring sums: ");
            foreach (ComplexNumber num in C)
            {
                textBox2.AppendText(num.Modulus() + ", ");
            }
            textBox2.AppendText("\r\n");
        }
    }
}
