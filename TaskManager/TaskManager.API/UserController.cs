using Microsoft.AspNetCore.Mvc;
using TaskManager.API.Models;
using TaskManager.Core.Interfaces;
using TaskManager.Domain.Entities;

namespace TaskManager.API;

[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] UserDto user)
    {
        var id = await _userRepository.AddAsync(new User
        {
            Username = user.Username,
            Email = user.Email
        });
        return Ok(id);
    }

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _userRepository.GetByIdAsync(id);
        
        if(result == null)
            return NotFound();
        
        return Ok(new UserDto(result.Username, result.Email));
    }
}