namespace FinalProject1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Model")]
    public partial class Model
    {
        public int ModelID { get; set; }

        [StringLength(50)]
        public string EngineSize { get; set; }

        [StringLength(50)]
        public string NumDoor { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string VehicleType { get; set; }
    }
}
