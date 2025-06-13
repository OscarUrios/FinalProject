using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ModTask : Form
    {
        List<Task> taskList = new List<Task>();
        Task task;
        public ModTask(String taskName, String groupName)
        {
            InitializeComponent();
            taskList = SharedInfoAndFunctions.Users.ReturnTasks(groupName);
            bool found = false;
            foreach (Task searchTask in taskList)
            {
                if (searchTask.Name.Equals(taskName))
                {
                    task = searchTask;
                    found = true;
                }
            }
            if (found)
            {
                foreach (Group group in SharedInfoAndFunctions.Users.Groups)
                {
                    comboBoxGroup.Items.Add(group.Name);
                }
                textBoxName.Text = task.Name;
                textBoxNotes.Text = task.Notes;
                if (task is NormalTask normalTask)
                {
                    dateTimePickerNewTask.Value = normalTask.TaskDate;
                    checkBox1.Checked = false;
                }
                else if (task is RepeatTask repeatTask)
                {
                    domainUpDown1.Text = repeatTask.HourRepeat.Hour.ToString();
                    domainUpDown2.Text = repeatTask.HourRepeat.Minute.ToString();
                    checkBox1.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Task not found.");
                SharedInfoAndFunctions.taskFound = false;
                Close();
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            task.Name = textBoxName.Text;
            task.Notes = textBoxNotes.Text;
            if (!checkBox1.Checked)
            {
                DateTime date;
                if (domainUpDown1.Text != null || domainUpDown1.Text != "" ||
                    domainUpDown2.Text != null || domainUpDown2.Text != "")
                {
                    date = DateTime.ParseExact($"{dateTimePickerNewTask.Value.Day} " +
                    $"{dateTimePickerNewTask.Value.Month} {dateTimePickerNewTask.Value.Year} " +
                    $"{domainUpDown1.Text}:{domainUpDown2.Text}", "d M yyyy H:m",
                    System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {
                    date = dateTimePickerNewTask.Value;
                }

                if (task is NormalTask normalTask)
                {
                    normalTask.TaskDate = date;
                }
            }
            else
            {
                DateTime hour = DateTime.ParseExact($"{domainUpDown1.Text}:{domainUpDown2.Text}",
                    "H:m", System.Globalization.CultureInfo.InvariantCulture);
                if (task is RepeatTask repeatTask)
                {
                    repeatTask.HourRepeat = hour;
                }
            }
            Close();
        }
    }
}
