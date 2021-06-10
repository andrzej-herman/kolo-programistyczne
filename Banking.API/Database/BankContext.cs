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

        public List<string> Errors { get; set; }

        public DbSet<MainPageInfo> MainPageData { get; set; }
        public DbSet<User> Users { get; set; }

        public void ClearErrors()
        {
            Errors = new List<string>();
        }

        public void AddError(string error)
        {
            Errors.Add(error);
        }


    }
}
