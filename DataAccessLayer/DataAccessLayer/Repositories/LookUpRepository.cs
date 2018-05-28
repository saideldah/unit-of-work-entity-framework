using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class LookUpRepository : Repository<LookUp>, ILookUpRepository
    {
        public LookUpRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
