namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Quality_control
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Control_id { get; set; }

        public int Supplier_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Material_name { get; set; }

        [Required]
        [StringLength(50)]
        public string Quality_info { get; set; }

        public virtual Materials Materials { get; set; }
    }
}
