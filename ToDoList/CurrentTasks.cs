using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class CurrentTasks
    {       
        public static void ViewTasks()
        {
            int correct = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0. Go to Main Menu");
                Console.WriteLine("M. Mark a task as completed");
                Console.WriteLine("D. Delete a task");
                foreach (string i in Program.TaskList)
                {
                    Console.WriteLine(i);
                }
                var UserSelection = Console.ReadLine().ToUpper();
                if (UserSelection == "0")
                {
                    MainScreen.Intro();
                }
                else if (UserSelection=="M")
                {
                    Console.WriteLine("Which task have you completed?");
                    var CompletedTask = Console.ReadLine();
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
