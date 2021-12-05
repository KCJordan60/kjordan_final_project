using Microsoft.EntityFrameworkCore;

//This is how the app creates and decides where to store the database
namespace kjordan_final_project.Model
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options) : base(options)
        {

        }

        
        public DbSet<Project> Project {get; set;}
        
   
    }
}