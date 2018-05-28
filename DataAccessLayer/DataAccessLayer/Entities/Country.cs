using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Country
    {
        public Country()
        {
            Address = new HashSet<Address>();
            City = new HashSet<City>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string IsoCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string NationalityName { get; set; }
        [Required]
        [StringLength(50)]
        public string PhoneCode { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [InverseProperty("Country")]
        public ICollection<Address> Address { get; set; }
        [InverseProperty("Country")]
        public ICollection<City> City { get; set; }
    }
}
