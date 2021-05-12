using System;
using System.Collections.Generic;

#nullable disable

namespace PyzaFinder
{
    public enum Account_type
    {
        Admin,
        User
    }
    public partial class Account

    {
        public Account_type Acctype { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
