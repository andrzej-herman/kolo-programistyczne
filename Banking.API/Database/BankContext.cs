using Banking.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banking.API.Database
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions options) : base(options) { }
        protected BankContext() { }

        public DbSet<MainPageInfo> MainPageData { get; set; }

    }
}
