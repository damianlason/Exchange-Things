using Microsoft.EntityFrameworkCore;
using Exchange_Things.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exchange_Things.Database
{
    public class ExchangeThingsContext : DbContext
    {
        public ExchangeThingsContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<ItemEntity> Items { get; set; }
    }
}