namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Employee_id { get; set; }

        [Required]
        [StringLength(100)]
        public string Employee_name { get; set; }

        public int Workshop_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_of_birth { get; set; }

        [Required]
        [StringLength(50)]
        public string Passport { get; set; }

        [Required]
        [StringLength(50)]
        public string Bank_details { get; set; }

        [Required]
        [StringLength(10)]
        public string Marital_status { get; set; }

        [Required]
        [StringLength(50)]
        public string Health { get; set; }

        [Required]
        [StringLength(11)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
