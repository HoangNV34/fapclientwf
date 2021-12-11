using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface ITermRepository : ICoreRepository<Term>
    {
        List<Term> GetByStudent(int studentId);
    }
}
