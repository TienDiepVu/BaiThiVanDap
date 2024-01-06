using Microsoft.EntityFrameworkCore;
using VuTienDiep_192.Models;
namespace VuTienDiep_192.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person_1 { get; set; } 
        public DbSet<VuTienDiep_192.Models.PhoneNumber> PhoneNumber { get; set; } = default!;
    }
}
