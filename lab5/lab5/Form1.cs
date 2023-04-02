using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримання рядка символів з текстового поля
            string inputString = textBox1.Text;
            // Перетворення рядка на масив символів
            char[] charArray = inputString.ToCharArray();
            // Ініціалізація змінних
            char previousChar = '\0'; // попередній символ, ініціалізований як нульовий символ
            string outputString = ""; // вихідний рядок, початково порожній

            // Проходження по масиву символів
            foreach (char currentChar in charArray)
            {
                // Якщо поточний символ не дорівнює попередньому
                if (currentChar != previousChar)
                {
                    // Додавання поточного символу до вихідного рядка
                    outputString += currentChar;
                }
                // Збереження поточного символу як попереднього для наступної ітерації
                previousChar = currentChar;
            }

            // Вивід заміненого рядка в текстове поле
            textBox2.Text = outputString;
        }
    }
}
