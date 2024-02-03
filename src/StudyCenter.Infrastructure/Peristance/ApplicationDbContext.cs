using Microsoft.EntityFrameworkCore;
using StudyCenter.Domain.Models;
using StudyCenter.Service.Abstraction.DataAccess;

namespace StudyCenter.Infrastructure.Peristance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            Database.Migrate();
        }
        
        public DbSet<Events> Event { get; set; }
        public DbSet<Food_Category> Food_Categories { get; set; }
        public DbSet<FoodComment> Food_Comments { get; set; }
        public DbSet<Foods> Foods { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<School_Expence> School_Expences { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Teacher_Education> Teacher_Educations { get; set; }
        public DbSet<TeacherClass> TeacherClasses { get; set; }
        public DbSet<Unpaid_Student> Unpaid_Students { get; set; }
    }
}
