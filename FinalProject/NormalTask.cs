using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task class that represents a normal task, inheriting from Task

namespace FinalProject
{
    class NormalTask : Task
    {
        private DateTime taskDate;
        private TaskStatus status;

        public NormalTask(string name, string notes, DateTime taskDate, TaskStatus status) : base(name, notes)
        {
            this.taskDate = taskDate;
            this.status = status;
        }
        public DateTime TaskDate
        {
            get { return taskDate; }
            set { taskDate = value; }
        }
        public TaskStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        public override string ToFile()
        {
            return $"{base.ToFile()}^{taskDate.ToString("M/d/yyyy H:m")}^{status.IsCompleted}^{status.CompletionDate}";
        }
    }
}
