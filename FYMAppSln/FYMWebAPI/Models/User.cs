using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYMWebAPI.Models
{
    public class User
    {
        public int ID { get; set; }

        public int Cellnumber { get; set; }

        public string Password { get; set; }
    }
}
