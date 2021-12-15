using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using kjordan_final_project.Model;

namespace kjordan_final_project.Pages.Projects
{
    //This is the Modle page for my Time Allocation DB 
    public class AllocationIndexModel : PageModel
    {
        private readonly kjordan_final_project.Model.Context _context;

        public AllocationIndexModel(kjordan_final_project.Model.Context context)
        {
            _context = context;
        }
        //This creates the list that is generated on the Razor page
        public IList<TimeAllocation> Allocations { get;set; }

        public async Task OnGetAsync()
        {

        
            
            //Here is where I was attempting to include the Owner and Project to the list
            // I was unable to make it work 
            Allocations = await _context.TimeAllocation
                .Include(ta => ta.Owner).ToListAsync();
                

            
        }
    }
}
