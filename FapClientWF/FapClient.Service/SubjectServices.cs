using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class SubjectServices : BaseServices<Subject>, ISubjectServices
    {
        public SubjectServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
