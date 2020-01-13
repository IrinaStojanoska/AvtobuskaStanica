using AvtobuskaStanica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvtobuskaStanica.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Relation> Relations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AddUserToRole> AddRole { get; set; }
    }
}