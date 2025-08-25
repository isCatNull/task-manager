namespace TaskManager.Domain.Entities;

public class Task
{
    public int Id { get; init; }
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public int UserId { get; init; }
    public User User { get; init; } = null!;
    public DateTime CreatedAt { get; init; }
}