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
<<<<<<< Updated upstream
=======
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=romaniec111;Database=pierogi");
        }
        private static void EditRecordRestaurant(int obcy, string name, string address, string phone_number, string description)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
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
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
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
        private static void EditRecordSchedule(int obcy, string mon, string tue, string wed, string thu, string fri, string sat, string sun)
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
        private static int SelectLink(int obcy)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                int val = 100;
                string query = $"select id_link,id_restaurant from public.links where id_restaurant={obcy}";
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
        private static int SelectCoord(int obcy)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                int val = 100;
                string query = $"select id_coordinates,id_restaurant from public.coordinates where id_restaurant={obcy}";
                con.Open();
                // Define a query returning a single row result set
                NpgsqlCommand command = new NpgsqlCommand(query, con);
                if (command.ExecuteScalar() != null)
                {
                    // Execute the query and obtain the value of the first column of the first row
                    Int32 count = (Int32)command.ExecuteScalar();
                    val = count;
                }
                con.Close();
                return val;
            }
        }
        private static int SelectSchedule(int obcy)
        {
            using (NpgsqlConnection con = GetConnection())//nawi¹zanie po³¹czenia z baz¹
            {
                int val = 100;
                string query = $"select id_schedule,id_restaurant from public.schedule where id_restaurant={obcy}";
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
>>>>>>> Stashed changes
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
