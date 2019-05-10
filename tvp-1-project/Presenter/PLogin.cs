using System.Collections.Generic;
using tvp_1_project.Model;
using tvp_1_project.View;

namespace tvp_1_project.Presenter
{
    public class PLogin
    {
        private readonly ILoginView _view;
        private readonly ILoginRepository _repository;

        public PLogin(ILoginView view, ILoginRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        internal bool TryLogin(string username, string password)
        {
            List<User> allUsers = new List<User>() { _repository.GetAdmin() };
            allUsers.AddRange(_repository.GetCustomers());
            return Authentication.Authenticate(username, password, allUsers);
        }

        internal void ShowFRegistration()
        {
            var registrationView = new FRegistration();
            var registrationRepository = _repository;
            var registrationPresenter = new PRegistration(registrationView, registrationRepository);
            registrationView.ShowDialog();
        }
    }
}
