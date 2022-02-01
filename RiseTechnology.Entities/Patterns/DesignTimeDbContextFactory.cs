using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RiseTechnology.Entities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiseTechnology.Entities.Patterns
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RiseTechContext>
    {
        public RiseTechContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RiseTechContext>();
            var connectionString = "Host=localhost;Port=5432; User Id=postgres;Password=agartha2020;Database=RiseTechnologyDB;";
            builder.UseNpgsql(connectionString);
            return new RiseTechContext(builder.Options);
        }
    }
}
