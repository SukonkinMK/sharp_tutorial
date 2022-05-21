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

    }
}
