using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public partial class Schedule
    {
        public int IdSchedule { get; set; }
        public int? IdRestaurant { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

        public virtual DumplingRestaurant IdRestaurantNavigation { get; set; }
    }
}
