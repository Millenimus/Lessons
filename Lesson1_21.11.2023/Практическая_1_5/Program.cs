using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите радиус круга:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Длина окружности = " + (2 * Math.PI * a));
            Console.WriteLine("Площадь круга = " + (Math.PI * Math.Pow(a,2)));



        }
    }
}
