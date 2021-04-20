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
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=romaniec111;Database=pierogi");
        }
        private static int SelectSchedule(string day, int obcy)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                int val = 100;
                string query = $"select {day} from public.schedules where id_restaurant={obcy}";
                con.Open();
                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                // Execute the query and obtain the value of the first column of the first row
                if (command.ExecuteScalar() != null)
                {
                    Int32 count = (Int32)command.ExecuteScalar();
                    val = count;
                }
                con.Close();
                return val;
            }
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
        public async Task OnGet()
        {
            DumplingRestaurants = await _db.DumplingRestaurants.ToListAsync();
        }
    }
}
