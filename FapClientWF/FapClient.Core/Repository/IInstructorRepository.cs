using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface IInstructorRepository : ICoreRepository<Instructor>
    {
        List<Instructor> GetAll();
    }
}
