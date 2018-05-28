using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        public EventRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

