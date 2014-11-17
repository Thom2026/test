using System;
using System.Collections.Generic;

namespace ObjectAssignment
{
    public class Controller
    {
        List<ToDoItem> _items = new List<ToDoItem>();

        public Controller()
        {
            // Consider what must be done in this constructor
        }

        public void AddNewToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            string sDescip = shortDescription;
            string lDescip = longDescription;
            DateTime iDeadline = itemDeadline;
            string fTaskDescrip = firstTaskDescription;
            ToDoItem TDI = new ToDoItem(sDescip, lDescip, iDeadline, fTaskDescrip);
            TDI.AddTask(fTaskDescrip);
            _items.Add(TDI);
            // A to do item contains 
            // a short description
            // a long description
            // a deadline
            // and one or more tasks that each contains a description
        }

        /// <summary>
        /// Creates a report on Items
        /// </summary>
        /// <param name="OnlyNotfinished">True = Items that aren't finished</param>
        /// <returns>The report in one string</returns>
        public string GetAllItemReports(bool OnlyNotfinished = false)
        
        {
            // Do some more here
            string print = "";
            foreach (ToDoItem todo in _items)
            {
                if (OnlyNotfinished == true)
                {
                    if (todo.ItemFinished() == false)
                    {
                        print = print + todo.Description + "\n" + todo.GetItemReport();
                    }
                }
                else
                {
                    print = print + todo.Description + "\n" + todo.GetItemReport();
                }
            }
            return print;
        }
    }
}
