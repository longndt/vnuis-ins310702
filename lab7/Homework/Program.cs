using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    //menu-based program
    internal class Program
    {
        static void Main(string[] args)
        {
            //define task list with List collection
            List<Task> taskList = new List<Task>()
            {
                new Task("do homework","homework c#",DateTime.UtcNow, 5, true),
            };

       

            int choice = 0;

            //use "while" loop to repeat program
            while (choice != 4)
            {
                //display menu to console
                Console.WriteLine("Task Manager Application");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                //get input from user
                //choice = Convert.ToInt16(Console.ReadLine());
                choice = int.Parse(Console.ReadLine());
                //execute user's selection with "switch..case"
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Viewing tasks");
                        //View tasks
                        foreach (string s in taskList)
                        {
                            Console.WriteLine("Task: {0}", s);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Adding tasks");
                        //Add new Task
                        Console.Write("Enter new task: ");
                        string newTask = Console.ReadLine();
                        taskList.Add(newTask);
                        break;
                    case 3:
                        Console.WriteLine("Deleting tasks");
                        //hint: ArrayList.Remove() or ArrayList.RemoveAt()
                        break;
                    case 4:
                        Console.WriteLine("Exiting program ...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Select again !");
                        break;
                }
            }
        }
    }
}
