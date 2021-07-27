using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInformation.Model.Data
{
    class ApplicationContext : DbContext
    {
        public DbSet<Country> DbCountry { get; set; }
        public DbSet<City> DbCity { get; set; }
        public DbSet<Region> DbRegion { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8R8RE45\SQLEXPRESS;Initial Catalog=CountryInformationdb;Integrated Security=True;");
        }
    }
}
