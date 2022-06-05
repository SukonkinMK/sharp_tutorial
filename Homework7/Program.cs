using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввежите число от 0 до 2: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("Hello!");
                    break;
                case 1:
                    for (int i = 0; i < 10; i++)
                        Console.Write(i + " ");
                    break;
                default:
                    if (number > 1)
                        Console.WriteLine("Число больше 1");
                    else
                        Console.WriteLine("Число меньше 0");
                    break;
            }
        }
    }
}
