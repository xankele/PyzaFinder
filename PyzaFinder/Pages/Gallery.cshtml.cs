using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PyzaFinder.Pages
{
    public class GalleryModel : PageModel
    {
        private readonly DumplingContext _db;
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public IEnumerable<Photo> Photos { get; set; }
        public GalleryModel(DumplingContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            DumplingRestaurant = await _db.DumplingRestaurants.FindAsync(id);
            Photos = await _db.Photos.Where(j => j.IdRestaurant.Equals(id)).ToListAsync();
        }
    }
}
