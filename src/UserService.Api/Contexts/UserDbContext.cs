using Microsoft.EntityFrameworkCore;
using UserService.Api.Entities;

namespace UserService.Api.Contexts;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    { }
    
    public DbSet<User> Users { get; set; }
}