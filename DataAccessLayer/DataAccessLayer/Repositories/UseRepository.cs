using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class UseRepository : Repository<User>, IUserRepository
    {
        public UseRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
