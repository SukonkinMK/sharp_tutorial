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
                        //Task2();
                        break;
                    case 3:
                        //Task3();
                        break;
                    case 4:
                        //Task4();
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
            Console.WriteLine($"ФИО: {GetFullName(name,surname,patronymic)}");
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return firstName + " " + lastName + " " + patronymic;
        }
    }
}
