using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalProject
{
    public partial class Home : Form
    {
        void FillTasks()
        {
            using (StreamReader file = new StreamReader($"{SharedInfoAndFunctions.Users.Username}.txt"))
            {
                string line;
                do
                {
                    line = file.ReadLine();
                    if (line != null)
                    {
                        string[] parts = line.Split('^');

                        string groupName = parts[0];

                        bool groupFound = false;
                        foreach (Group group in SharedInfoAndFunctions.Users.Groups)
                        {
                            if (group.Name == groupName)
                            {
                                groupFound = true;
                            }
                        }
                        if (!groupFound)
                        {
                            SharedInfoAndFunctions.Users.NewGroup(new Group(groupName));
                        }

                        string taskName = parts[1];
                        string taskNotes = parts[2];
                        if (parts.Length == 5)
                        {
                            DateTime taskDate = DateTime.ParseExact($"{parts[3]}", "d/M/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                            bool taskCompleted = bool.Parse(parts[4]);
                            NormalTask task = new NormalTask(taskName, taskNotes, taskDate, taskCompleted);
                            SharedInfoAndFunctions.Users.AddTaskFromFile(groupName, task);
                        }
                        else
                        {
                            DateTime HourRepeat = DateTime.ParseExact($"{parts[3]}", "H:m", System.Globalization.CultureInfo.InvariantCulture);
                            RepeatTask task = new RepeatTask(taskName, taskNotes, HourRepeat);
                            SharedInfoAndFunctions.Users.AddTaskFromFile(groupName, task);
                        }
                    }
                } while (line != null);
            }
        }

        void CloseApp()
        {
            foreach (Group group in SharedInfoAndFunctions.Users.Groups)
            {
                using (StreamWriter file = new StreamWriter($"{SharedInfoAndFunctions.Users.Username}-group.txt"))
                {
                    file.WriteLine(group.Name);
                }
                group.SaveToFile();
            }
            SharedInfoAndFunctions.Users.SaveToFile();
        }

        Task SearchTask()
        {
            Task founTask = null;
            foreach (Task task in SharedInfoAndFunctions.Users.ShowTasks(listBoxGroups.SelectedItem.ToString()))
            {
                if (task.Name == listBoxTasks.SelectedItem.ToString())
                {
                    founTask = task;
                }
            }
            return founTask;
        }


        public Home()
        {
            InitializeComponent();

            FillTasks();

            foreach (Group group in SharedInfoAndFunctions.Users.Groups)
            {
                listBoxGroups.Items.Add(group.Name);
            }
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            NewTask newTask = new NewTask();
            newTask.ShowDialog();
        }

        private void BTNDelTask_Click(object sender, EventArgs e)
        {
            foreach (Task task in SharedInfoAndFunctions.Users.ShowTasks(listBoxGroups.SelectedItem.ToString()))
            {
                if (task.Name == listBoxTasks.SelectedItem.ToString())
                {

                }
            }
        }

        private void BTNModTask_Click(object sender, EventArgs e)
        {

        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{SharedInfoAndFunctions.Users.Username}.txt"))
            {
                File.Delete($"{SharedInfoAndFunctions.Users.Username}.txt");

            }
            else
            {
                MessageBox.Show("User not found.");
            }
            Login login = new Login();
            login.ShowDialog();
            Hide();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            CloseApp();
            Application.Exit();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseApp();
            Application.Exit();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                List<Task> tasks = SharedInfoAndFunctions.Users.ShowTasks(listBoxGroups.SelectedItem.ToString());

                if (tasks.Count > 0)
                {
                    listBoxTasks.Items.Clear();
                    foreach (Task task in tasks)
                    {
                        listBoxTasks.Items.Add(task.Name);
                    }
                }
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                Task task = SearchTask();
                if (task != null)
                {
                    textBoxNotes.Text = task.Notes;
                    textBoxName.Text = task.Name;
                    if (task is NormalTask)
                    {
                        textBoxDeadline.Text = Convert.ToString(((NormalTask)task).TaskDate);
                    }
                    else
                    {
                        textBoxDeadline.Text = Convert.ToString(((RepeatTask)task).HourRepeat);
                    }
                }

            }
        }

        private void BTNNewGroup_Click(object sender, EventArgs e)
        {
            Hide();
            NewGroup newGroup = new NewGroup();
            newGroup.ShowDialog();
        }

        private void BTNDelGroup_Click(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem != null)
            {
                string groupName = listBoxGroups.SelectedItem.ToString();
                for (int i=0; i < SharedInfoAndFunctions.Users.Groups.Count; i++)
                {
                    if (SharedInfoAndFunctions.Users.Groups[i].Name == groupName)
                    {
                        SharedInfoAndFunctions.Users.Groups.Remove(SharedInfoAndFunctions.Users.Groups[i]);
                    }
                }
                listBoxGroups.Items.Remove(groupName);
            }
        }
    }
}
