using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace PyzaFinder.Pages
{
    public class OpinionModel : PageModel
    {
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=studia;Database=pierogi");
        }
        private static void InsertOpinion(int obcy, string comm, DateTime? datetime, int grade, string name)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                string query = $"insert into public.opinion(id_restaurant,comment,datetime,grade,name)values('{obcy}','{comm}','{datetime}','{grade}','{name}')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Record Inserted");
                }
            }
        }
        private readonly DumplingContext _db;
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        [BindProperty]
        public Opinion Opinion { get; set; }
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
        public async Task<IActionResult> OnPost(int id)
        {
            OnGet(id);
            if (ModelState.IsValid)
            {
                await _db.DumplingRestaurants.AddAsync(DumplingRestaurant);
                InsertOpinion(DumplingRestaurant.IdRestaurant, Opinion.Comment, DateTime.Now, Opinion.Grade, Opinion.Name);
                return RedirectToPage("Map");
            }
            else
            {
                return Page();
            }
        }
    }
}
