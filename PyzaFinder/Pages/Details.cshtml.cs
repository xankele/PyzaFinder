using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace PyzaFinder.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly DumplingContext _db;
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public Link Link { get; set; }
        public Schedule Schedule { get; set; }
        public DetailsModel(DumplingContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            DumplingRestaurant = _db.DumplingRestaurants.Include(n => n.Links).Include(o => o.Schedules).FirstOrDefault(m => m.IdRestaurant == id);
            Link = DumplingRestaurant.Links.First();
            Schedule = DumplingRestaurant.Schedules.First();

        }
    }
}
