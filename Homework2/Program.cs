using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            //Task2();
        }

        /// <summary>
        ///Задача 1. Запросить минимальную и максимальную температуру за сутки 
        ///и вывести среднесуточную температуру
        /// </summary>
        public static void Task1()
        {
            Console.Write("Введите минимальную температуру за сутки ");
            double t_min = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки ");
            double t_max = double.Parse(Console.ReadLine());
            Console.WriteLine($"Среднесуточная температура равна {(t_max + t_min) / 2:F1} градусов");
            Console.ReadKey();
        }

        
    }
}
