using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Treatment
    {
        public Treatment()
        {
            Event = new HashSet<Event>();
        }

        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [InverseProperty("Tretment")]
        public ICollection<Event> Event { get; set; }
    }
}
