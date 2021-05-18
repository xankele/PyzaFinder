using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyzaFinder.Pages
{
    public class OpinionModel : PageModel
    {
        private readonly DumplingContext _db;
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public IEnumerable<Opinion> Opinions { get; set; }
        public OpinionModel(DumplingContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            DumplingRestaurant = await _db.DumplingRestaurants.FindAsync(id);
            Opinions = _db.Opinions.Where(j => j.IdRestaurant.Equals(id));
        }
    }
}
