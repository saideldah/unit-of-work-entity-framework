using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Contact
    {
        public Contact()
        {
            Patient = new HashSet<Patient>();
        }

        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string MobileNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [InverseProperty("Contact")]
        public ICollection<Patient> Patient { get; set; }
    }
}
