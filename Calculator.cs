using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Calculator<T>
    {
        public T Add(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 + num2;
        }

        public T Subtract(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 - num2;
        }

        public T Multiply(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            return num1 * num2;
        }

        public T Divide(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            if (num2 == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }
            return num1 / num2;
        }
    }
}
