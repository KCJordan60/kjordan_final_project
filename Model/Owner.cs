using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

//This creates the entities in the database for the Owners
namespace kjordan_final_project.Model
{
    public class Owner
    {
        public int OwnerID {get; set;}

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string FirsName {get; set;}

        [StringLength(30, MinimumLength = 3)]
        [Required]
        public string LastName {get; set;}

        [MaxLength(3)]
        [Required]
        public string Location {get; set;}

        public List<Project> Projects {get; set;}
        public List<TimeAllocation> Allocations {get; set;}
    }
}
