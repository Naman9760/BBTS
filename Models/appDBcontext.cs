using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BBTS.Models
{
    public class appDBcontext:DbContext
    {
        public appDBcontext() :
            base("Data Source=CHETUIWK1144\\SQLSERVER;Initial Catalog=cont;Integrated Security=True;Pooling=False") { }

        public DbSet<employee> employees { get; set; }
    }
}