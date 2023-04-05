using gecoTM.Models.Employee;
using gecoTM.Models.Timesheet;
using Microsoft.EntityFrameworkCore;
using gecoTM.Models.Project;
using gecoTM.Models.UpcomingEvent;
using gecoTM.Models.WebUser;
using gecoTM.Models.Blog;

namespace gecoTM.Models
{
    public class TmContext : DbContext
    {
        public TmContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<TimesheetModel> Timesheet { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<ProjectModel> Project { get; set; }
        public DbSet<UpcomingEventModel> UpcomingEvent { get; set; }
        public DbSet<WebUserModel> WebUser { get; set; }
        public DbSet<BlogModel> Blog { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("TrustServerCertificate=True;Server=LAPTOP-MTJR9ITS\\SQLEXPRESS;Database=gecoTmDatabase;Trusted_Connection=True");
        //}
    }
}
