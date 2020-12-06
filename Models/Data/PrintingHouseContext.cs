using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PH.Models.Data
{
    public class PrintingHouseContext:IdentityDbContext<User>
    {
         public DbSet<User> Users { get; set; }
         public DbSet<Order> Orders { get; set; }
         public DbSet<OrderName> OrderNames { get; set; }
         public DbSet<Paper> Papers { get; set; }
         public DbSet<Client> Clients { get; set; }
         public DbSet<PartOfKit> PartOfKits { get; set; }

         public PrintingHouseContext(DbContextOptions options) : base(options)
         {
         }
    }
}