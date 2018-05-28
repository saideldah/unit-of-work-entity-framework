using DataAccessLayer.Repositories;
using DataAccessLayer.Context;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Fields
        private readonly AppDbContext _smartClinic360DbContext;

        #endregion

        #region Constructor

        public UnitOfWork(IPatientRepository patients,
            IBranchRepository branches,
            IEventRepository events,
            ILookUpRepository lookUps,
            IUserRepository users,
            ITreatmentRepository treatments,
            IAddressRepository addresses,
            IContactRepository contacts,
            ICountryRepository countries,
            ICityRepository cities,
            IClinicRepository clinics,
            IRoomRepository rooms,
            AppDbContext smartClinic360DbContext)
        {
            Patients = patients;
            Branches = branches;
            Events = events;
            LookUps = lookUps;
            Users = users;
            Treatments = treatments;
            Addresses = addresses;
            Contacts = contacts;
            Countries = countries;
            Cities = cities;
            Clinics = clinics;
            Rooms = rooms;
        }
        #endregion

        #region Properties
        public IPatientRepository Patients { get; }
        public IBranchRepository Branches { get; }
        public IEventRepository Events { get; }
        public ILookUpRepository LookUps { get; }
        public IUserRepository Users { get; }
        public ITreatmentRepository Treatments { get; }
        public IAddressRepository Addresses { get; }
        public IContactRepository Contacts { get; }
        public ICountryRepository Countries { get; }
        public ICityRepository Cities { get; }
        public IClinicRepository Clinics { get; }
        public IRoomRepository Rooms { get; }
        #endregion

        #region Methods
        public int Commit()
        {
            return _smartClinic360DbContext.SaveChanges();
        }
        public async Task<int> CommitAsync()
        {
            return await _smartClinic360DbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _smartClinic360DbContext.Dispose();
        }
        #endregion
    }
}
