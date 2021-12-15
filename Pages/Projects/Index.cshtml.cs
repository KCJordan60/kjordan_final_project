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
    public class IndexModel : PageModel
    {
        private readonly kjordan_final_project.Model.Context _context;

        public IndexModel(kjordan_final_project.Model.Context context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 5;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}

        public async Task OnGetAsync()
        {

        
            var query = _context.Project.Select(p => p);

            switch (CurrentSort)
            {
                case "owner_asc":
                    query = query.OrderBy(p => p.Owner);
                    break;
                    case "owner_dsc":
                    query = query.OrderByDescending(p => p.Owner);
                    break;
            }

            Project = await _context.Project
                .Include(p => p.Owner).ToListAsync();
                

            Project = await _context.Project
                .Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
