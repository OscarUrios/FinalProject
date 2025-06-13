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
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();

            foreach (Group group in SharedInfoAndFunctions.Users.Groups)
            {
                comboBoxGroup.Items.Add(group.Name);
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            Task task = null;
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
                var status = new TaskStatus
                {
                    IsCompleted = false,
                    CompletionDate = date
                };
                task = new NormalTask(textBoxName.Text, textBoxNotes.Text, date ,status);
            }
            else
            {
                DateTime hour = DateTime.ParseExact($"{domainUpDown1.Text}:{domainUpDown2.Text}", 
                    "H:m", System.Globalization.CultureInfo.InvariantCulture);
                task = new RepeatTask(textBoxName.Text, textBoxNotes.Text, hour);
            }
            SharedInfoAndFunctions.Users.AddTaskToGroup(comboBoxGroup.Text, task);

            Close();
        }
    }
}
