namespace TaskManager.Domain.Entities;

public class User
{
    public int Id { get; init; }
    public string Username { get; init; } = null!;
    public string Email { get; init; } = null!;
    public IEnumerable<Task> Tasks { get; init; } = new List<Task>();
    public DateTime CreatedAt { get; init; }
}