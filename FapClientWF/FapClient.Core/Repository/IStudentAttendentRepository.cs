using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface IStudentAttendentRepository : ICoreRepository<StudentAttendent>
    {
        List<StudentAttendent> GetStudent(int sId, int subjectId, int termId);

        StudentAttendent GetDetails(int rollCallBookId, int teachingScheduleId);
    }
}
