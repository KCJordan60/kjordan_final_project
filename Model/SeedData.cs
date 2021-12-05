using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

//This was created to initalize the database
namespace kjordan_final_project.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }
                context.Project.AddRange(
                    new Project{
                        ProjName = "Project 1", ProjDisc = "Install new controls system", StartDate = DateTime.Parse("11/20/21"), EndDate = DateTime.Parse("12/30/22")
                    },
                    new Project{
                        ProjName = "Project 2", ProjDisc = "Upgrade controls system", StartDate = DateTime.Parse("11/20/21"), EndDate = DateTime.Parse("12/30/22")
                    },
                    new Project{
                        ProjName = "Project 2", ProjDisc = "Upgrade controls system", StartDate = DateTime.Parse("11/20/21"), EndDate = DateTime.Parse("12/30/22")
                    },
                    new Project{
                        ProjName = "Project 9", ProjDisc = "Install new controls system", StartDate = DateTime.Parse("11/20/21"), EndDate = DateTime.Parse("12/30/22")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}