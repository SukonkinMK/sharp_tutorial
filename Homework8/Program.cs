using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("{0}", Properties.Settings.Default.Greetings);
            if(string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                PropertiesCorrection();
            }
            else
            {
                Console.Write($", {Properties.Settings.Default.Name}!\n");
                Console.WriteLine($"Согласно последним данным Вам {Properties.Settings.Default.Age} лет, Вы работаете по профессии {Properties.Settings.Default.Profession}.");
                while (true)
                {
                    Console.Write("Хотите обновить информацию? (y / n) ");
                    string ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        PropertiesCorrection();
                        break;
                    }
                    else if (ans == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод.");
                    }
                }
            }
            
            Console.WriteLine("Завершение работы приложения...");

            Console.ReadKey();
        }

        /// <summary>
        /// Изменение пользовательских параметров проекта
        /// </summary>
        static void PropertiesCorrection()
        {
            Console.WriteLine();
            Console.Write("Введите Ваше имя: ");
            Properties.Settings.Default.Name = Console.ReadLine();
            while (true)
            {
                Console.Write("Введите Ваш возраст: ");
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0 && age < 120)
                {
                    Properties.Settings.Default.Age = age;
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный возраст");
                }
            }
            Console.Write("Введите название Вашей профессию: ");
            Properties.Settings.Default.Profession = Console.ReadLine();
            Properties.Settings.Default.Save();
            Console.WriteLine("Параметры проекта сохранены");
        }
    }
}
