using System;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
namespace DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IPatientRepository Patients { get; }
        IBranchRepository Branches { get; }
        IEventRepository Events { get; }
        ILookUpRepository LookUps { get; }
        IUserRepository Users { get; }
        ITreatmentRepository Treatments { get; }
        IAddressRepository Addresses { get; }
        IContactRepository Contacts { get; }
        ICountryRepository Countries { get; }
        ICityRepository Cities { get; }
        IClinicRepository Clinics { get; }
        IRoomRepository Rooms { get; }

        int Commit();
        Task<int> CommitAsync();
    }
}
