using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectAssignment
{
    public class Task
    {
        private DateTime finishedTimestamp {get; set;}
        public string TaskDescription {get; set;}
        public Task(string description)
        {
            // A task has a description and a datetime that contains null when the task isn't finished or the date of when the task is finished 
            TaskDescription = description;           
            finishedTimestamp = DateTime.MinValue;
        }


        public void MarkAsFinished()
        {
            finishedTimestamp = DateTime.Now;
        }

        public bool ItemFinished()
        {
            // Do some more here
            if (finishedTimestamp == DateTime.MinValue){
                return false;
            }
            else {
                return true;
            }
        }
    }
}
