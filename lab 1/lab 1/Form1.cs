using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages[0].Text = "1.1";
            tabControl1.TabPages[1].Text = "1.2";
            tabControl1.TabPages[2].Text = "1.3";
            tabControl1.TabPages[3].Text = "1.4";
            tabControl1.TabPages[4].Text = "1.5";
            tabControl1.TabPages[5].Text = "1.6";
            tabControl1.TabPages[6].Text = "1.7";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text); // присвоєння зміної х до числа з textBox1 
            double y = Convert.ToDouble(textBox2.Text); // присвоєння зміної у до числа з textBox2
            double result = (Math.Abs(x) * (-1)) - Math.Cos(x) + Math.Sin(2 * x * y); // розв'язання (2^-x)-cosx + sin(2xy)
            label3.Text = result.ToString();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aTxtBox.Text);
            double b = Convert.ToDouble(bTxtBox.Text);
            double c = Convert.ToDouble(cTxtBox.Text);
            double r = Convert.ToDouble(rTxtBox.Text);
            double resultA = ((2 * r) * Math.Sin(a)); // сторона а
            double resultB = ((2 * r) * Math.Sin(b)); // сторона b
            double resultC = ((2 * r) * Math.Sin(c)); // сторона c
            label9.Text = resultA.ToString();
            label10.Text = resultB.ToString();
            label11.Text = resultC.ToString();

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBoxx1.Text);
            double y1 = Convert.ToDouble(textBoxy1.Text);
            double x2 = Convert.ToDouble(textBoxx2.Text);
            double y2 = Convert.ToDouble(textBoxy2.Text);
            double Ax = Convert.ToDouble(textBoxx.Text);
            double Ay = Convert.ToDouble(textBoxy.Text);

            bool isInside = (Ax >= x1) && (Ax <= x2) && (Ay >= y1) && (Ay <= y2);
            labelres3.Text = isInside.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(txtBox3.Text, out x)) // перевірка, чи введене значення є числом
            {
                bool hasSin = true, hasCos = true, hasLn = true;
                double sinX = Math.Sin(x);
                if (double.IsNaN(sinX))
                {
                    hasSin = false;
                    MessageBox.Show("Неможливо обчислити sin(x) для введеного значення x.");
                }
                double cosX = Math.Cos(x);
                if (double.IsNaN(cosX))
                {
                    hasCos = false;
                    MessageBox.Show("Неможливо обчислити cos(x) для введеного значення x.");
                }
                double lnX = Math.Log(x);
                if (double.IsNaN(lnX) || double.IsNegativeInfinity(lnX))
                {
                    hasLn = false;
                    MessageBox.Show("Неможливо обчислити ln(x) для введеного значення x.");
                }

                // виведення результатів
                if (hasSin) listBox1.Items.Add("sin(x) = " + sinX);
                if (hasCos) listBox1.Items.Add("cos(x) = " + cosX);
                if (hasLn) listBox1.Items.Add("ln(x) = " + lnX);
            }
            else
            {
                MessageBox.Show("Введіть коректне числове значення.");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            // Отримуємо значення n та k з текстових полів
            int n1_5 = int.Parse(txtBox1_5_1.Text);
            int k1_5 = int.Parse(txtBox1_5_2.Text);

            // Обчислюємо суму k - x степенів цифр числа n
            int sum1_5 = 0;
            foreach (char c in n1_5.ToString())
            {
                int digit = int.Parse(c.ToString());
                sum1_5 += (int)Math.Pow(digit, k1_5);
                k1_5--;
            }

            // Порівнюємо суму з числом n та виводимо результат
            if (sum1_5 == n1_5)
            {
                lb1_5res.Text = $"{n1_5} дорівнює сумі k - x степенів своїх цифр.";
            }
            else
            {
                lb1_5res.Text = $"{n1_5} не дорівнює сумі k - x степенів своїх цифр.";
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] weather = new int[30]; // масив для збереження погоди
            const int startingHeight = 100; // висота, на якій знаходиться равлик на початку спостереження
            int currentHeight = startingHeight; // поточна висота равлика

            // заповнення масиву погоди рандомними значеннями
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                weather[i] = random.Next(2); // 0 - похмуро, 1 - сонячно
            }

            // обчислення місця розташування равлика на кінці 30-го дня спостереження
            for (int i = 0; i < 30; i++)
            {
                if (weather[i] == 0) // якщо похмуро, равлик опускається на 1 см
                {
                    currentHeight -= 1;
                }
                else // якщо сонячно, равлик піднімається на 2 см
                {
                    currentHeight += 2;
                }
            }

            // виведення результату
            lbres1_6.Text = $"Равлик на кінці 30-го дня спостереження знаходиться на висоті {currentHeight} см.";
        }

        private void btn1_7_Click(object sender, EventArgs e)
        {
            string input = txtBox1_7.Text;
            int currentSequenceLength = 0;
            int maxSequenceLength = 0;

            foreach (char c in input) // перебірка символів введеного рядка
            {
                if (Char.IsDigit(c)) // якщо поточний символ є цифрою
                {
                    currentSequenceLength++;
                    maxSequenceLength = Math.Max(maxSequenceLength, currentSequenceLength);
                }
                else // якщо поточний символ не є цифрою
                {
                    currentSequenceLength = 0;
                }
            }

            MessageBox.Show("Довжина найбільшої послідовності цифр: " + maxSequenceLength);
        }

        private void txtBox1_5_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



