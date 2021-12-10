using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class RollCallBookServices : BaseServices<RollCallBook>, IRollCallBookServices
    {
        public RollCallBookServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
