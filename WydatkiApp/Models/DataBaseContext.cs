using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WydatkiApp.Models
{
    /// <summary>
    /// Połączenie do bazy danych
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<WydatkiModel> Wydatki { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=wydatki;user=root;password=");
        }
    }
}
