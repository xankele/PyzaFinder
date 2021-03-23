using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyzaFinder.Pages
{
    public class EditModel : PageModel
    {
        private DumplingContext _db;
        public EditModel(DumplingContext db)
        {
            _db = db;
        }
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public async Task OnGet(int id)
        {
            DumplingRestaurant = await _db.DumplingRestaurants.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDb = await _db.DumplingRestaurants.FindAsync(DumplingRestaurant.IdRestaurant);
                BookFromDb.Name = DumplingRestaurant.Name;
                BookFromDb.Address= DumplingRestaurant.Address;
                BookFromDb.PhoneNumber = DumplingRestaurant.PhoneNumber;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
