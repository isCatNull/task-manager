using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;

namespace TaskManager.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByIdAsync(int userId) => await _context.Users.FindAsync(userId);

    public async Task<int> AddAsync(User user)
    {
        var id = await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return user.Id;
    }
}