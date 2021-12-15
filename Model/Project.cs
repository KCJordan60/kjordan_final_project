using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

//This creates the entities in the database for the Projects entered
namespace kjordan_final_project.Model
{
    public class Project
    {
        public int ProjectID {get; set;}

        [MaxLength(30)]
        [Display(Name = "Project Name")]
        [Required]
        public string ProjName {get; set;}

        [Display(Name = "Description")]
        [Required]
        public string ProjDisc {get; set;}

        public int OwnerId {get; set;}

        public Owner Owner {get; set;}
    }
}