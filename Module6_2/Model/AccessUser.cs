namespace Module6_2.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccessUser")]
    public partial class AccessUser
    {
        [Key]
        public int AccessID { get; set; }

        public int? UserId { get; set; }

        public DateTime? Create { get; set; }

        public int? TabId { get; set; }

        public AccessTab AccessTab { get; set; }
    }
}
