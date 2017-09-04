using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data
{
    public interface IMyContext
    {
        DbSet<SomeEntity> MyEntities { get; set; }
    }

    public class MyContext : DbContext, IMyContext
    {
        public MyContext():base("MyContext")
        {

        }
        public virtual DbSet<SomeEntity> MyEntities { get; set; }
    }
}
