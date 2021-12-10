using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class CampusServices : BaseServices<Campus>, ICampusServices
    {
        public CampusServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
