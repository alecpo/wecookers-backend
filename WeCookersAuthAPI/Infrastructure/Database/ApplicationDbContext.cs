using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeCookersAuthAPI.Domain.Entities;

namespace WeCookersAuthAPI.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasKey(user => user.Id);
        }
    }
}
