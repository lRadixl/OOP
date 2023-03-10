using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Complex : Pair
    {
        private double real;
        private double imaginary;

        // Конструктор класу, приймає дійсну та уявну частини комплексного числа
        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        // Перевизначений метод Add, який додає до поточного комплексного числа інше комплексне число
        public override Pair Add(Pair other)
        {
            Complex c = other as Complex; // перевірка, чи other є екземпляром класу Complex

            if (c == null)
                throw new ArgumentException("Argument is not a Complex object");

            double newReal = this.real + c.real; // додаємо дійсні частини
            double newImaginary = this.imaginary + c.imaginary; // додаємо уявні частини

            return new Complex(newReal, newImaginary); // повертаємо нове комплексне число
        }

        // Перевизначений метод Subtract, який віднімає від поточного комплексного числа інше комплексне число
        public override Pair Subtract(Pair other)
        {
            Complex c = other as Complex;
            if (c == null)
                throw new ArgumentException("Argument is not a Complex object");

            double newReal = this.real - c.real; // віднімаємо дійсні частини
            double newImaginary = this.imaginary - c.imaginary; // віднімаємо уявні частини

            return new Complex(newReal, newImaginary);
        }

        // Перевизначений метод Multiply, який множить поточне комплексне число на інше комплексне число
        public override Pair Multiply(Pair other)
        {
            Complex c = other as Complex;
            if (c == null)
                throw new ArgumentException("Argument is not a Complex object");

            double newReal = this.real * c.real - this.imaginary * c.imaginary; // множимо дійсні частини і віднімаємо добутки уявних частин
            double newImaginary = this.real * c.imaginary + this.imaginary * c.real; // додаємо добутки дійсних та уявних частин

            return new Complex(newReal, newImaginary);
        }

        // Перевизначений метод Divide, який ділить поточне комплексне число на інше комплексне число
        public override Pair Divide(Pair other)
        {
            Complex c = other as Complex;
            if (c == null)
                throw new ArgumentException("Argument is not a Complex object");

            double denominator = c.real * c.real + c.imaginary * c.imaginary; // Обчислення знаменника
            if (denominator == 0) // Якщо знаменник дорівнює 0, викидаємо виключення DivideByZeroException з повідомленням про помилку
                throw new DivideByZeroException();

            // Обчислення чисельника та нових значень дійсної та уявної частини дробу
            double newReal = (this.real * c.real + this.imaginary * c.imaginary) / denominator;
            double newImaginary = (this.imaginary * c.real - this.real * c.imaginary) / denominator;

            // Повертаємо новий об'єкт Complex з новими значеннями дійсної та уявної частини
            return new Complex(newReal, newImaginary);
        }

        public override string ToString()
        {
            // Якщо уявна частина менша за 0, повертаємо рядок зі знаком "мінус"
            if (this.imaginary < 0)
            {
                return String.Format("{0} - {1}i", this.real, -this.imaginary);
            }
            // Інакше повертаємо рядок зі знаком "плюс"
            else
            {
                return String.Format("{0} + {1}i", this.real, this.imaginary);
            }
        }
    }
}
