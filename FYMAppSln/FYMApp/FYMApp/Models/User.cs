using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FYMApp.Models
{
    class User
    {
        
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public int Cellnumber { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
