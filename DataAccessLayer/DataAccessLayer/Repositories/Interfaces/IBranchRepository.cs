using DataAccessLayer.Entities;
using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IBranchRepository : IRepository<Branch>
    {
        IEnumerable<Branch> GetBranchesInCity(int cityId);
    }
}
