using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccess.Model;

namespace UserAccess.Context
{
    class MyContext : DbContext
    {
        public MyContext() : base("DbConnectionString") { }

        public DbSet<User> Users { get; set; }

    }

}