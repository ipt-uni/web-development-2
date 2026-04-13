using lab2.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Degree> Degrees { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<MyUser> MyUsers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
