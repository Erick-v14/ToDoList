using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class CurrentTasks
    {
        //my completed tasks <list>
        public static List<string> CompletedTaskList = new List<string>();
        public static void ViewTasks()
        {
            //load current todo list
                string[] ToDoList = System.IO.File.ReadAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt");
               foreach (string element in ToDoList)
                {
                    Program.TaskList.Add(element);
                }

               //do while loop
            int correct = 0;
            do
            {
                //menu options
                Console.Clear();
                Console.WriteLine("0. Go to Main Menu");
                Console.WriteLine("1. Enter new task");
                Console.WriteLine("M. Mark a task as completed");
                Console.WriteLine("D. Delete a task\n");
                Console.WriteLine("--------CURRENT TO-DO LIST---------");
                             
               // Display the file contents by using a for loop.
                for (int i = 0; i < Program.TaskList.Count; i++)
                {
                    Console.WriteLine($"{i+1}: "+ Program.TaskList[i]);
                }

                var UserSelection = Console.ReadLine().ToUpper();
                if (UserSelection == "0")
                {
                    MainScreen.Intro();
                }
                else if (UserSelection == "1")
                {
                    Console.Write("Enter new task >");
                    var taskentry = Console.ReadLine();
                    if (UserSelection == "")
                    {
                        Console.WriteLine("Please enter a task");
                        UserSelection = Console.ReadLine();
                    }
                    else
                    {
                        Program.TaskList.Add(taskentry);
                        //Tasks added to current task list
                        System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt", Program.TaskList);
                    }
                }
                else if (UserSelection == "M")
                {
                    //TODO: MOVE ITEM FROM CURRENT TASK TO LIST TO COMPLETED
                    Console.WriteLine("Which task have you completed?");
                    if (int.TryParse(Console.ReadLine(), out int complete))
                    {
                        if (complete <= Program.TaskList.Count && complete >= 0)
                        {
                            CompletedTaskList.AddRange(Program.TaskList );
                        //    System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\CompletedTaskList.txt", CompletedTaskList);
                        }

                    }
                }



                //Delete a task from current list
                else if (UserSelection == "D")
                {
                    Console.WriteLine("Which task do you want to delete?");
                    if (int.TryParse(Console.ReadLine(), out int selection))
                    {
                        if (selection <= Program.TaskList.Count && selection >= 0)
                        {
                            Program.TaskList.RemoveAt(selection - 1);
                            System.IO.File.WriteAllLines(@"C:\Users\WWStudent\source\repos\ToDoList\ToDoList\ToDoTasks.txt", Program.TaskList);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input, try again: ");
                            Console.ReadKey();
                        }
                    }
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
