using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public class SubjectRepository : CoreRepository<Subject>, ISubjectRepository
    {
        public List<Subject> GetByStudentAndTerm(int studentId, int termId)
        {
            var subjects = from su in _context.Subjects
                           join c in _context.Courses on 
                           
            return subjects;
        }
    }
}
