using FluentApiCourse.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FluentApiCourse.Contexts
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<OfficeAsignment> OfficeAsignments { get; set; }
        public DbSet<OnlineCourse> OnlineCourses { get; set; }
        public DbSet<OnsiteCourse> OnsiteCourses { get; set; }

        /*public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }*/
    }
}
