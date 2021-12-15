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
    public class DetailsModel : PageModel
    {
        private readonly kjordan_final_project.Model.Context _context;

        public DetailsModel(kjordan_final_project.Model.Context context)
        {
            _context = context;
        }

        public Project Project { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project
                .Include(p => p.Owner).FirstOrDefaultAsync(m => m.ProjectID == id);

            if (Project == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
