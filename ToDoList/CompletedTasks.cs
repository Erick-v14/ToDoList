using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class CompletedTasks
    {
        public static void CompletedList()
        {
            string[] CompletedTasks = System.IO.File.ReadAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\CompletedTaskList.txt");
            foreach (string element in CompletedTasks)
            {
                CurrentTasks.CompletedTaskList.Add(element);
            }
            int correct = 0;
            do
            {
                Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("0. Main menu");
                    Console.ResetColor();
                Console.WriteLine("\n---------COMPLETED TASKS--------");
             //   int i = 1;
                for(int i=0; i< CurrentTasks.CompletedTaskList.Count;i++)
                {
                    Console.WriteLine($"{ i + 1}. "+ CurrentTasks.CompletedTaskList[i]);
                }

                var userselect = Console.ReadLine();
                if (userselect == "0")
                {
                    MainScreen.Intro();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    userselect = Console.ReadLine();
                }
            } while (correct == 0);

        }
    }
}
