using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace PyzaFinder.Pages
{
    public class CreateModel : PageModel
    {
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=studia;Database=pierogi");
        }
        private static void InsertRecordLink(int obcy, string page, string instagram, string facebook)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                string query = $"insert into public.links(id_restaurant, page_link,facebook_link,instagram_link)values('{obcy}','{page}','{instagram}','{facebook}')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Record Inserted");
                }
            }
        }
        private static void InsertRecordCoord(int obcy, string x, string y)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                string query = $"insert into public.coordinates(id_restaurant, coordinate_x, coordinate_y)values('{obcy}','{x}','{y}')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Record Inserted");
                }
            }
        }
        private static void InsertRecordSchedule(int obcy, string mon, string tue, string wed, string thu, string fri, string sat, string sun)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                string query = $"insert into public.schedule(id_restaurant, monday, tuesday, wednesday, thursday, friday, saturday, sunday)values('{obcy}','{mon}','{tue}','{wed}','{thu}','{fri}','{sat}','{sun}')";
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

        public CreateModel(DumplingContext db)
        {
            _db = db;
        }
        [BindProperty]
        public DumplingRestaurant DumplingRestaurant { get; set; }
        [BindProperty]
        public Link Link { get; set; }
        [BindProperty]
        public Coordinate Coordinate { get; set; }
        [BindProperty]
        public Schedule Schedule { get; set; }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.DumplingRestaurants.AddAsync(DumplingRestaurant);
                await _db.SaveChangesAsync();
                InsertRecordLink(DumplingRestaurant.IdRestaurant, Link.PageLink, Link.InstagramLink, Link.FacebookLink);
                InsertRecordCoord(DumplingRestaurant.IdRestaurant, Coordinate.CoordinateX, Coordinate.CoordinateY);
                InsertRecordSchedule(DumplingRestaurant.IdRestaurant, Schedule.Monday, Schedule.Tuesday, Schedule.Wednesday, Schedule.Thursday, Schedule.Friday, Schedule.Saturday, Schedule.Sunday);
                return RedirectToPage("AdminPanel");
            }
            else
            {
                return Page();
            }
        }
    }
}