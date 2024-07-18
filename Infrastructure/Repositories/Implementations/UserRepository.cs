using Application.Repositories;
using Domain.Models;
using Infrastructure.Context;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations;

public class UserRepository : CommonIdentityRepository<User>, IUserRepository
{
    private readonly EducationalFormsContext _context;

    public UserRepository(EducationalFormsContext context) : base(context)
    {
        _context = context;
    }

    public async Task<User?> GetUserByUsernameAndPassword(string username, string password)
    {
        return await _context.User.Where(t => t.UserName == username && t.Password == password && t.IsActive)
            .Include(t => t.Consultant).FirstOrDefaultAsync();
    }
}