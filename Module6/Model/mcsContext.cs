using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module6.Model
{
    public class mcsContext : DbContext
    {
        public mcsContext() : base("name=MCS")
        {
            
        }

       public virtual DbSet<TablesStopReason> TablesStopReasons { get; set; } //навигационное свойство
    }
}
