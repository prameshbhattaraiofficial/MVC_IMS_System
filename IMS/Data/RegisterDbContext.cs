using IMS.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace IMS.Data
{
    public class RegisterDbContext: DbContext
    {

        public RegisterDbContext(DbContextOptions options) : base(options) { 
        
        
        }

        public DbSet<Register> Register { get; set; }
    }
}
