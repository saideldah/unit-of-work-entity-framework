using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Room
    {
        public Room()
        {
            Event = new HashSet<Event>();
        }

        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Guid BranchId { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("Room")]
        public Branch Branch { get; set; }
        [InverseProperty("Room")]
        public ICollection<Event> Event { get; set; }
    }
}
