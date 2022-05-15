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
            //Task2();
            //Task3();
            //Task4();
            Task5();
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
        /// Задача 2. Запросить порядковый номер текущего месяца и вывести его название
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

        /// <summary>
        /// Задача 3. Определить, является ли введённое число чётным
        /// </summary>
        public static void Task3()
        {
            Console.Write("Введите целое число ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Введенное число {number} является четным");
            }
            else
            {
                Console.WriteLine($"Введенное число {number} является нечетным");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Задача 4. Печать чека
        /// </summary>
        public static void Task4()
        {
            int checkNumber = 5019;
            string shopNumber = "03050040";
            long checkCode = 8212662660;
            string shopAddress = "410000, Московская обл, Долгопрудный г,\nПервомайская ул, дом 1Б";
            string product1_Name = "Пакет 65х40см";
            double product1_Price = 4.90;
            string product2_Name = "Хлеб ржаной";
            double product2_Price = 48.90;
            string seller_Name = "Суконкин М.К.";
            DateTime date  = new DateTime(2018,6,3,18,3,0);
            Console.WriteLine("--------------КАССОВЫЙ ЧЕК--------------");
            Console.WriteLine("Приход");
            Console.WriteLine($"Номер чека: \t\t {checkNumber}");
            Console.WriteLine($"Код магазина: \t\t {shopNumber}");
            Console.WriteLine($"Код чека: \t\t {checkCode}");
            Console.WriteLine($"Фактический аддрес:\n{shopAddress}");
            Console.WriteLine($"Кассир: {seller_Name} \t {date.ToString("dd.MM.yyyy")} {date.ToString("HH:mm")}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("№ \t Наименование \t\t Цена");
            Console.WriteLine($"1 \t {product1_Name} \t\t {product1_Price}");
            Console.WriteLine($"2 \t {product2_Name} \t\t {product2_Price}");
            Console.WriteLine("========================================");
            Console.WriteLine($"ИТОГ \t\t \t\t {product1_Price+product2_Price}");
            Console.WriteLine($" Сумма НДС 18% \t \t\t {(product1_Price + product2_Price)*0.18:F1}");
            Console.ReadKey();
        }

        /// <summary>
        /// Если введен месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима»
        /// </summary>
        public static void Task5()
        {
            Console.Write("Введите минимальную температуру за сутки ");
            double t_min = double.Parse(Console.ReadLine());
            Console.Write("Введите максимальную температуру за сутки ");
            double t_max = double.Parse(Console.ReadLine());
            double t_avg = (t_max + t_min) / 2;
            Console.Write("Введите порядковый номер текущего месяца ");
            int number = int.Parse(Console.ReadLine());
            if (t_avg > 0 && (number == 12 || number == 1 || number == 2))
            {
                Console.WriteLine("Дождливая зима");
            }
            Console.ReadKey();
        }
    }
}
