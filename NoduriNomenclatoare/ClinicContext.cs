using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoduriNomenclatoare
{
    public class ClinicContext : DbContext
    {
        public DbSet<NomCountries> Countries { get; set; }
        public DbSet<NomCities> Cities { get; set; }

        public DbSet<NomActiveSubstances> ActiveSubstances { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NomCountries>()
                .Property(nomCountry => nomCountry.Name)
                .HasColumnName("CountryName");
        }
    }
}
