using Microsoft.EntityFrameworkCore;
using kjordan_final_project.Model;

//This is how the app creates and decides where to store the database
namespace kjordan_final_project.Model
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options)
        {

        }

        
        public DbSet<Project> Project {get; set;}

        
        public DbSet<Owner> Owner { get; set; }

        
        public DbSet<TimeAllocation> TimeAllocation { get; set; }
        
   
    }
}