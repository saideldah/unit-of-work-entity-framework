using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        public int CountryId { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("CountryId")]
        [InverseProperty("City")]
        public Country Country { get; set; }
        [InverseProperty("City")]
        public ICollection<Address> Address { get; set; }
    }
}
