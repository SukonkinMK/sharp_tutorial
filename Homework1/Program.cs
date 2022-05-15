using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string UserName = Console.ReadLine(); //считываем имя пользователя
            DateTime today = DateTime.Now;
            Console.WriteLine($"Привет, {UserName}, сегодня {today}");
        }
    }
}
