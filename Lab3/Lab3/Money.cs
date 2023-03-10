using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Money клас є нащадком Pair класу
    public class Money : Pair
    {
        private long grn; // ціла частина гривні
        private byte cop; // дробова частина гривні

        public Money(long grn, byte cop)
        {
            // конструктор класу Money
            this.grn = grn;
            this.cop = cop;
        }

        // метод Add для додавання Money об'єктів
        public override Pair Add(Pair other)
        {
            Money m = other as Money;
            if (m == null)
            {
                throw new ArgumentException("Argint is no Money object"); // викидаємо виключення, якщо other не є Money об'єктом
            }
            long newGrn = this.grn + m.grn;
            byte newCop = (byte)(this.cop + m.cop);
            if (newCop >= 100)
            {
                newCop -= 100;
                newCop++;

            }
            return new Money(newGrn, newCop);
        }

        // метод Subtract для віднімання Money об'єктів
        public override Pair Subtract(Pair other)
        {
            Money m = other as Money;
            if (m == null)
            {
                throw new ArgumentException("Argint is no Money object"); // викидаємо виключення, якщо other не є Money об'єктом
            }
            long newGrn = this.grn - m.grn;
            byte newCop = (byte)(this.cop - m.cop);
            if (newCop < 0)
            {
                newCop += 100;
                newCop--;

            }
            return new Money(newGrn, newCop);
        }

        // метод Multiply для множення Money об'єктів
        public override Pair Multiply(Pair other)
        {
            Money m = other as Money;
            if (m == null)
            {
                throw new ArgumentException("Argint is no Money object"); // викидаємо виключення, якщо other не є Money об'єктом
            }
            long newGrn = this.grn * m.grn;
            byte newCop = (byte)(this.cop * m.cop);
            if (newCop >= 100)
            {
                newCop -= 100;
                newCop++;

            }
            return new Money(newGrn, newCop);
        }

        // метод Multiply для множення Money об'єктів
        public override Pair Divide(Pair other)
        {
            Money m = other as Money;
            if (m == null)
            {
                throw new ArgumentException("Argint is no Money object"); // викидаємо виключення, якщо other не є Money об'єктом
            }
            if (m.grn == 0)
            {
                throw new DivideByZeroException(); // Якщо ділимо на 0, викидаємо виключення DivideByZeroException
            }
            long newGrn = this.grn / m.grn;
            byte newCop = (byte)(this.cop / m.cop);

            return new Money(newGrn, newCop);
        }


        public override string ToString()
        {
            return String.Format("{0}.{1:D2}", this.grn, this.cop);
        }
    }
}
