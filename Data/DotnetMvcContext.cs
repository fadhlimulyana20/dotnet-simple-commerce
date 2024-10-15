using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dotnet_mvc.Models;
using Microsoft.AspNetCore.Identity;

namespace dotnet_mvc.Data
{
    public class DotnetMvcContext : IdentityDbContext<IdentityUser>
    {
        public DotnetMvcContext(DbContextOptions<DotnetMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is Product &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                ((Product)entry.Entity).UpdatedAt = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    ((Product)entry.Entity).CreatedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}