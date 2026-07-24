using System;

public class TodoItem
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public bool IsDone { get; set; }
    public Priority Priority { get; set; }
    public TodoItem(int id, string title)
    {
        ID = id;
        Title = title;
        CreatedAt = DateTime.Now;
        CompletedAt = null;
        IsDone = false;
        Priority = Priority.Low;
    }
}