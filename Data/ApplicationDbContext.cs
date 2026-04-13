using lab2.Data.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Degree> Degrees { get; set; } = null!;
    public DbSet<Registration> Registrations { get; set; } = null!;
    public DbSet<MyUser> MyUsers { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Professor> Professors { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
}
