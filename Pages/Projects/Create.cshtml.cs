using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using kjordan_final_project.Model;

namespace kjordan_final_project.Pages.Projects
{
    public class CreateModel : PageModel
    {
        private readonly kjordan_final_project.Model.Context _context;

        public CreateModel(kjordan_final_project.Model.Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OwnerId"] = new SelectList(_context.Owner, "OwnerID", "FirsName");
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
