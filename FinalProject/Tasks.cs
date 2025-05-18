
abstract class Task
{
    private string name;
    private string notes;

    public Task(string name, string notes)
    {
        this.name = name;
        this.notes = notes;
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

    public override string ToString()
    {
        return "Name: " + name + "\nDescription: " + notes;
    }

    public virtual string ToFile()
    {
        return $"{name}^{notes}";
    }
}