using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToDoList
{
    class Program
    {
        // List of current todo tasks
        public static List<string> TaskList = new List<string>();
        //Task list loaded
        static void Main(string[] args)
        {
          
            MainScreen.Intro();
        }
    }
}
