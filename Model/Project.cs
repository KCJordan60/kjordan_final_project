using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

//This creates the entities in the database 
namespace kjordan_final_project.Model
{
    public class Project
    {
        public int ProjectID {get; set;}

        [MaxLength(30)]
        [Display(Name = "Project Name")]
        public string ProjName {get; set;}

        [Display(Name = "Description")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string ProjDisc {get; set;}

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate {get; set;}

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate {get; set;}

               
               
    }
}