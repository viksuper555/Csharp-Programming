using Microsoft.EntityFrameworkCore;
using Data.Entity;
namespace Data
{
    public class MyLibraryDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L36JLVE;Database=MyLibrary;Trusted_Connection=True;MultipleActiveResultSets=true;User Id=;pwd=;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
