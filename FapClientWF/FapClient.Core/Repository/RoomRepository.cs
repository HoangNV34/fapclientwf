using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class RoomRepository : CoreRepository<Room>, IRoomRepository
    {
        public List<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }
    }
}
