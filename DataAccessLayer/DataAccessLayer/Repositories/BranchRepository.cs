using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        public BranchRepository(DbContext dbContext) : base(dbContext)
        {
        }
        public IEnumerable<Branch> GetBranchesInCity(int cityId)
        {
            return _dataBase.Where(a => a.Address.CityId == cityId);
        }
    }
}
