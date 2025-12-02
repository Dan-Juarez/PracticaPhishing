using EnterpriseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public interface ILogInRepository
    {
        Task CreateAsync(LogIn login);
        Task<IEnumerable<LogIn>> GetAllAsync();
    }
}
