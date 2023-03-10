using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Pair context;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Зчитування введених користувачем даних для комплексного числа
            double real1 = Convert.ToDouble(txtReal1.Text);
            double imaginary1 = Convert.ToDouble(txtImaginary1.Text);
            double real2 = Convert.ToDouble(txtReal2.Text);
            double imaginary2 = Convert.ToDouble(txtImaginary2.Text);

            // Створюємо об'єкти для комплексних чисел
            Complex c1 = new Complex(real1, imaginary1);
            Complex c2 = new Complex(real2, imaginary2);

            try
            {
                // Виконання обраних користувачем операцій над комплексними числами
                Pair result;
                if (cmbOperation.SelectedIndex == 0)
                {
                    result = c1.Add(c2);
                }
                else if (cmbOperation.SelectedIndex == 1)
                {
                    result = c1.Subtract(c2);
                }
                else if (cmbOperation.SelectedIndex == 2)
                {
                    result = c1.Multiply(c2);
                }
                else
                {
                    result = c1.Divide(c2);
                }

                // Вивід результату операції у повідомленні
                MessageBox.Show(result.ToString(), "Результат");
            }
            catch (Exception ex)
            {
                // Якщо винекла помилка, виводимо її повідомленням на форму
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCalculateMoney_Click(object sender, RoutedEventArgs e)
        {
            // Зчитування введених користувачем даних для грошових операцій
            long grn1 = Convert.ToInt64(txtGrn1.Text);
            byte cop1 = Convert.ToByte(txtCop1.Text);
            long grn2 = Convert.ToInt64(txtGrn2.Text);
            byte cop2 = Convert.ToByte(txtCop2.Text);

            // Створюємо об'єкти для грошових операцій
            Money m1 = new Money(grn1, cop1);
            Money m2 = new Money(grn2, cop2);

            try
            {
                //  Виконання обраних користувачем операцій над грошовими операціями
                Pair result;
                if (cmbOperationMoney.SelectedIndex == 0)
                {
                    result = m1.Add(m2);
                }
                else if (cmbOperationMoney.SelectedIndex == 1)
                {
                    result = m1.Subtract(m2);
                }
                else if (cmbOperationMoney.SelectedIndex == 2)
                {
                    result = m1.Multiply(m2);
                }
                else
                {
                    result = m1.Divide(m2);
                }

                // Вивід результату операції у повідомленні
                MessageBox.Show(result.ToString(), "Результат");
            }
            catch (Exception ex)
            {
                // Якщо винекла помилка, виводимо її повідомленням на форму
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }

}
