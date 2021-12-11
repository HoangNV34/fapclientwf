using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface ISubjectRepository : ICoreRepository<Subject>
    {
        List<Subject> GetByStudentAndTerm(int studentId, int termId);
    }
}
