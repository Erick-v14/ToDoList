using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class MainScreen
    {
        public static void Intro()
        {
            int correct = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------TASK MANAGER-------------");
                Console.WriteLine("\n1.  Enter new task to list");
                Console.WriteLine("2.  View current task list");
                var UserSelection = Console.ReadLine();
                if (UserSelection == "1")
                {
                    EnterTask.TaskEntry();
                }
                else if (UserSelection=="2")
                {
                    CurrentTasks.ViewTasks();
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    UserSelection = Console.ReadLine();
                }
            } while (correct == 0);
        }
    }
}
