namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Production = new HashSet<Production>();
        }

        [Key]
        [StringLength(50)]
        public string Product_name { get; set; }

        [Required]
        [StringLength(50)]
        public string Article { get; set; }

        [Required]
        [StringLength(50)]
        public string Min_agent_cost { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }

        [Required]
        [StringLength(50)]
        public string Type_product { get; set; }

        [Required]
        [StringLength(50)]
        public string Equal { get; set; }

        [Required]
        [StringLength(50)]
        public string Standart_num { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Production> Production { get; set; }
    }
}
