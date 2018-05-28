using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class LookUp
    {
        public LookUp()
        {
            EventStatus = new HashSet<Event>();
            EventType = new HashSet<Event>();
        }

        public Guid Id { get; set; }
        [StringLength(50)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [InverseProperty("Status")]
        public ICollection<Event> EventStatus { get; set; }
        [InverseProperty("Type")]
        public ICollection<Event> EventType { get; set; }
    }
}
