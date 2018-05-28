using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Entities
{
    public partial class Event
    {
        public Guid Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public DateTimeOffset? From { get; set; }
        public DateTimeOffset? To { get; set; }
        public bool IsAllDay { get; set; }
        public string Note { get; set; }
        public Guid TretmentId { get; set; }
        public Guid PatientId { get; set; }
        public Guid BranchId { get; set; }
        public Guid RoomId { get; set; }
        public Guid UserId { get; set; }
        public Guid? TypeId { get; set; }
        public Guid? StatusId { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }

        [ForeignKey("BranchId")]
        [InverseProperty("Event")]
        public Branch Branch { get; set; }
        [ForeignKey("PatientId")]
        [InverseProperty("Event")]
        public Patient Patient { get; set; }
        [ForeignKey("RoomId")]
        [InverseProperty("Event")]
        public Room Room { get; set; }
        [ForeignKey("StatusId")]
        [InverseProperty("EventStatus")]
        public LookUp Status { get; set; }
        [ForeignKey("TretmentId")]
        [InverseProperty("Event")]
        public Treatment Tretment { get; set; }
        [ForeignKey("TypeId")]
        [InverseProperty("EventType")]
        public LookUp Type { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Event")]
        public User User { get; set; }
    }
}
