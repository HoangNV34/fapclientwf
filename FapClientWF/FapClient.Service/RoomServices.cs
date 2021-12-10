using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class RoomServices : BaseServices<Room>, IRoomServices
    {
        public RoomServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
