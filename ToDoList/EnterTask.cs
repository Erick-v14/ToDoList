using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class EnterTask
    {
        
        public static void TaskEntry()
        {
            int correct = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Go to Main Menu");
                Console.WriteLine("Enter new tasks: ");
                var TaskEntry = Console.ReadLine();



                if (TaskEntry=="0")
                {
                    MainScreen.Intro();
                }
                else
                {
                 Console.Clear();
                 Console.WriteLine("Your entry has been added\nPress ENTER to continue");
                 Program.TaskList.Add(TaskEntry);
                 System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt", Program.TaskList);
                 Console.ReadKey();
                }




            } while (correct == 0);
        }
    }
}
