using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class StudentAttendentRepository : CoreRepository<StudentAttendent>, IStudentAttendentRepository
    {
        public List<StudentAttendent> GetStudent(int sId, int subjectId, int termId)
        {
            var studentAttents = (from r in _context.RollCallBooks
                                  join sc in _context.StudentCourses on r.StudentId equals sc.StudentId
                                  join c in _context.Courses on sc.CourseId equals c.CourseId
                                  join cs in _context.CourseSchedules on r.TeachingScheduleId equals cs.TeachingScheduleId
                                  where r.StudentId == sId & c.SubjectId == subjectId & c.TermId == termId
                                  select new StudentAttendent
                                  {
                                      RollCallBookId = r.RollCallBookId,
                                      StudentId = (int)r.StudentId,
                                      TeachingDate = cs.TeachingDate,
                                      Slot = cs.Slot,
                                      RoomId = cs.RoomId,
                                      InstructorId = (int)c.InstructorId,
                                      IsAbsent = r.IsAbsent,
                                      Comment = r.Comment
                                  }).Distinct().ToList();
            return studentAttents;
        }
    }
}
