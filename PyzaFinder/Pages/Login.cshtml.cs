using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyzaFinder.Pages
{
    public class LoginModel : PageModel
    {
        private readonly DumplingContext _db;
        [BindProperty]
        public Account Account { get; set; }
        public LoginModel(DumplingContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Account = _db.Accounts.First();
        }
    }


    


}
