using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
