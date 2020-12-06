using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PH.Models.Data
{
    public class PrintingHouseContext:IdentityDbContext<User>
    {
         public DbSet<User> Users { get; set; }

         public PrintingHouseContext(DbContextOptions options) : base(options)
         {
         }
    }
}