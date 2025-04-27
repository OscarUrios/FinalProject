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

            for (int i = 0; i < 24; i++)
            {
                domainUpDown1.Items.Add(Convert.ToString(i));
            }
            for (int i = 0; i < 60; i++)
            {
                domainUpDown2.Items.Add(Convert.ToString(i));
            }
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
            if (checkBox1 == null)
            {
                NormalTask task = new NormalTask(textBoxName.Text, textBoxNotes.Text, dateTimePickerNewTask.Value, false);
                SharedInfoAndFunctions.Users.AddTaskToGroup(comboBoxGroup.SelectedText, task);
            }
            else
            {
                DateTime hour = DateTime.ParseExact($"{domainUpDown1.Text}:{domainUpDown2.Text}", "HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                RepeatTask task = new RepeatTask(textBoxName.Text, textBoxNotes.Text, hour);
                SharedInfoAndFunctions.Users.AddTaskToGroup(comboBoxGroup.SelectedText, task);
            }
            Close();
        }
    }
}
