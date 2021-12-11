using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class SubjectRepository : CoreRepository<Subject>, ISubjectRepository
    {
        public List<Subject> GetByStudentAndTerm(int studentId, int termId)
        {
            var subjects = (from su in _context.Subjects
                           join c in _context.Courses on su.SubjectId equals c.SubjectId
                           join t in _context.Terms on c.TermId equals t.TermId
                           join sc in _context.StudentCourses on c.CourseId equals sc.CourseId
                           join s in _context.Students on sc.StudentId equals s.StudentId
                           where s.StudentId == studentId & t.TermId == termId
                           select su).Distinct().ToList();
            return subjects;
        }
    }
}
