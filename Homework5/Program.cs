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
        /// Задача 1. Ввести с клавиатуры набор данных и сохранить его в текстовый файл
        /// </summary>
        public static void Task1()
        {
            string filename = "text1.txt";
            Console.Write("Ввседите текст для сохранения в файл: ");
            string data = Console.ReadLine();
            File.WriteAllText(filename, data);
            PrintPathToFile(filename);
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
            PrintPathToFile(filename);
        }

        /// <summary>
        /// Задача 3. Ввести с набор чисел (0...255) и записать их в бинарный файл
        /// </summary>
        public static void Task3()
        {
            string filename = "bytes.bin";
            byte[] data;
            Console.Write("Введите набор чисел (от 0 до 255): ");
            string inputData = Console.ReadLine();
            string[] parseData = inputData.Split(new char[] { ' ', ',', '.' },StringSplitOptions.RemoveEmptyEntries);
            data = new byte[parseData.Length];
            for (int i = 0; i < parseData.Length; i++)
            {
                data[i] = Byte.Parse(parseData[i]);
            }
            File.WriteAllBytes(filename, data);
            PrintPathToFile(filename);
        }

        /// <summary>
        /// Выводит полный путь к файлу
        /// </summary>
        /// <param name="filename">Имя файла</param>
        public static void PrintPathToFile(string filename)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filename);
            Console.WriteLine($"Данные записаны в файл {directoryInfo.FullName}");
        }

        /// <summary>
        /// Задача 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без
        /// </summary>
        public static void Task4()
        {
            string filename = "catalog.txt";
            Console.Write("Введите полный путь к директории: ");
            string workDir = Console.ReadLine();
            //Console.Write("Решить задачу с рекурсией? (Y / N): ");
            //string mode = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(workDir);
            //PrintDir(directoryInfo, "", true);
            PrintDirToFileRecursive(filename, directoryInfo, "", true);
        }

        /// <summary>
        /// Задача из урока с печатью файлов и директорий
        /// </summary>
        /// <param name="dir">Целевая директория</param>
        /// <param name="indent">отступ</param>
        /// <param name="lastDir">последняя ли директория</param>
        public static void PrintDir(DirectoryInfo dir, string indent, bool lastDir)
        {
            Console.WriteLine($"{indent}{(lastDir ? "\u2514\u2500" : "\u251C\u2500")}{dir.Name}");
            indent += lastDir ? " " : "\u2502 ";

            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < dirs.Length; i++)
            {
                PrintDir(dirs[i], indent, (i == dirs.Length - 1) && files.Length == 0);
            }
            PrintFilesInDirectory(files, indent);
        }

        /// <summary>
        /// Печать фалов текущей директории
        /// </summary>
        /// <param name="files">массив фалов</param>
        /// <param name="indent">отступ</param>
        public static void PrintFilesInDirectory(FileInfo[] files, string indent)
        {
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine($"{indent}{ (i == files.Length - 1 ? "\u2514\u2500" : "\u251C\u2500") }{files[i].Name}");
            }
        }

        /// <summary>
        /// Запись дерева каталога файлов и папок в файл
        /// </summary>
        /// <param name="filename">файл для записи</param>
        /// <param name="dir">директория</param>
        /// <param name="indent">отступ</param>
        /// <param name="lastDir">последняя директория</param>
        public static void PrintDirToFileRecursive(string filename, DirectoryInfo dir, string indent, bool lastDir)
        {
            File.AppendAllText(filename, $"{indent}{(lastDir ? "\u2514\u2500" : "\u251C\u2500")}{dir.Name}\n");
            indent += lastDir ? " " : "\u2502 ";
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < dirs.Length; i++)
            {
                PrintDirToFileRecursive(filename, dirs[i], indent, (i == dirs.Length - 1) && files.Length == 0);
            }
            for (int i = 0; i < files.Length; i++)
            {
                File.AppendAllText(filename, $"{indent}{ (i == files.Length - 1 ? "\u2514\u2500" : "\u251C\u2500") }{files[i].Name}\n");
            }
        }
    }
}
