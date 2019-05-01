using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        public static List<string> TaskList = new List<string>();
        static void Main(string[] args)
        {
            MainScreen.Intro();
        }
    }
}
