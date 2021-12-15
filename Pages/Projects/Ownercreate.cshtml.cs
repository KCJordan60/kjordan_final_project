using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using kjordan_final_project.Model;

//This page creates a new Owner to be entered into the database
namespace kjordan_final_project.Pages.Projects
{
     public class OwnerCreateModel : PageModel
    {
        //This connects the users input into the Owner Database 
        private readonly kjordan_final_project.Model.Context _context;
       

        public OwnerCreateModel(kjordan_final_project.Model.Context context)
        {
            _context = context;
           
        }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        //This collects and stores the users information
        [BindProperty]
        public Owner Owner {get; set;}

        //This verifies that the user input the proper data and returns the user the the create page if not valid
        //or sends the user back to the index page if the data is valid 
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Owner.Add(Owner);
            await _context.SaveChangesAsync();

            return RedirectToPage("./OwnerIndex");
        }
    }
}