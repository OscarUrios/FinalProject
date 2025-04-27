using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class RepeatTask : Task
    {
        private DateTime hourRepeat;
        public RepeatTask(string name, string notes, DateTime hourRepeat) : base(name, notes)
        {
            this.hourRepeat = hourRepeat;
        }
        public DateTime HourRepeat
        {
            get { return hourRepeat; }
            set { hourRepeat = value; }
        }
        public override string ToFile()
        {
            return $"{base.ToFile()}^{hourRepeat}";
        }
    }
}
