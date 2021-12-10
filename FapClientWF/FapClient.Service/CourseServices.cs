using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class CourseServices : BaseServices<Course>, ICourseServices
    {
        public CourseServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
