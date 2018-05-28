using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Branch
    {
        public Branch()
        {
            Event = new HashSet<Event>();
            Room = new HashSet<Room>();
        }

        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? AddressId { get; set; }
        public Guid ClinicId { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Branch")]
        public Address Address { get; set; }
        [ForeignKey("ClinicId")]
        [InverseProperty("Branch")]
        public Clinic Clinic { get; set; }
        [InverseProperty("Branch")]
        public ICollection<Event> Event { get; set; }
        [InverseProperty("Branch")]
        public ICollection<Room> Room { get; set; }
    }
}
