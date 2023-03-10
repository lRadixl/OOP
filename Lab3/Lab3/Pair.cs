using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Оголошення абстрактного класу Pair
    public abstract class Pair 
    {
        // Оголошення абстрактних методів для додавання, віднімання, множення та ділення
        public abstract Pair Add(Pair other);
        public abstract Pair Subtract(Pair other);
        public abstract Pair Multiply(Pair other);
        public abstract Pair Divide(Pair other);
    }
}

