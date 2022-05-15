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
            //Task1();
            Task2();
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

        /// <summary>
        /// Задача 1. Запросить порядковый номер текущего месяца и вывести его название
        /// </summary>
        public static void Task2()
        {
            Console.Write("Введите порядковый номер текущего месяца ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine($"Название {number} месяца Январь");
                    break;
                case 2:
                    Console.WriteLine($"Название {number} месяца Февраль");
                    break;
                case 3:
                    Console.WriteLine($"Название {number} месяца Март");
                    break;
                case 4:
                    Console.WriteLine($"Название {number} месяца Апрель");
                    break;
                case 5:
                    Console.WriteLine($"Название {number} месяца Май");
                    break;
                case 6:
                    Console.WriteLine($"Название {number} месяца Июнь");
                    break;
                case 7:
                    Console.WriteLine($"Название {number} месяца Июль");
                    break;
                case 8:
                    Console.WriteLine($"Название {number} месяца Август");
                    break;
                case 9:
                    Console.WriteLine($"Название {number} месяца Сентябрь");
                    break;
                case 10:
                    Console.WriteLine($"Название {number} месяца Октябрь");
                    break;
                case 11:
                    Console.WriteLine($"Название {number} месяца Ноябрь");
                    break;
                case 12:
                    Console.WriteLine($"Название {number} месяца Декабрь");
                    break;
                default:
                    Console.WriteLine($"Месяца под номером {number} не существует");
                    break;
            }
            Console.ReadKey();
        }
    }
}
