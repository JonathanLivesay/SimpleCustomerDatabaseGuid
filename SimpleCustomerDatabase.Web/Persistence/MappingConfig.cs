using Highway.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCustomerDatabase.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleCustomerDatabase.Web.Persistence
{
    public class MappingConfig : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
            //.HasMany(e => e.Genres).WithRequired(e => e.Movie);
            //modelBuilder.Entity<Movie>().Property(e => e.Name).HasColumnName("MovieName");

            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Customer>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.Email).IsRequired();
            modelBuilder.Entity<Customer>().Property(c => c.DateCreated).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Customer>().Property(c => c.DateUpdated).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }

    }
}
    