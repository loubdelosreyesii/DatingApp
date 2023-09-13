using DatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {

    }

    //this will represent the User table 
    public DbSet<AppUser> Users { get; set; }
}
