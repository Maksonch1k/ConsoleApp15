using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            Console.WriteLine("Сложение (5 + 3) = " + intCalculator.Add(5, 3));
            Console.WriteLine("Вычитание (5 - 3) = " + intCalculator.Subtract(5, 3));
            Console.WriteLine("Умножение (5 * 3) = " + intCalculator.Multiply(5, 3));
            Console.WriteLine("Деление (5 / 3) = " + intCalculator.Divide(5, 3));

            Calculator<double> doubleCalculator = new Calculator<double>();
            Console.WriteLine("\nСложение (5.5 + 3.5) = " + doubleCalculator.Add(5.5, 3.5));
            Console.WriteLine("Вычитание (5.5 - 3.5) = " + doubleCalculator.Subtract(5.5, 3.5));
            Console.WriteLine("Умножение (5.5 * 3.5) = " + doubleCalculator.Multiply(5.5, 3.5));
            Console.WriteLine("Деление (5.5 / 3.5) = " + doubleCalculator.Divide(5.5, 3.5));
            Console.ReadKey();
        }
    }
}
    

