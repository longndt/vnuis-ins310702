using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Task
    {
        private string taskName;
        private string taskDescription;
        private DateTime taskDeadline;
        private int taskTotal;
        private bool taskFinished;

        public Task(string taskName, string taskDescription, DateTime taskDeadline, int taskTotal, bool taskFinished) { 
            this.taskName = taskName;
            this.taskDescription = taskDescription;
            this.taskDeadline = taskDeadline;
            this.taskTotal = taskTotal;
            this.taskFinished = taskFinished;
        }
    }
}
