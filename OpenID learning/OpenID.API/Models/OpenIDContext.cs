using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
