using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PyzaFinder.Pages
{
    public class AddPhotoModel : PageModel
    {
        [BindProperty]
        public Photo Photo { get; set; }
        

        public void OnGet()
        {
        }
    }
}
