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
                task = new NormalTask(textBoxName.Text, textBoxNotes.Text, dateTimePickerNewTask.Value, false);
            }
            else
            {
                DateTime hour = DateTime.ParseExact($"{domainUpDown1.Text}:{domainUpDown2.Text}", "H:m", System.Globalization.CultureInfo.InvariantCulture);
                task = new RepeatTask(textBoxName.Text, textBoxNotes.Text, hour);
            }
            SharedInfoAndFunctions.Users.AddTaskToGroup(comboBoxGroup.Text, task);

            Close();
        }
    }
}
