namespace InnovasysVatCheck.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class Vat
    {
        [Required]
        public int Id { get; set; }

        [Column("VatNumber")]
        [StringLength(50)]
        public string VatNumber { get; set; }
    }
}
