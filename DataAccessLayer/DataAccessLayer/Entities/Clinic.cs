using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Clinic
    {
        public Clinic()
        {
            Branch = new HashSet<Branch>();
            UserClinic = new HashSet<UserClinic>();
        }

        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public Guid Type { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [InverseProperty("Clinic")]
        public ICollection<Branch> Branch { get; set; }
        [InverseProperty("Clinic")]
        public ICollection<UserClinic> UserClinic { get; set; }
    }
}
