using FluentApiCourse.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FluentApiCourse.Contexts
{
    public interface IApplicationDbContext
    {
        DbSet<Course> Courses { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Details> Details { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<OfficeAsignment> OfficeAsignments { get; set; }
        DbSet<OnlineCourse> OnlineCourses { get; set; }
        DbSet<OnsiteCourse> OnsiteCourses { get; set; }

        Task<int> SaveChanges();
    }
}