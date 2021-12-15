using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using kjordan_final_project.Model;


namespace kjordan_final_project.Pages.Projects
{
    public class OwnerIndexModel : PageModel
    {
        //This is where I created the Owner Index Page for the Owner Razor page
        private readonly Context _context;
        private readonly ILogger<OwnerIndexModel> _logger;
        public List<Owner> Owners {get; set;}

        public OwnerIndexModel(Context context, ILogger<OwnerIndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Owners = _context.Owner.ToList();
        }
    }
}