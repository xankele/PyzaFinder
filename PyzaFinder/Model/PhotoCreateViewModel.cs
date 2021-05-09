using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PyzaFinder.Model
{
    public class PhotoCreateViewModel
    {
        public int? IdRestaurant { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
