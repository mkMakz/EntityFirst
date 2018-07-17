namespace Module6_2.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class mcs : DbContext
    {
        public mcs()
            : base("name=mcs")
        {
        }

        public virtual DbSet<AccessTab> AccessTab { get; set; }
        public virtual DbSet<AccessUser> AccessUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
