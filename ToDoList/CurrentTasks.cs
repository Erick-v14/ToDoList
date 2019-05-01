using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class CurrentTasks
    {
        public static List<string> CompletedTaskList = new List<string>();
        public static void ViewTasks()
        {
            int correct = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Go to Main Menu");
                Console.WriteLine("M. Mark a task as completed");
                Console.WriteLine("D. Delete a task\n");
                Console.WriteLine("--------CURRENT TO-DO LIST---------");

                string[] ToDoList = System.IO.File.ReadAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt");

                // Display the file contents by using a foreach loop.
                int i = 1;
                foreach (string Tasks in ToDoList)
                {
                    // Use a tab to indent each line of the file.
                    Console.WriteLine(i++ +". " + Tasks);
                }


                var UserSelection = Console.ReadLine().ToUpper();
                if (UserSelection == "0")
                {
                    MainScreen.Intro();
                }
                else if (UserSelection=="M")
                {
                    //TODO: MOVE ITEM FROM CURRENT TASK TO LIST TO COMPLETED
                    Console.WriteLine("Which task have you completed?");
                    var CompletedTask = Console.ReadLine();
                    CompletedTaskList.Add(CompletedTask);
                    System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\CompletedTaskList.txt", CompletedTaskList);
                }
                else if (UserSelection=="D")
                {
                    Console.WriteLine("Which task do you want to delete?");
                    var DeleteTask = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                    UserSelection = Console.ReadLine().ToUpper();
                }
            } while (correct == 0);
        }
    }
}
