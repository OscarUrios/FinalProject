using System;

static class SharedInfoAndFunctions
{
    public static User Users { get; set; }
    public static bool taskFound { get; set; }
}

public struct TaskStatus
{
    public bool IsCompleted { get; set; }
    public DateTime? CompletionDate { get; set; }
}