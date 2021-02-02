using System;
using System.IO;
using System.Diagnostics;
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

    //holds info about tasks
    struct Task
    {
        public string name;
        public int count;
        public int completed;
        public DateTime date;
    }
    
    /*//holds all tasks
    class TaskList
    {
        public List<Task> tasks;
    }*/

    //user interface loop
    class UserInterface
    {

    }

    class WeeklyTasks
    {
        //check command line args for filename or debug option
        public static void CommandLineChecks(string[] args, ref string filename)
        {
            //check # of args
            if (args.Length > 2)
            {
                Console.WriteLine("Too many args, exiting..");
                System.Environment.Exit(0);
            }

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
        }

        public static void Main(string[] args)
        {
            string filename = "task_info";  //default name if no input

            //check args for correctness
            CommandLineChecks(args, ref filename);

            if (Debug.debug)
            {
                Console.WriteLine(filename);
                Console.Read();
            }

            //check if filename is valid

            //create TaskList and load tasks from file into it
        }

        
    }
}
