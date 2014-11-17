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

        public string Report = "";
        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            Desc = shortDescription;
            Description = longDescription;
            ItemDeadl = itemDeadline;
            //lsrjdfhglsfdhgkjdfhgfdsjkæ
            //gggg
            //DavDav
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
                else
                {
                    Task tnew = new Task(desc);
                    tasks.Add(tnew);
                }
                
                
                
            } while (done != true);
        }

        public bool ItemFinished()
        {
            foreach (Task task in tasks)
            {
                if (task.ItemFinished() == false)
                {
                    return false;
                }
            }
            return true;
        }

        public bool DeadlineExceeded()
        {
            // Do some more here
            return false;
        }

        public string GetItemReport()
        {
            Report = "";
            foreach (Task task in tasks)
            {
                Report = Report + task.TaskDescription + ",";
            }
            return Report;
        }
    }
}
