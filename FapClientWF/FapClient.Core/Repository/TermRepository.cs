using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class TermRepository : CoreRepository<Term>, ITermRepository
    {
        public List<Term> GetByStudent(int studentId)
        {
            var terms = (from t in _context.Terms
                        join c in _context.Courses on t.TermId equals c.TermId
                        join sc in _context.StudentCourses on c.CourseId equals sc.CourseId
                        where sc.StudentId == studentId
                        select t).ToList();
            return terms;
        }
    }
}
