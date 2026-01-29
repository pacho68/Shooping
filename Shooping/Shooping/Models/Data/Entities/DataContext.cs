using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Shooping.Models.Data.Entities
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        //public DataContext(DbContextOptions<DataContext> options)
        //    : base(options)
        //{



        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //crea un indice unico sobre el campo name
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }


    }
}
