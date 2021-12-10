using FapClient.Core.Infrastructure.Repository;
using FapClient.Core.Models;
using System;

namespace FapClient.Core.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        AP2Context DataContext { get; }

        int SaveChanges();

        ICoreRepository<T> CoreRepository<T>() where T : class;

        #region master data
        ICoreRepository<Campus> CampusRepository { get; }
        ICoreRepository<Course> CourseRepository { get; }
        ICoreRepository<CourseSchedule> CourseScheduleRepository { get; }
        ICoreRepository<Department> DepartmentRepository { get; }
        ICoreRepository<Grade> GradeRepository { get; }
        ICoreRepository<Gradetitle> GradetitleRepository { get; }
        ICoreRepository<Instructor> InstructorRepository { get; }
        ICoreRepository<RollCallBook> RollCallBookRepository { get; }
        ICoreRepository<Room> RoomRepository { get; }
        ICoreRepository<Student> StudentRepository { get; }
        ICoreRepository<StudentCourse> StudentCourseRepository { get; }
        ICoreRepository<Subject> SubjectRepository { get; }
        ICoreRepository<Term> TermRepository { get; }
        #endregion
    }
}
