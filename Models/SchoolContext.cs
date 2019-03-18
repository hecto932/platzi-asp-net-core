using Microsoft.EntityFrameworkCore;

namespace platzi_asp_net_core.Models
{
  public class SchoolContext : DbContext
  {
    public DbSet<School> Schools { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Evaluation> Evaluations { get; set; }
  }

  public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
  {

  }
}