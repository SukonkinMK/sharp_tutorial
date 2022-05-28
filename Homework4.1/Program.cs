using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");
                Console.WriteLine("3 - Задача 3");
                Console.WriteLine("4 - Задача 4");
                Console.WriteLine("0 - Завершение работы приложения");
                Console.WriteLine("===================================");
                Console.Write("Введите номер задачи (от 1 до 4): ");
                int number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения...");
                        Console.ReadKey();
                        return;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи ...");
                        break;
                }
            }
        }

        /// <summary>
        /// Задача 1. Реализовать и использовать метод GetFullName(string firstName, string lastName, string patronymic)
        /// </summary>
        static void Task1()
        {
            string name = "Иван";
            string surname = "Иванов";
            string patronymic = "Иванович";
            Console.WriteLine(GetFullName(name, surname, patronymic));
            Console.WriteLine(GetFullName("Александр", "Сергеевич", "Пушкин"));
            Console.WriteLine($"ФИО: {GetFullName(name, surname, patronymic)}");
        }

        /// <summary>
        /// Возвращает строку с ФИО
        /// </summary>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="patronymic">Отчество</param>
        /// <returns></returns>
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }

        /// <summary>
        /// Задача 2. Считать с консоли строку чисел через пробел и вывести их сумму
        /// </summary>
        static void Task2()
        {
            Console.Write("Введите строку целых чисел для суммирования через пробел: ");
            string numbers = Console.ReadLine();
            int[] parsedNumbers = ParseToIntArray(numbers);
            int sum = 0;
            foreach (int number in parsedNumbers)
            {
                sum += number;
            }
            Console.WriteLine($"Сумма введенных чисел: {sum}");

        }

        /// <summary>
        /// Перевод строки в массив целых чисел
        /// </summary>
        /// <param name="str">Строка с целыми числами, разделенными пробелом</param>
        /// <returns>Массив целых чисел введенных в строке</returns>
        static int[] ParseToIntArray(string str)
        {
            int[] numbers;
            string[] parseStrings = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numbers = new int[parseStrings.Length];
            for (int i = 0; i < parseStrings.Length; i++)
            {
                numbers[i] = int.Parse(parseStrings[i]);
            }
            return numbers;
        }

        /// <summary>
        /// Задача 3. Определение времени года.
        /// </summary>
        static void Task3()
        {
            Console.Write("Введите порядковый номер месяца: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(SeasonToString(MonthNumberToSeason(number)));
        }

        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Undefined
        }

        /// <summary>
        /// Возвращает время года в зависимости от номера месяца
        /// </summary>
        /// <param name="n">Номер месяца</param>
        /// <returns>Возвращает время года типа enum</returns>
        static Season MonthNumberToSeason(int n)
        {
            if (n < 1 || n > 12)
            {
                return Season.Undefined;
            }
            else if (n == 12 || n == 1 || n == 2)
            {
                return Season.Winter;
            }
            else if (n > 2 && n < 6)
            {
                return Season.Spring;
            }
            else if (n > 5 && n < 9)
            {
                return Season.Summer;
            }
            else
            {
                return Season.Autumn;
            }
        }

        /// <summary>
        /// Принимает сезон года и возвращает сообщение
        /// </summary>
        /// <param name="season">Сезон года</param>
        /// <returns>Строка с сообщением</returns>
        static string SeasonToString(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    return "зима";
                case Season.Spring:
                    return "весна";
                case Season.Autumn:
                    return "осень";
                case Season.Summer:
                    return "лето";
                default:
                    return "Ошибка: введите число от 1 до 12";
            }
        }

        /// <summary>
        /// Задача 4. Последовательность Фибоначчи
        /// </summary>
        static void Task4()
        {
            Console.Write($"Введите порядковый номер числа в последовательности: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число под номером {number} в последовательности Фибоначчи равно {Fibonachi(number)}");
        }

        static int Fibonachi(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}
