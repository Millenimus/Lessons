using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y2:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x3:");
            double x3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты y3:");
            double y3 = double.Parse(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
            double AC = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double BC = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double P = AB + AC + BC;
            double S = Math.Sqrt(P / 2 * ((P / 2) - AB) * ((P / 2) - AC) * ((P / 2) - BC));
            Console.WriteLine("Площадь треугольника = " + S);
            Console.WriteLine("Периметр треугольника = " + P);


        }
    }
}
