using System;

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
        this.tasks.Add(task);
    }
}
