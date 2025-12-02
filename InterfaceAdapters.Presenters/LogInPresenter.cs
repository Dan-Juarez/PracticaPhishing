using ApplicationLayer;
using EnterpriseEntities;
using InterfaceAdapters.Dtos;

namespace InterfaceAdapters.Presenters
{
    public class LogInPresenter : ILogInPresenter
    {
        public IEnumerable<LogInResponseModel> ViewModel { get; private set; }

        public void Present(IEnumerable<LogIn> logIns)
        {
            ViewModel = logIns.Select(l => new LogInResponseModel
            {
                Id = l.Id,
                Usuario = l.Usuario,
                Contrasena = l.Contrasena
            });
        }
    }
}
