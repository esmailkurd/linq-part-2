using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace sabtenam
{
    public class db : DbContext
    {
        public db() : base("name=constr") { }
       public DbSet<human> jadval { set; get; }

    }
}
 