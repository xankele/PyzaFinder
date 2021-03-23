using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class DumplingRestaurant
    {
        public DumplingRestaurant()
        {
            Coordinates = new HashSet<Coordinate>();
            Links = new HashSet<Link>();
            Opinions = new HashSet<Opinion>();
            Photos = new HashSet<Photo>();
            Schedules = new HashSet<Schedule>();
        }

        public int IdRestaurant { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Coordinate> Coordinates { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<Opinion> Opinions { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
