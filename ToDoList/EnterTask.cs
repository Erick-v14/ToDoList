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
                //Task entry menu
                Console.Clear();
                Console.WriteLine("0. Go to Main Menu");
                Console.WriteLine("Enter new tasks: ");
                var TaskEntry = Console.ReadLine();



                if (TaskEntry=="0")
                {
                    MainScreen.Intro();
                }
                if (TaskEntry==" ")                
                    Console.WriteLine("Please enter a task");
                
                else
                {
                  //
                  Program.TaskList.Add(TaskEntry);
                    //Tasks added to current task list
                    System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt", Program.TaskList);

                }




            } while (correct == 0);
        }
    }
}
