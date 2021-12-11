using FapClient.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FapClient.Core.Repository
{
    public interface ICampusRepository : ICoreRepository<Campus>
    {
        List<Campus> GetAll();
    }
}
