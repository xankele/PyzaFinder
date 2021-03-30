using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Npgsql;

namespace PyzaFinder.Pages
{
    public class EditModel : PageModel
    {
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=studia;Database=pierogi");
        }
        private static void EditRecordRestaurant(int obcy, string name, string address, string phone_number, string description)
        {
            using (NpgsqlConnection con = GetConnection())//nawi�zanie po��czenia z baz�
            {
                string query = $"update public.dumpling_restaurant SET name='{name}',address='{address}',phone_number='{phone_number}', description='{description}' WHERE id_restaurant='{obcy}'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Record Inserted");
                }
            }
        }
        private static void EditRecordLink(int obcy, string page, string instagram, string facebook)
        {
            using (NpgsqlConnection con = GetConnection())//nawi�zanie po��czenia z baz�
            {
                string query = $"update public.links set page_link='{page}',facebook_link='{facebook}',instagram_link='{instagram}' where id_restaurant='{obcy}'";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                con.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    Console.WriteLine("Record Inserted");
                }
            }
        }
        private static void EditRecordCoord(int obcy, double? x, double? y)
        {
            using (NpgsqlConnection con = GetConnection())//nawi�zanie po��czenia z baz�
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
        private static void EditRecordSchedule(int obcy, string mon, string tue, string wed, string thu, string fri, string sat, string sun)
        {
            using (NpgsqlConnection con = GetConnection())//nawi�zanie po��czenia z baz�
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
        private DumplingContext _db;
        public EditModel(DumplingContext db)
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
        public async Task OnGet(int id)
        {
            int id_dupa = id;
            DumplingRestaurant = await _db.DumplingRestaurants.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //var DumpFromDb = await _db.DumplingRestaurants.FindAsync(DumplingRestaurant.IdRestaurant);
                //DumpFromDb.Name = DumplingRestaurant.Name;
                //DumpFromDb.Address= DumplingRestaurant.Address;
                //DumpFromDb.PhoneNumber = DumplingRestaurant.PhoneNumber;
                await _db.SaveChangesAsync();

                EditRecordRestaurant(DumplingRestaurant.IdRestaurant, DumplingRestaurant.Name, DumplingRestaurant.Address, DumplingRestaurant.PhoneNumber, DumplingRestaurant.Description);
                //EditRecordLink(DumplingRestaurant.IdRestaurant, Link.PageLink, Link.InstagramLink, Link.FacebookLink);
                //EditRecordCoord(DumplingRestaurant.IdRestaurant, Coordinate.CoordinateX, Coordinate.CoordinateY);
                //EditRecordSchedule(DumplingRestaurant.IdRestaurant, Schedule.Monday, Schedule.Tuesday, Schedule.Wednesday, Schedule.Thursday, Schedule.Friday, Schedule.Saturday, Schedule.Sunday);
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
