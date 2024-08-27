using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorProject.Data;
using RazorProject.Models;

namespace RazorProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
            Cars = new List<Car>();
        }

        public IList<Car> Cars { get; set; }

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
