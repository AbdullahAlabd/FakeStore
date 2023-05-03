using FakeStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options)
        {   
        }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Global Filters For Soft Deletion
            modelBuilder.Entity<Cart>().HasQueryFilter(q => !q.IsDeleted);
            modelBuilder.Entity<Item>().HasQueryFilter(q => !q.IsDeleted);
            modelBuilder.Entity<Product>().HasQueryFilter(q => !q.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(q => !q.IsDeleted);
            #endregion

        }
    }
}
