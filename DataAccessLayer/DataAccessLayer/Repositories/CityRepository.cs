using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
