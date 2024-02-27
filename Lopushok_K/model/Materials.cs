namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Materials
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materials()
        {
            Production = new HashSet<Production>();
            Quality_control = new HashSet<Quality_control>();
        }

        [Key]
        [StringLength(100)]
        public string Material_name { get; set; }

        [Required]
        public string Material_type { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity_package { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Required]
        [StringLength(50)]
        public string Quantity_stock { get; set; }

        [Required]
        [StringLength(50)]
        public string Min_quantity_stock { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Production> Production { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quality_control> Quality_control { get; set; }
    }
}
