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


        // przepis dla mappera
        // jakie obiekty (klasy) chcemy zmapować do bazy danych





    }
}
