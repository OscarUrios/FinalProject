using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using FinalProject;

class User
{
    private string username;
	private List<Group> groups;

    public User(string username)
    {
        this.username = username;
        groups = new List<Group>();
    }

    public string Username
    {
        get { return username; }
    }

    public List<Group> Groups
    {
        get { return groups; }
    }

    public void NewGroup(Group group)
    {
        this.groups.Add(group);
    }

    public void AddTaskFromFile(string groupName, Task task)
    {
        foreach (Group group in groups)
        {
            if (group.Name == groupName)
            {
                group.NewTask(task);
            }
        }
    }

    public void AddTaskToGroup(string groupname, Task task)
    {
        bool groupFound = false;
        foreach (Group group in groups)
        {
            if (group.Name == groupname)
            {
                group.NewTask(task);
                groupFound = true;
            }
        }
        if (groupFound)
        {
            MessageBox.Show($"Task added to group {groupname}.");
        }
        else
        {
            MessageBox.Show($"Group not found.");
        }
    }

    public void DeleteTask(string groupName, Task task)
    {
        foreach (Group group in groups)
        {
            if (group.Name == groupName)
            {
                foreach(Task task1 in group.Tasks)
                {
                    if (task1.Name == task.Name)
                    {
                        group.Tasks.Remove(task1);
                        MessageBox.Show($"Task {task.Name} deleted from group {groupName}.");
                    }
                }
            }
            else
            {
                MessageBox.Show($"Group not found.");
            }
        }
    }

    public List<Task> ShowTasks(string groupName)
    {
        List<Task> tasks = new List<Task>();
        foreach (Group group in groups)
        {
            if (group.Name == groupName)
            {
                tasks = group.Tasks;
            }
        }
        return tasks;
    }

    public void SaveToFile()
    {
        string filePath = $"{SharedInfoAndFunctions.Users.Username}-group.txt";
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            foreach (Group group in groups)
            {
                writer.WriteLine($"{group.Name}");
            }
        }
    }
}
