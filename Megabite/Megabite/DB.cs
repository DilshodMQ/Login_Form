using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Megabite
{
    public class DB:DbContext
    {
        //SqlConnection connection = new SqlConnection(@"Server=(localdb)\\mssqllocaldb;Database=megabite;Trusted_Connection=True;");
        public DbSet<User> Users => Set<User>();
        public DB()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=megabite;Trusted_Connection=True;");
        }
    }
}
