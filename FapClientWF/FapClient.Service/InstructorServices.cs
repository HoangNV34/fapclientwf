using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class InstructorServices : BaseServices<Instructor>, IInstructorServices
    {
        public InstructorServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
