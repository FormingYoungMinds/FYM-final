using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYMWebAPI.Models
{
    public class FYMAppContext : DbContext
    {
        public FYMAppContext(DbContextOptions<FYMAppContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<CareGiverDetails> CareGiversDetails { get; set; }
    }
}
