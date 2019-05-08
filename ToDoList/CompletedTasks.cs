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
            int correct = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Main menu");
                Console.WriteLine("\n---------COMPLETED TASKS--------");
                int i = 1;
                foreach (string item in CompletedTasks)
                {
                    Console.WriteLine(i++ + ". " + item);
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
