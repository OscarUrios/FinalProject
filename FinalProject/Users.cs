using System;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine($"Task added to group {groupname}.");
        }
        else
        {
            Console.WriteLine("Group not found.");
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
}
