using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWeb.Data
{
    public class FizzBuzzContext : DbContext
    {
        public FizzBuzzContext(DbContextOptions options) : base(options) { }

        public DbSet<FizzBuzz> FizzBuzz { get; set; }
        public object FizzBuzzes { get; internal set; }
    }
}
