using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class Coordinate
    {
        public int IdCoordinates { get; set; }
        public int? IdRestaurant { get; set; }
        public string CoordinateX { get; set; }
        public string CoordinateY { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
