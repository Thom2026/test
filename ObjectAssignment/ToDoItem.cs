using System;
using System.Collections.Generic;

// Description on this class => look at Controller for inspiration

namespace ObjectAssignment
{
    public class ToDoItem
    {
        List<Task> tasks = new List<Task>();
        public string Desc { get; set; }
        public string Description { get; set; }
        public DateTime ItemDeadl { get; set; }

        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            Desc = shortDescription;
            Description = longDescription;
            ItemDeadl = itemDeadline;
        }

        public void AddTask(string TaskDescription)
        {
            string tDesc = TaskDescription;
            Task tfirst = new Task(tDesc);
            tasks.Add(tfirst);

            bool done = false;
            do
            {
                Console.WriteLine("Enter tasks description or press 0 to go back:");
                string desc = Console.ReadLine();
                if (desc == "0")
                {
                    done = true;
                }
                Task tnew = new Task(desc);
                tasks.Add(tnew);
                
                
                
            } while (done != true);
        }

        public bool ItemFinished()
        {
            // Do some more here
            return false;
        }

        public bool DeadlineExceeded()
        {
            // Do some more here
            return false;
        }

        public string GetItemReport()
        {
            return "ToDoItem.GetItemReport()";
        }
    }
}
