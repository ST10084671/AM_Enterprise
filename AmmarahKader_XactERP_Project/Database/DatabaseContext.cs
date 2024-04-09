using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmarahKader_XactERP_Project.Database
{
    class DatabaseContext : DbContext
    {
        public DbSet<Debtor> Debtors { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
