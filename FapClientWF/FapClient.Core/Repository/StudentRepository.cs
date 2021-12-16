using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class StudentRepository : CoreRepository<Student>, IStudentRepository
    {
        public List<Student> GetAllByCampus(string campus)
        {
            var students = (from s in _context.Students
                            join sc in _context.StudentCourses on s.StudentId equals sc.StudentId
                            join c in _context.Courses on sc.CourseId equals c.CourseId
                            join cp in _context.Campuses on c.CampusId equals cp.CampusId
                            where cp.CampusName == campus
                            select s).ToList();
            return students;
        }

        public List<Student> Search(string name)
        {
            return _context.Students.Where(x=>x.FirstName.Contains(name)||
                                              x.MidName.Contains(name) ||
                                              x.LastName.Contains(name)).ToList();
        }
    }
}
