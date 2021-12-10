using FapClient.Core.Infrastructure.Repository;
using FapClient.Core.Models;

namespace FapClient.Core.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AP2Context _context;

        public AP2Context DataContext => _context;

        public UnitOfWork(AP2Context context)
        {
            _context = context;
        }

        private ICoreRepository<Campus> _campusRepository;
        public ICoreRepository<Campus> CampusRepository => _campusRepository ?? new CoreRepository<Campus>(_context);
        
        private ICoreRepository<Course> _courseRepository;

        public ICoreRepository<Course> CourseRepository => _courseRepository ?? new CoreRepository<Course>(_context);

        private ICoreRepository<CourseSchedule> _courseScheduleRepository;

        public ICoreRepository<CourseSchedule> CourseScheduleRepository => _courseScheduleRepository ?? new CoreRepository<CourseSchedule>(_context);

        private ICoreRepository<Department> _departmentRepository;

        public ICoreRepository<Department> DepartmentRepository => _departmentRepository ?? new CoreRepository<Department>(_context);

        private ICoreRepository<Grade> _gradeRepository;

        public ICoreRepository<Grade> GradeRepository => _gradeRepository ?? new CoreRepository<Grade>(_context);

        private ICoreRepository<Gradetitle> _gradetitleRepository;

        public ICoreRepository<Gradetitle> GradetitleRepository => _gradetitleRepository ?? new CoreRepository<Gradetitle>(_context);

        private ICoreRepository<Instructor> _instructorRepository;

        public ICoreRepository<Instructor> InstructorRepository => _instructorRepository ?? new CoreRepository<Instructor>(_context);

        private ICoreRepository<RollCallBook> _rollCallBookRepository;

        public ICoreRepository<RollCallBook> RollCallBookRepository => _rollCallBookRepository ?? new CoreRepository<RollCallBook>(_context);

        private ICoreRepository<Room> _roomRepository;

        public ICoreRepository<Room> RoomRepository => _roomRepository ?? new CoreRepository<Room>(_context);

        private ICoreRepository<Student> _studentRepository;

        public ICoreRepository<Student> StudentRepository => _studentRepository ?? new CoreRepository<Student>(_context);

        private ICoreRepository<StudentCourse> _studentCourseRepository;

        public ICoreRepository<StudentCourse> StudentCourseRepository => _studentCourseRepository ?? new CoreRepository<StudentCourse>(_context);

        private ICoreRepository<Subject> _subjectRepository;

        public ICoreRepository<Subject> SubjectRepository => _subjectRepository ?? new CoreRepository<Subject>(_context);

        private ICoreRepository<Term> _termRepository;

        public ICoreRepository<Term> TermRepository => _termRepository ?? new CoreRepository<Term>(_context);

        public ICoreRepository<T> CoreRepository<T>() where T : class
        {
            return new CoreRepository<T>(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
