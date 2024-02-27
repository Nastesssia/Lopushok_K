namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Release_history
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int History_id { get; set; }

        public int Shop_id { get; set; }

        public int Agent_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Cost { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
