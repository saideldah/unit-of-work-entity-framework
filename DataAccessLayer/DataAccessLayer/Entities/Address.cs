using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Address
    {
        public Address()
        {
            Branch = new HashSet<Branch>();
            Patient = new HashSet<Patient>();
        }

        public Guid Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        [StringLength(50)]
        public string Area { get; set; }
        public string Street { get; set; }
        [StringLength(50)]
        public string ZipCode { get; set; }
        public string Note { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("CityId")]
        [InverseProperty("Address")]
        public City City { get; set; }
        [ForeignKey("CountryId")]
        [InverseProperty("Address")]
        public Country Country { get; set; }
        [InverseProperty("Address")]
        public ICollection<Branch> Branch { get; set; }
        [InverseProperty("Address")]
        public ICollection<Patient> Patient { get; set; }
    }
}
