using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class TermServices : BaseServices<Term>, ITermServices
    {
        public TermServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
