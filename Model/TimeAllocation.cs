using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

//This creates the entities in the database for the Time Alloccation 
//it is not working like I had planed and did not have time to fix it 
// I believe I am missing an connector that would join this to my Owner projects list
namespace kjordan_final_project.Model
{
    public class TimeAllocation
    {
        
        public int TimeAllocationID {get; set;}

        [Display(Name = "Date of Performed")]
        [DataType(DataType.Date)]
        public DateTime WorkDate {get; set;}

        [Range(.25,16.0)]
        public Double OnsiteTime {get; set;}

        [Range(.25,16.0)]
        public Double AdminTime {get; set;}

        [Range(.25,16.0)]
        public Double CommTime {get; set;}

        public Owner Owner {get; set;}
        public Project Project {get; set;}
    }
}