using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа:");
           
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Среднее арифметическое квадратов чисел: " + (Math.Pow(a,2) + Math.Pow(b,2))/2);
            Console.WriteLine("Среднее арифметическое модулей чисел: " + (Math.Abs(a) + Math.Abs(b))/2);

        }
    }
}
