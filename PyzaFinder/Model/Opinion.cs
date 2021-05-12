using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class Opinion
    {
        public int IdOpinion { get; set; }
        public int? IdRestaurant { get; set; }
        public string Comment { get; set; }
        public DateTime? Datetime { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
