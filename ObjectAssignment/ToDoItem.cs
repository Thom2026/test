using System;
using System.Collections.Generic;

// Description on this class => look at Controller for inspiration

namespace ObjectAssignment
{
    public class ToDoItem
    {
        List<Task> tasks;

        public ToDoItem(string shortDescription, string longDescription, DateTime itemDeadline, string firstTaskDescription)
        {
            // Do some more here
        }

        public void AddTask(string TaskDescription)
        {
            // Do some more here
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
