using Microsoft.EntityFrameworkCore;
using universityApiBackEnd.Models.DataModels;

namespace universityApiBackEnd.DataAcces
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options) { 
        
        }

        //TODO: add dbSet (Tables of our Data base)
        public DbSet<User>? Users { get; set; }
    }
}
