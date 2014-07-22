using Highway.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCustomerDatabase.Domain
{
    class MappingConfig : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();
                //.HasMany(e => e.Genres).WithRequired(e => e.Movie);
            //modelBuilder.Entity<Movie>().Property(e => e.Name).HasColumnName("MovieName");
        }

    }
}
    