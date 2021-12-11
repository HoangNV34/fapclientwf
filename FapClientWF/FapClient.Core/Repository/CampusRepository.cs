using FapClient.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace FapClient.Core.Repository
{
    public class CampusRepository : CoreRepository<Campus>, ICampusRepository
    {
        public List<Campus> GetAll()
        {
            return _context.Campuses.ToList();
        }
    }
}
