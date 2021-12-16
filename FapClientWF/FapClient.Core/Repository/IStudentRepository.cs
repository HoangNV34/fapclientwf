using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface IStudentRepository : ICoreRepository<Student>
    {
        List<Student> GetAllByCampus(string campus);

        List<Student> Search(string name);
    }
}
