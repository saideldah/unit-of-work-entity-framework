using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using System;
using System.Linq;

namespace DataAccessLayer
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            var system = "System";
            var createdDate = DateTime.Now;

            context.Database.EnsureCreated();
            #region Treatments
            //Treatments
            //check if it was seeded
            //if (!context.Treatments.Any())
            //{
            //    var treatments = new Treatment[]
            //    {
            //        new Treatment(){ Id = Guid.NewGuid(), Title = "Braces", Description = "Braces", CreatedBy = system, CreatedDate = createdDate},
            //        new Treatment(){ Id = Guid.NewGuid(), Title = "Bridges and Implants", Description = "Bridges and Implants", CreatedBy = system, CreatedDate = createdDate},
            //        new Treatment(){ Id = Guid.NewGuid(), Title = "Gum Surgery", Description = "Gum Surgery", CreatedBy = system, CreatedDate = createdDate}
            //    };

            //    context.Treatments.AddRange(treatments);
            //    context.SaveChanges();
            //}
            #endregion

            #region Specialties

            //Specialties
            //check if it was seeded
            if (!context.User.Any())
            {
                var specialties = new LookUp[]
                {
                    new LookUp(){ Id = Guid.NewGuid(), Name = "Braces Specialty", CreatedBy = system, CreatedDate = createdDate,  Code = "SP1"},
                    new LookUp(){ Id = Guid.NewGuid(), Name = "Bridges and Implants Specialty", CreatedBy = system, CreatedDate = createdDate,  Code = "SP2"},
                    new LookUp(){ Id = Guid.NewGuid(), Name = "Gum Surgery Specialty", CreatedBy = system, CreatedDate = createdDate ,  Code = "SP3"}
                };
                context.LookUp.AddRange(specialties);
                context.SaveChanges();
            }


            #endregion

            #region Branches

            //Branches & Rooms
            //check if it was seeded
            //if (!context.Branches.Any() && !context.Rooms.Any())
            //{
            //    var branches = new Branch[]
            //    {
            //        new Branch(){ Id = Guid.NewGuid(), Title = "Zalka", Description = "Zalka", CreatedBy = system, CreatedDate = createdDate,  Code = "B1"},
            //        new Branch(){ Id = Guid.NewGuid(), Title = "Mansorieh", Description = "Mansorieh", CreatedBy = system, CreatedDate = createdDate,  Code = "B2"},
            //        new Branch(){ Id = Guid.NewGuid(), Title = "Down Town", Description = "Down Town", CreatedBy = system, CreatedDate = createdDate ,  Code = "B3"}
            //    };

            //    foreach (var branch in branches)
            //    {
            //        context.Branches.Add(branch);
            //        context.Rooms.Add(new Room() { Id = Guid.NewGuid(), BranchId = branch.Id, Title = "Room A", Description = "Room A", CreatedBy = system, CreatedDate = createdDate });
            //        context.Rooms.Add(new Room() { Id = Guid.NewGuid(), BranchId = branch.Id, Title = "Room B", Description = "Room B", CreatedBy = system, CreatedDate = createdDate });
            //        context.Rooms.Add(new Room() { Id = Guid.NewGuid(), BranchId = branch.Id, Title = "Room C", Description = "Room C", CreatedBy = system, CreatedDate = createdDate });

            //    }
            //    context.SaveChanges();
            //}


            #endregion

            #region Branches

            //Status Type & Status
            //check if it was seeded
            //if (!context.StatusTypes.Any() && !context.Statuses.Any())
            //{
            //    var statusType = new StatusType() { Id = DataConstants.STATUS_TYPE_APPOINTMENT, Title = "Appointment Status", Description = "Appointment Status", CreatedBy = system, CreatedDate = createdDate };
            //    context.StatusTypes.Add(statusType);

            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_RECALL, Title = "Recall", Description = "Recall", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--info" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_SCHEDULED, Title = "Scheduled", Description = "Scheduled", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--accent" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_CANCELED, Title = "Canceled", Description = "Canceled", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--danger" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_ABSENT, Title = "Absent", Description = "Absent", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--metal" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_ARRIVED, Title = "Arrived", Description = "Arrived", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--focus" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_CHECKIN, Title = "CheckIn", Description = "CheckIn", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--warning" });
            //    context.Statuses.Add(new Status() { Id = DataConstants.STATUS_COMPLETED, Title = "Completed", Description = "Completed", CreatedBy = system, CreatedDate = createdDate, StatusTypeId = statusType.Id, VisualColor = "m-fc-event--success" });

            //    context.SaveChanges();
            //}


            //if (!context.Users.Any())
            //{
            //    //Create Administrator User
            //    var adminResult = userManager.CreateAsync(new ApplicationUser()
            //    {
            //        Email = "admin@coms.com",
            //        FirstName = "Admin",
            //        LastName = "Admin",
            //        UserName = "admin@coms.com"
            //    }, "p@ssw0rd").Result;

            //    //Create Specialists
            //    var drResult1 = userManager.CreateAsync(new ApplicationUser()
            //    {
            //        Email = "w.kfoury@coms.com",
            //        FirstName = "Dr Antoine",
            //        LastName = "Kfoury",
            //        UserName = "a.kfoury@coms.com"
            //    }, "p@ssw0rd").Result;
            //    var drResult2 = userManager.CreateAsync(new ApplicationUser()
            //    {
            //        Email = "w.jassar@coms.com",
            //        FirstName = "Dr. Nabil",
            //        LastName = "Jassar",
            //        UserName = "w.jassar@coms.com"
            //    }, "p@ssw0rd").Result;


            //    var doctor1 = userManager.FindByEmailAsync("w.kfoury@coms.com").Result;
            //    var doctorAsSpecialist1 = new Specialist()
            //    {
            //        Id = Guid.NewGuid(),
            //        Identity = doctor1,
            //        IdentityId = doctor1.Id,
            //        VisualColor = "m-fc-event--solid-info",
            //        Color= "#36a3f7",
            //        Specialties = new List<SpecialtySpecialist>()
            //    };
            //    var doctor2 = userManager.FindByEmailAsync("w.jassar@coms.com").Result;
            //    var doctorAsSpecialist2 = new Specialist()
            //    {
            //        Id = Guid.NewGuid(),
            //        Identity = doctor2,
            //        IdentityId = doctor2.Id,
            //        VisualColor = "m-fc-event--solid-primary",
            //        Color= "#5867dd",
            //        Specialties = new List<SpecialtySpecialist>()
            //    };

            //    var speciality = context.Specialties.FirstOrDefault(s => s.Title == "Braces Specialty");
            //    var doctorSpecialities1 = new SpecialtySpecialist() { SpecialistId = doctorAsSpecialist1.Id, SpecialtyId = speciality.Id };
            //    var doctorSpecialities2 = new SpecialtySpecialist() { SpecialistId = doctorAsSpecialist2.Id, SpecialtyId = speciality.Id };

            //    doctorAsSpecialist1.Specialties.Add(doctorSpecialities1);
            //    doctorAsSpecialist2.Specialties.Add(doctorSpecialities2);
            //    context.Specialists.Add(doctorAsSpecialist1);
            //    context.Specialists.Add(doctorAsSpecialist2);
            //    context.SpecialtySpecialists.Add(doctorSpecialities1);
            //    context.SpecialtySpecialists.Add(doctorSpecialities2);

            //    context.SaveChanges();

            //}


            #endregion
        }
    }
}
