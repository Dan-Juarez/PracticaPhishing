using ApplicationLayer;
using EnterpriseEntities;
using InterfaceAdapters.Dtos;
using InterfaceAdapters.Presenters;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LogInController : ControllerBase
    {
        private readonly GetLogInsUseCase _getLogInsUseCase;
        private readonly PostLogInUseCase _postLogInUseCase;
        private readonly ILogInPresenter _presenter;

        public LogInController(
            GetLogInsUseCase getLogInsUseCase,
            PostLogInUseCase postLogInUseCase,
            ILogInPresenter presenter)
        {
            _getLogInsUseCase = getLogInsUseCase;
            _postLogInUseCase = postLogInUseCase;
            _presenter = presenter;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogInResponseModel>>> Get()
        {
            await _getLogInsUseCase.ExecuteAsync();

            // AQUÍ es donde realmente regresamos los datos
            return Ok(_presenter.ViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LogInRequestModel request)
        {
            var entity = new EnterpriseEntities.LogIn
            {
                Usuario = request.Usuario,
                Contrasena = request.Contrasena
            };

            await _postLogInUseCase.ExecuteAsync(entity);

            return Ok(_presenter.ViewModel);
        }
    }
}
