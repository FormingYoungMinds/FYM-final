using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FYMs.Models
{
    class User
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string FirstNames { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
