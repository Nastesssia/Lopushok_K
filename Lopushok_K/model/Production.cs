namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Production")]
    public partial class Production
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Production_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Product_name { get; set; }

        public int Workshop_id { get; set; }

        [Required]
        [StringLength(50)]
        public string Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Time { get; set; }

        [Required]
        [StringLength(50)]
        public string Need_emp { get; set; }

        [Required]
        [StringLength(100)]
        public string Material_name { get; set; }

        public virtual Materials Materials { get; set; }

        public virtual Product Product { get; set; }

        public virtual Workshop Workshop { get; set; }
    }
}
