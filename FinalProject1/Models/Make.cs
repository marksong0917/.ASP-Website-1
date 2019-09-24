namespace FinalProject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Make")]
    public partial class Make
    {
        public int MakeID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
