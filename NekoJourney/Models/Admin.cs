using System;
using System.Collections.Generic;

namespace NekoJourney.Models
{
    public partial class Admin
    {
        public int IdAdmin { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NoHp { get; set; }
    }
}
