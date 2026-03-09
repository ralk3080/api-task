namespace Api.Models;

public class TaskItem{
    public int Id{get;set;}
    public string Title{get;set;}
    public string? Descripcion{get;set;}
    public bool IsCompleted{get;set;}
    public Priority Priority{get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime? UpdatedAt{get;set;}
}
public enum Priority{
    Low =0,
    Medium =1,
    High=2,
}