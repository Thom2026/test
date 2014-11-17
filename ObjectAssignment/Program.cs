using System;
using System.Collections.Generic;

namespace ObjectAssignment
{
    public class Program
    {
        static Controller _controller;

        static void Main(string[] args)
        {
            // Create a new instance of the controller
            _controller = new Controller();

            do {
                PrintMenu();
            } while (MakeChoice() == false);
        }

        /// <summary>
        /// Prints the menu
        /// </summary>
        private static void PrintMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-- The To Do list --------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1. Enter new \"To Do Item\"");
            Console.WriteLine("2. Print all \"To Do Items\"");
            Console.WriteLine("3. Print all not finished \"To Do Items\"");
            Console.WriteLine("9. Stop program");
        }

        /// <summary>
        /// Receives input and executes the functionality according to the selected menu
        /// </summary>
        /// <returns>True when the program should stop. Otherwise it returns False</returns>
        private static bool MakeChoice()
        {
            bool stopProgram = false;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    HandleNewToDoItem();
                    stopProgram = false;
                    break;
                case '2':
                    HandlePrintAllToDoItems();
                    stopProgram = false;
                    break;
                case '3':
                    HandlePrintAllNotFinishedToDoItems();
                    stopProgram = false;
                    break;
                case '9':
                    stopProgram = true;
                    break;
            }
            return stopProgram;
        }

        /// <summary>
        /// Handles all user interface - Change method according to it's name
        /// </summary>
        private static void HandlePrintAllNotFinishedToDoItems()
        {
            Console.WriteLine("Print all not finished \"To Do Items\":");

            // Do some more here
            Console.WriteLine(_controller.GetAllItemReports(true));
        }

        /// <summary>
        /// Handles all user interface - Change method according to it's name
        /// </summary>
        private static void HandlePrintAllToDoItems()
        {
            Console.WriteLine("Print all \"To Do Items\":");

            // Do some more heres
            Console.WriteLine(_controller.GetAllItemReports());
        }

        /// <summary>
        /// Handles all user interface - Change method according to it's name
        /// </summary>
        private static void HandleNewToDoItem()
        {
            // Needs input from user to replace "" in the method
            Console.WriteLine("New \"To Do Item\":");
            Console.WriteLine("Give a short desciption of ToDoItem:");
            string sDesc = Console.ReadLine();
            Console.WriteLine("Give a Long desciption of ToDoItem:");
            string lDesc = Console.ReadLine();
            Console.WriteLine("Give a desciption of first task:");
            string fTDesc = Console.ReadLine();

            // Do some more here
            _controller.AddNewToDoItem(sDesc, lDesc, DateTime.Now, fTDesc);
        }
    }
}
