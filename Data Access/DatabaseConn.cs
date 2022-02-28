using CrudR.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudR.Data_Access
{
    public class DatabaseConn : DbContext
    {
        public DatabaseConn(DbContextOptions<DatabaseConn> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
