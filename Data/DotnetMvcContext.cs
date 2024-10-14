using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dotnet_mvc.Models;

namespace dotnet_mvc.Data
{
    public class DotnetMvcContext : DbContext
    {
        public DotnetMvcContext (DbContextOptions<DotnetMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}