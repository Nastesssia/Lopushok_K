namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Suppliers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Supplier_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Supplier_name { get; set; }

        [Required]
        [StringLength(12)]
        public string INN { get; set; }

        [Required]
        [StringLength(50)]
        public string Supplier_type { get; set; }

        [Required]
        [StringLength(100)]
        public string Delivery_history { get; set; }
    }
}
