using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class UserClinic
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ClinicId { get; set; }
        [Required]
        [StringLength(50)]
        public string CretedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("ClinicId")]
        [InverseProperty("UserClinic")]
        public Clinic Clinic { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("UserClinic")]
        public User User { get; set; }
    }
}
