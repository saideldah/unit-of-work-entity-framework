using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class ClinicRepository : Repository<Clinic>, IClinicRepository
    {
        public ClinicRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
