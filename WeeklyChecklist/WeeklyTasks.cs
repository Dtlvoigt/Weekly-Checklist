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
        //how should I reset tasks for the week?
        //simple way is to just have user push button
        //maybe reset monday morning. if user hasn't opened application since then reset.
        //would have to keep track of last date used
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
                    Console.Read();
                    System.Environment.Exit(0);
                }
                else
                {
                    Debug.debug = true;
                    filename = args[0];
                }
            }
        }

        //checks if filename and path are valid, returns path to file
        public static string LoadFile(string filename)
        {
            string path = "";
            try
            {
                path = Directory.GetCurrentDirectory() + "\\" + filename + ".txt";
                if (!File.Exists(path))
                {
                    File.CreateText(path);
                    if (Debug.debug)
                        Console.WriteLine("new file created: {0}", filename + ".txt");
                }

                if (Debug.debug)
                    Console.WriteLine("path of active file:\n{0}", path);
            }
            catch (Exception e)
            {
                Console.WriteLine("File could not be opened: {0}\nExiting Program", (filename + ".txt"));

                if (Debug.debug)
                    Console.WriteLine("{0}", e);

                Console.Read();
                System.Environment.Exit(1);
            }
            return path;
        }

        public static List<Task> ParseFile(string path)
        {
            List<Task> taskList = new List<Task>();

            try
            {

                
            }
            catch(Exception e)
            {

            }

            return taskList;
        }

        public static void Main(string[] args)
        {
            string filename = "task_info";  //default name if no input

            //check args for correctness and set custom filename
            CommandLineChecks(args, ref filename);

            //check if filename is valid
            string path = LoadFile(filename);

            //create TaskList and load tasks from file into it
            List<Task> taskList = ParseFile(path);

         
        }

        
    }
}
