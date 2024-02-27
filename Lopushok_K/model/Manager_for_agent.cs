namespace Lopushok_K.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manager_for_agent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Connection_id { get; set; }

        public int Agent_id { get; set; }

        public int Manager_id { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual Manager Manager { get; set; }
    }
}
