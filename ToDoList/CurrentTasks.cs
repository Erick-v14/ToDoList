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
                Console.WriteLine("0. Go back to Main Menu");
                var UserSelection = Console.ReadLine();
                if (UserSelection == "0")
                {
                    MainScreen.Intro();
                }
                else
                {
                    Console.WriteLine("Invalid Selection");
                    UserSelection = Console.ReadLine();
                }
            } while (correct == 0);
        }
    }
}
