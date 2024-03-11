using acadamy_2024.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace acadamy_2024.Controllers.Data
{
   
    public class Applicationdbcontext : DbContext
    {
        private readonly string _dbPath;
        

        public Applicationdbcontext()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            _dbPath = Path.Combine(path, "academy.db");
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
           => optionsBuilder.UseSqlite($"Data Source= {_dbPath}");
        
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
