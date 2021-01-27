using Microsoft.EntityFrameworkCore;

namespace OpenID.API.Models
{
    public class OpenIDContext : DbContext
    {
        public OpenIDContext(DbContextOptions<OpenIDContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    } 
}
