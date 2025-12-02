using EnterpriseEntities;

namespace ApplicationLayer
{
    public class PostLogInUseCase
    {
        private readonly ILogInRepository _repository;
        private readonly ILogInPresenter _presenter;

        public PostLogInUseCase(ILogInRepository repository, ILogInPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task ExecuteAsync(LogIn login)
        {
            await _repository.CreateAsync(login);

            _presenter.Present(new List<LogIn> { login });
        }
    }
}
