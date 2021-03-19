using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyzaFinder.Pages
{
    public class CreateModel : PageModel
    {
        private readonly DumplingContext _db;

        public CreateModel(DumplingContext db)
        {
            _db = db;
        }
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.DumplingRestaurants.AddAsync(DumplingRestaurant);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
