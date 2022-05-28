using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
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
        /// Задача 1. Вывод диагонали 2-мерного массива
        /// </summary>
        public static void Task1()
        {
            Console.Write("Введите количество строк массива n = ");
            int arr_rows = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов массива m = ");
            int arr_collums = int.Parse(Console.ReadLine());
            int[,] arr = new int[arr_rows, arr_collums];
            //Генерируем массив и печатаем
            Random random = new Random();
            Console.WriteLine($"Сгенерирован массив {arr_rows}x{arr_collums}:");
            for (int i = 0; i < arr_rows; i++)
            {
                for(int j = 0; j < arr_collums; j++)
                {
                    arr[i, j] = random.Next(0,9);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.Write("Диагональные элементы полученного массива: ");
            for (int i = 0; i < arr_rows; i++)
            {
                for (int j = 0; j < arr_collums; j++)
                {
                    if(i == j)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }                    
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Задача 2. Телефонный справочник
        /// </summary>
        public static void Task2()
        {
            string[,] list = new string[5, 2] { 
                { "Иван", "8(925)1234567" },
                { "Дима", "example@email.com" }, 
                { "Петя", "8(985)7654321" }, 
                { "Вася", "vacya@mail.ru" }, 
                { "Влад", "8(495)1234567" } 
            };
            Console.WriteLine("Текущий телефонный справочник:");
            for(int i = 0; i < list.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}. {list[i, 0]} - {list[i, 1]}");
            }
        }

        /// <summary>
        /// Задача 3. Перевернуть строку
        /// </summary>
        public static void Task3()
        {
            Console.Write("Введите слово ");
            string s = Console.ReadLine();
            Console.Write("В обратном порядке ваше слово выглядит так: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write($"{s[i]}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Задача 4. Вывести поле для игры Морской бой
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("Поле для игры в морской бой");
            char[,] battlefield = new char[10, 10] {
                { 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'O'},
                { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'O', 'X', 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O'},
                { 'O', 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'X', 'O'},
                { 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                { 'O', 'O', 'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O'},
                { 'X', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                { 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'X', 'O'},
                { 'O', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'O'},
            };
            for(int i = 0; i < battlefield.GetLength(0); i++)
            {
                for(int j = 0; j < battlefield.GetLength(1); j++)
                {
                    Console.Write($"{battlefield[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
