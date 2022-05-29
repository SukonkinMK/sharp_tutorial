using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager();
            Console.WriteLine("Завершение работы приложения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Выводит списаок процессов и дает возможность завершать процессы по имени или Id
        /// </summary>
        public static void TaskManager()
        {
            Console.WriteLine("{0, -40} {1, 7} {2,8}", "Process Name", "PID", "Mem Usage");
            //Console.WriteLine("Process Name\t\t\tPID Mem Usage");
            Console.WriteLine($"{"".PadRight(40,'=')} {"".PadRight(7, '=')} {"".PadRight(9, '=')}");
            Process[] allProcesses = Process.GetProcesses();
            foreach (Process process in allProcesses)
            {
                Console.WriteLine("{0, -40} {1, 7} {2, 8}K", process.ProcessName, process.Id, process.WorkingSet64/1024);
            }
            while(true)
            {
                Console.Write("Хотите завершить какой-либо процесс? (y / n) ");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    Console.Write("Введите имя или PID процесса для завершения: ");
                    DetectProcessAndKill(allProcesses, Console.ReadLine());
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

        /// <summary>
        /// Определение процесса для завершения
        /// </summary>
        /// <param name="processes">Список всех процессов</param>
        /// <param name="input">Имя или Id процееса для завершения</param>
        public static void DetectProcessAndKill(Process[] processes, string input)
        {
            if(int.TryParse(input, out int processId))
            {
                foreach(Process process in processes)
                {
                    if(process.Id == processId)
                    {
                        KillProcess(process);
                        break;
                    } 
                }
            }
            else
            {
                foreach (Process process in processes)
                {
                    if (process.ProcessName == input)
                    {
                        KillProcess(process);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Попытка завершения процесса
        /// </summary>
        /// <param name="process">Процесс для завершения</param>
        public static void KillProcess(Process process)
        {
            try
            {
                process.Kill();
                Console.WriteLine($"Процесс {process.ProcessName},PID = {process.Id} успешно завершен");
            }
            catch
            {
                Console.WriteLine($"Не удалось завершить процесс {process.ProcessName},PID = {process.Id}");
            }
        }
    }
}
