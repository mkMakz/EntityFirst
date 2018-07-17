namespace Module6_2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessTab")]
    public partial class AccessTab
    {
        [Key]
        public int TabId { get; set; }

        [StringLength(255)]
        public string TabName { get; set; }

        public int? GroupId { get; set; }

        public ICollection<AccessUser> AccessUsers { get; set; }
    }
}
