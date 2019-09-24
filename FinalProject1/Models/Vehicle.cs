namespace FinalProject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        public int VehicleID { get; set; }

        public int? MakeID { get; set; }

        public int? ModelID { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        [StringLength(50)]
        public string Price { get; set; }

        [StringLength(50)]
        public string Cost { get; set; }

        [StringLength(50)]
        public string SoldDate { get; set; }
    }
}
