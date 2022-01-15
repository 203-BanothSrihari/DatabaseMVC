using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseMVC.Models;

namespace DatabaseMVC.Data
{
    public class DatabaseMVCContext : DbContext
    {
        public DatabaseMVCContext (DbContextOptions<DatabaseMVCContext> options)
            : base(options)
        {
        }

        public DbSet<DatabaseMVC.Models.Department> Department { get; set; }
    }
}
