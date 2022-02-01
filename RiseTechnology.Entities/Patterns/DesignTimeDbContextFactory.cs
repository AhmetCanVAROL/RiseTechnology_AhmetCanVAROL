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
            var connectionString = "Server=.;Database=RiseTechnologyDB;Trusted_Connection=True;";
            builder.UseSqlServer(connectionString);
            return new RiseTechContext(builder.Options);
        }
    }
}
