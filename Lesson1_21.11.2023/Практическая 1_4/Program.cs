using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");

            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь грани куба: " + Math.Pow(a,2));
            Console.WriteLine("Площадь полной поверхности куба: " + (6 * Math.Pow(a, 2)));
            Console.WriteLine("Объем куба: " + Math.Pow(a, 3));






        }
    }
}
