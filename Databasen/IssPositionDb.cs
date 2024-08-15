using IssPosition.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssPosition.Databasen
{
    public class IssPositionDbContext : DbContext
    {
        private readonly string _connectionString;

        public IssPositionDbContext()
        {
            // Connection string for Azure SQL Server
            string connectionString = "Data Source=tcp:isspositionserver.database.windows.net,1433;Initial Catalog=isspositionsdb;Persist Security Info=False;User ID=issclo23admin;Password=clo23.24;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=60";
            _connectionString = connectionString;
        }

        public DbSet<CurrentPositionData> CurrentPositions { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(_connectionString);
         
        }
    }
}
