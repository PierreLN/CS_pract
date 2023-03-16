using Microsoft.EntityFrameworkCore;
using PhoneContactAPI.Models;

namespace PhoneContactAPI.Data
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options) { }
        public DbSet<Contact> Contact { get; set; }
        
    }
}
