using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace PyzaFinder.Pages
{
    public class MapModel : PageModel
    {
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=12345;Database=pierogi");
        }
        private readonly DumplingContext _db;

        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        public Schedule Schedule { get; set; }
        public IEnumerable<DumplingRestaurant> DumplingRestaurants { get; set; }
        public MapModel(DumplingContext db)
        {
            _db = db;
        }
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<DumplingRestaurant> Search(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return _db.DumplingRestaurants;
            }
            return _db.DumplingRestaurants.Where(e => e.Name.Contains(searchTerm)).ToList();
        }
        public async Task OnGet()
        {
            DumplingRestaurants = await _db.DumplingRestaurants.ToListAsync();
            DumplingRestaurants = Search(SearchTerm);
        }
    }
}