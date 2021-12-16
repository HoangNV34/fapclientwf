using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface IRoomRepository : ICoreRepository<Room>
    {
        List<Room> GetAll();
    }
}
