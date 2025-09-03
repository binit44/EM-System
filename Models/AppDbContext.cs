using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsCRUD.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees => Set<Employee>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // LocalDB connection string (works out of the box with VS)
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-1CM89F6;Database=WinFormsCRUDDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
