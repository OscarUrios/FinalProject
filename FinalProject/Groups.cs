using System;

// The group class that represents a collection of tasks

class Group
{
    private string name;
    private List<Task> tasks;

    public Group(string name)
    {
        this.name = name;
        tasks = new List<Task>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Task> Tasks
    {
        get { return tasks; }
    }

    public void NewTask(Task task)
    {
        tasks.Add(task);
    }

    public void SaveToFile()
    {
        string filePath = $"{SharedInfoAndFunctions.Users.Username}.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (Task task in tasks)
            {
                writer.WriteLine($"{name}^{task.ToFile()}");
            }
        }
    }
}
