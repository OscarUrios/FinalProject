
class Task
{
    private string name;
    private string notes;
    private DateTime dueDate;
    private bool stage;

    public Task(string name, string notes, DateTime dueDate, bool stage)
    {
        this.name = name;
        this.notes = notes;
        this.dueDate = dueDate;
        this.stage = stage;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Notes
    {
        get { return notes; }
        set { notes = value; }
    }

    public DateTime DueDate
    {
        get { return dueDate; }
        set { dueDate = value; }
    }

    public bool Stage
    {
        get { return stage; }
        set { stage = value; }
    }

    public override string ToString()
    {
        return "Name: " + name + "\nDescription: " + notes + "\nDue Date: " + dueDate + "\nStage: " + stage;
    }
}