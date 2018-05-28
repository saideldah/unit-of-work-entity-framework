using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Context
{
    public partial class AppDbContext : DbContext
    {
        #region DbSet
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Clinic> Clinic { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<LookUp> LookUp { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Treatment> Treatment { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserClinic> UserClinic { get; set; }
        #endregion

        #region Ctors
        public AppDbContext(DbContextOptions options)
          : base(options)
        {
        }
        #endregion

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=SmartClinic360;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Address");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Branch_Address");

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.ClinicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_Clinic");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Branch");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Patient");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Room");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.EventStatus)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Event_LookUp");

                entity.HasOne(d => d.Tretment)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.TretmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Treatment");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.EventType)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Event_LookUp1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_User");
            });

            modelBuilder.Entity<LookUp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Patient_Address");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Patient_Contact");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Room_Branch");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserClinic>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Clinic)
                    .WithMany(p => p.UserClinic)
                    .HasForeignKey(d => d.ClinicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClinic_Clinic");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClinic)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserClinic_User");
            });
        }
    }
}
