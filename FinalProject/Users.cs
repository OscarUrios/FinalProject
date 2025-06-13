using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using FinalProject;


// The user class represents a user in the application, managing their groups and tasks.
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
            if (group.Name.Equals(groupname))
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
            DialogResult option = MessageBox.Show($"Group not found. \n " +
                $"Would you like to create a new one?", "Confirmation", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                NewGroup(new Group(groupname));
                AddTaskToGroup(groupname, task);
            }
        }
    }

    public void DeleteTask(string groupName, Task task)
    {
        foreach (Group group in groups)
        {
            if (group.Name.Equals(groupName))
            {
                foreach(Task task1 in group.Tasks)
                {
                    if (task1.Name.Equals(task.Name))
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

    //busca el grupo y devuelve la lista de sus tareas
    public List<Task> ReturnTasks(string groupName)
    {
        List<Task> tasks = new List<Task>();
        foreach (Group group in groups)
        {
            if (group.Name.Equals(groupName))
            {
                tasks = group.Tasks;
            }
        }
        return tasks;
    }

    public void AddGroup(Group group)
    {
        groups.Add(group);
    }

    //guarda los grupos en un archivo
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
