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
                           join sc in _context.StudentCourses on c.CourseId equals sc.CourseId
                           where sc.StudentId == studentId & c.TermId == termId
                           select su).Distinct().ToList();
            return subjects;
        }
    }
}
