using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Patient
    {
        public Patient()
        {
            Event = new HashSet<Event>();
        }

        public Guid Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public Guid? ContactId { get; set; }
        public Guid? AddressId { get; set; }
        [Required]
        [Column(TypeName = "nchar(10)")]
        public string Note { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("AddressId")]
        [InverseProperty("Patient")]
        public Address Address { get; set; }
        [ForeignKey("ContactId")]
        [InverseProperty("Patient")]
        public Contact Contact { get; set; }
        [InverseProperty("Patient")]
        public ICollection<Event> Event { get; set; }
    }
}
