namespace FinalProject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleTypeID")]
    public partial class VehicleTypeID
    {
        [Key]
        [Column("VehicleTypeID")]
        public int VehicleTypeID1 { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
