using EnterpriseEntities;
using InterfaceAdapters.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public interface ILogInPresenter
    {
        IEnumerable<LogInResponseModel> ViewModel { get; }
        void Present(IEnumerable<LogIn> logIns);
    }
}
