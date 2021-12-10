using FapClient.Core.Infrastructure;
using FapClient.Core.Models;
using FapClient.Service.BaseServices;

namespace FapClient.Service
{
    public class StudentCourseServices : BaseServices<StudentCourse>, IStudentCourseServices
    {
        public StudentCourseServices(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
