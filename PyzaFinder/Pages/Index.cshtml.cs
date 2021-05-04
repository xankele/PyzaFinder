using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PyzaFinder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DumplingContext _db;
        public IndexModel(DumplingContext db)
        {
            _db = db;
        }
        public IEnumerable<DumplingRestaurant> DumplingRestaurants { get; set; }
        public async Task OnGet()
        {
            DumplingRestaurants = await _db.DumplingRestaurants.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var dumpling = await _db.DumplingRestaurants.FindAsync(id);
            if (dumpling == null)
            {
                return NotFound();
            }
            _db.DumplingRestaurants.Remove(dumpling);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
