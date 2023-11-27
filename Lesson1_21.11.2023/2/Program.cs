using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Целочисленная
            int a = 19;
            //Строковая
            string str = "Привет";
            //Вещественная
            double c = 1.23;
            //Символьная
            char symb = '+';
            //Логическая
            bool t = true;


            //Форматированный вывод
            Console.WriteLine("ЗНачение первой переменной: {0}, второй: {1}, третий: {2}", a, str, c);
            Console.WriteLine($"Четвертая переменная: {symb}, 5: {t}");


            //Генератор случайных чисел
            Random rnd = new Random();
            int a1 = rnd.Next(100); //Указана правая граница диапазона генерации
            int a2 = rnd.Next(-100, 100); // Указаны обе границы диапазона
            double a3 = rnd.NextDouble(); // Сгенерирует в диапазоне от 0 до 1



            Console.WriteLine(rnd.Next());                //Целое число из всего диапазона
            Console.WriteLine(rnd.Next(3000));            //Целое от 0 до  3000
            Console.WriteLine(rnd.Next(-50, 50));         //Целое от -50 до 50
            Console.WriteLine(rnd.NextDouble());       //Вещественное от 0 до 1
            Console.WriteLine(rnd.NextDouble() + (rnd.Next(-50, 49)));  // Вещественное от -50 до 50


            double d1 = Math.Abs(-45); // Модуль числа. Класс Math = математические операции
            double d2 = Math.Round(5.6464564, 3); // Правое число послезапятой указывает кол-во знаков после разделителя


            //Математические функции
            // Синус Пи/6
            Console.WriteLine(Math.Sin(Math.PI / 6));
            // Корень из 16
            Console.WriteLine(Math.Sqrt(16));
            // 3 возведенное в 4ю степень
            Console.WriteLine(Math.Pow(3, 4));
            

            //Конвертирование значений при считывании данных с консоли
            double width = Convert.ToDouble(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            // Площадь прямоугольника, периметр и диагональ
            Console.WriteLine(width * height); // Площадь
            Console.WriteLine(2 * (width * height));// Периметр
            Console.WriteLine(Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2)));// Диагональ


        }  
    }
}
