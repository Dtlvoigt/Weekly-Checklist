using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChecklist
{
    //determines if debug info should be shown while running application
    static class Debug
    {
        public static bool debug = false;
    }

    //holds info about tasks such as name, count, date completed...
    struct Task
    {

    }
    //holds all tasks
    class TaskList
    {

    }

    class WeeklyTasks
    {
        static void Main(string[] args)
        {
            //user wants debug information
            if (args[1].ToLower() == "debug")
                Debug.debug = true;

            Console.WriteLine(Debug.debug);
            Console.Read();
        }
    }
}
