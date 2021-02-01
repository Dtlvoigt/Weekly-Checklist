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
            //check args
            if (args.Length > 2)
            {
                Console.WriteLine("Too many args, exiting..");
                System.Environment.Exit(0);
            }
            
            //filename to store list of tasks
            String filename = "task_info";  //default name if no input

            //check if user wants debug information or has custom filename
            if (args.Length == 1)
            {
                if (args[0].ToLower() == "-debug")
                    Debug.debug = true;
                else
                    filename = args[0];
            }

            //if two args, make sure second is -debug and then set filename
            if (args.Length == 2)
            {
                if (args[1].ToLower() != "-debug")
                {
                    Console.WriteLine("When using two args the first must be a filename and the second must be \"-debug\"");
                    System.Environment.Exit(1);
                }
                else
                {
                    Debug.debug = true;
                    filename = args[0];
                }
            }

            Console.WriteLine(filename);
            Console.Read();
        }
    }
}
