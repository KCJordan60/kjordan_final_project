using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Collections.Generic;

//This was created to initalize the database
namespace kjordan_final_project.Model
{
    public static class SeedData
    {
        public static void InitializeDb(IServiceProvider serviceProvider)
        {
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                if (context.Project.Any())
                {
                    return;
                }

                 List<Owner> owners = new List<Owner>{
                    new Owner {FirsName = "Kevin", LastName = "Jordan", Location = "AMA",
                        Projects = new List<Project> {
                            new Project {ProjName = "Project 1", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 2", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 3", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 4", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 5", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 6", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 7", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 8", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 9", ProjDisc = "Install new controls system"}
                        }
                    },
                    new Owner {FirsName = "Jeff", LastName = "Snyder", Location = "LUB",
                        Projects = new List<Project> {
                            new Project {ProjName = "Project 10", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 11", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 12", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 13", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 14", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 15", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 16", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 17", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 18", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 19", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 20", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 21", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 22", ProjDisc = "Upgrade controls system"}
                        }
                    },
                    new Owner {FirsName = "Clint", LastName = "Burton", Location ="LUB",
                        Projects = new List<Project> {
                            new Project {ProjName = "Project 23", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 24", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 25", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 27", ProjDisc = "Upgrade controls system"},
                            new Project {ProjName = "Project 29", ProjDisc = "Install new controls system"},
                            new Project {ProjName = "Project 30", ProjDisc = "Upgrade controls system"}
                        }
                    }
                    
                };
                context.AddRange(owners);

                               

                List<TimeAllocation> allocations = new List<TimeAllocation>{
                    new TimeAllocation {WorkDate = DateTime.Parse("12/01/2021"), AdminTime = 8.0},
                    new TimeAllocation {WorkDate = DateTime.Parse("12/02/2021"), OnsiteTime = 8.0},
                    new TimeAllocation {WorkDate = DateTime.Parse("12/04/2021"), CommTime = 8.0},
                    new TimeAllocation {WorkDate = DateTime.Parse("12/01/2021"), AdminTime = 8.0},
                    new TimeAllocation {WorkDate = DateTime.Parse("12/03/2021"), OnsiteTime = 8.0}
                };
                context.AddRange(allocations);
                
                context.SaveChanges();
            }
        }
    }
}