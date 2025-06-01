using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class NormalTask : Task
    {
        private DateTime taskDate;
        private bool taskCompleted;
        public NormalTask(string name, string notes, DateTime taskDate, bool taskCompleted) : base(name, notes)
        {
            this.taskDate = taskDate;
            this.taskCompleted = taskCompleted;
        }
        public DateTime TaskDate
        {
            get { return taskDate; }
            set { taskDate = value; }
        }
        public bool TaskCompleted
        {
            get { return taskCompleted; }
            set { taskCompleted = value; }
        }
        public override string ToFile()
        {
            return $"{base.ToFile()}^{taskDate.ToString("M/d/yyyy H:m")}^{taskCompleted}";
        }
    }
}
