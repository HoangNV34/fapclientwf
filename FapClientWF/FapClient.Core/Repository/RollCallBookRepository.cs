using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public class RollCallBookRepository : CoreRepository<RollCallBook>, IRollCallBookRepository
    {
        public List<RollCallBook> GetStudent(int sId, int subjectId, int termId)
        {
            var studentAttent = (from r in _context.RollCallBooks
                                 join sc in _context.StudentCourses on r.StudentId equals sc.StudentId
                                 join c in _context.Courses on sc.CourseId equals c.CourseId
                                 join cs in _context.CourseSchedules on r.TeachingScheduleId equals cs.TeachingScheduleId
                                 where r.StudentId = sId & c.SubjectId = subjectId & c.TermId = termId
                                 select new RollCallBook(
                                     cs.TeachingDate, cs.Slot, cs.RoomId, c.InstructorId, r.IsAbsent, r.Comment
                                     )).Distinct().ToList();
            return studentAttent;
        }
    }
}
