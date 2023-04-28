namespace CRUD.Models;

public class TaskModel
{
    public string? TaskName { get; set; }
    
    public bool IsPrivate { get; set; }

    private DateTime DueDate { get; set; }
    
}