using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class TreatmentRepository : Repository<Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
