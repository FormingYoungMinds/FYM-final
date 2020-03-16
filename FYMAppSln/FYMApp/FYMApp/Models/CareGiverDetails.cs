using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FYMApp.Models
{
    class CareGiverDetails
    {
        [PrimaryKey, AutoIncrement]

        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [MaxLength(10)]
        public int Cellnumber { get; set; }

    }
}
