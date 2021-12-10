using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class CourseScheduleServices : BaseServices<CourseSchedule>, ICourseScheduleServices
    {
        public CourseScheduleServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
