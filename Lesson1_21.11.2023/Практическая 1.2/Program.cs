using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры прямоугольника:");
            
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь: " + width * height); // Площадь
            Console.WriteLine("Периметр: " + (2 * (width * height)));// Периметр
            Console.WriteLine("Длина диагонали: " + (Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2))));
        }
    }
}
