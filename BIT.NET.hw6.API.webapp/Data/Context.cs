using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIT.NET.hw6.API.webapp.Data
{
    public class Context:DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Kitchenware> Kitchenwares { get; set; }

        public Context(DbContextOptions<Context> options)
        : base(options)
        {
        }
    }
}
