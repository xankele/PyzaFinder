using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class Photo
    {
        public int IdPhoto { get; set; }
        public int? IdRestaurant { get; set; }
        public string Path { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
