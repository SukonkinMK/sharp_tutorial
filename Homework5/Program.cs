using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                Console.WriteLine("5 - Задача 5");
                Console.WriteLine("0 - Завершение работы приложения");
                Console.WriteLine("===================================");
                Console.Write("Введите номер задачи (от 1 до 5): ");
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
                    case 5:
                        Task5();
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

        /// <summary>
        /// Задача 5. Список задач
        /// </summary>
        public static void Task5()
        {
            string filename = "tasks.xml";
            ToDo[] toDoList;
            if (File.Exists(filename))
            {
                toDoList = ReadToDoList(filename);
            }
            else
            {
                Console.Write("Список дел пуст. Хотите добавить задачи? (y / n) ");
                string ans = Console.ReadLine();
                if(ans != "y" && ans != "n")
                {
                    Console.WriteLine("Некорректный ввод.");
                    return;
                }
                else
                {
                    if(ans == "n") { return; }
                    else
                    {
                        toDoList = CreateToDoList();
                    }
                }

            }
            PrintToDoList(toDoList);
            while(true)
            {
                Console.Write($"Введите номер выполненной задачи (от 1 до {toDoList.Length}). Для выхода введите 0: ");
                if(int.TryParse(Console.ReadLine(),out int toDoNumber))
                {
                    if(toDoNumber == 0)
                    {
                        break;
                    }
                    else if(toDoNumber >=1 && toDoNumber <= toDoList.Length)
                    {
                        toDoList[toDoNumber - 1].IsDone = true;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
            SaveToDoList(toDoList,filename);
        }

        /// <summary>
        /// Чтение списка дел из XNL-файла
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Массив списка дел</returns>
        public static ToDo[] ReadToDoList(string filename)
        {
            string xml = File.ReadAllText(filename);
            StringReader stringReader = new StringReader(xml);
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo[]));
            return (ToDo[])serializer.Deserialize(stringReader);
        }

        /// <summary>
        /// Сохранение массива дел в XML-файл
        /// </summary>
        /// <param name="list">Массив со списоком дел</param>
        /// <param name="filename">Имя файла</param>
        public static void SaveToDoList(ToDo[] list, string filename)
        {
            StringWriter stringWriter = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(ToDo[]));
            serializer.Serialize(stringWriter, list);
            string xml = stringWriter.ToString();
            File.WriteAllText(filename, xml);
        }

        /// <summary>
        /// Печать списка дел
        /// </summary>
        /// <param name="list">список дел</param>
        public static void PrintToDoList(ToDo[] list)
        {
            Console.WriteLine("Текущий список дел:");
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i].IsDone)
                {
                    Console.Write("[x]");
                }
                else
                {
                    Console.Write("   ");
                }
                Console.WriteLine($"{i + 1}. {list[i].Title}");
            }
        }

        /// <summary>
        /// Добавление в список дел новой задачи
        /// </summary>
        /// <param name="list">Ссылка на текущий список дел</param>
        /// <param name="name">Новая задача</param>
        /// <returns>Список с новой задачей</returns>
        public static ToDo[] AddWorkToList(ToDo[] list, string name)
        {
            ToDo[] finalList = new ToDo[list.Length+1];
            for (int i = 0; i < finalList.Length; i++)
            {
                if(i != finalList.Length - 1) { finalList[i] = list[i]; }
                else
                {
                    finalList[i] = new ToDo(name, false);
                }
            }
            return finalList;
        }

        /// <summary>
        /// Создание списка дел
        /// </summary>
        /// <returns>Массив ToDo</returns>
        public static ToDo[] CreateToDoList()
        {
            ToDo[] toDoList = new ToDo[1];
            Console.Write("Введите название задачи: ");
            toDoList[0] = new ToDo(Console.ReadLine(), false);
            while (true)
            {
                Console.Write("Добавить еще задачи? (y / n): ");
                string addAns = Console.ReadLine();
                if (addAns == "y")
                {
                    Console.Write("Введите название задачи: ");
                    toDoList = AddWorkToList(toDoList, Console.ReadLine());
                }
                else if (addAns == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод.");
                }
            }
            return toDoList;
        }
    }
    public class ToDo
    {
        string title;
        bool isDone;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public bool IsDone
        {
            get { return isDone;}
            set { isDone = value;}
        }
        public ToDo() { }
        public ToDo(string title, bool status)
        {
            this.title = title;
            this.isDone = status;
        }
    }
}
