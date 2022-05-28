using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
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
        /// Задача 1. Ввести с клавиатуры набор данных и сохранить его в текстовый файл
        /// </summary>
        public static void Task1()
        {
            string filename = "text1.txt";
            Console.Write("Ввседите текст для сохранения в файл: ");
            string data = Console.ReadLine();
            File.WriteAllText(filename, data);
            DirectoryInfo directoryInfo = new DirectoryInfo(filename);
            Console.WriteLine($"Данные записаны в файл {directoryInfo.FullName}");
        }

        /// <summary>
        /// Задача 2. При старте дописывает текущее время в файл «startup.txt»
        /// </summary>
        public static void Task2()
        {
            string filename = "startup.txt";
            DateTime time = DateTime.Now;
            string s = time.ToString("HH:mm:ss") + '\n';
            File.AppendAllText(filename,s);
            DirectoryInfo directoryInfo = new DirectoryInfo(filename);
            Console.WriteLine($"Данные записаны в файл {directoryInfo.FullName}");
        }
    }
}
