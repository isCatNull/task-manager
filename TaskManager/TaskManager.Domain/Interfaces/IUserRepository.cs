using TaskManager.Domain.Entities;

namespace TaskManager.Core.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(int userId);
    Task<int> AddAsync(User user);
}