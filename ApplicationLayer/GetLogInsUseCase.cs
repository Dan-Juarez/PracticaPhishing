using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class GetLogInsUseCase
    {
        private readonly ILogInRepository _repository;
        private readonly ILogInPresenter _presenter;

        public GetLogInsUseCase(ILogInRepository repository, ILogInPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task ExecuteAsync()
        {
            var logIns = await _repository.GetAllAsync();
            _presenter.Present(logIns);
        }
    }
}
