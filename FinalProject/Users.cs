using System;

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

    public void NewGroup(Group group)
    {
        this.groups.Add(group);
    }
}
