using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerceProject.Models;

namespace ECommerceProject.Data
{
    public class ECommerceProjectContext : DbContext
    {
        public ECommerceProjectContext (DbContextOptions<ECommerceProjectContext> options)
            : base(options)
        {
        }

        public DbSet<ECommerceProject.Models.Order>? Order { get; set; }

        public DbSet<ECommerceProject.Models.OrderDetail>? OrderDetail { get; set; }

        public DbSet<ECommerceProject.Models.Product>? Product { get; set; }

        public DbSet<ECommerceProject.Models.Review>? Review { get; set; }

        public DbSet<ECommerceProject.Models.Role>? Role { get; set; }
        public DbSet<ECommerceProject.Models.User>? User { get; set; }


    }
}
