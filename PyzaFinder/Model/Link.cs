using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class Link
    {
        public int IdLink { get; set; }
        public int? IdRestaurant { get; set; }
        public string PageLink { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
