using FapClient.Core.Models;
using System.Collections.Generic;

namespace FapClient.Core.Repository
{
    public interface IRollCallBookRepository : ICoreRepository<RollCallBook>
    {
        List<RollCallBook> GetStudent(int sId, int subjectId, int termId);
    }
}
