using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentalContext :DbContext
    {
        //hangi veritabanıyla ilişkili olduğunu gösteriyoruz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=CarRentalDb;Trusted_Connection=true");
        }

        //Hngi classımızın hangi tabloya karşılık geldiğini göstermek için kullanırız.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
   
}
