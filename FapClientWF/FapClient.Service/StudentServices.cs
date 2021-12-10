using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class StudentServices : BaseServices<Student>, IStudentServices
    {
        public StudentServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
