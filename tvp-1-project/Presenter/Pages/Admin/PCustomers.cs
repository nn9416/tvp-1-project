using System.Collections.Generic;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter.Pages.Admin
{
    public class PCustomers
    {
        private readonly ICustomersView _view;
        private readonly IDataRepository _repository;

        public PCustomers(ICustomersView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        public void GetCustomers() => _view.PopulateDataViewer(_repository.GetCustomers());

        internal void UpdateData() => _view.UpdateDataViewer(_repository.GetCustomers());

        internal bool TryCreateNew(Dictionary<string, string> values) => Validation.ValidateCustomer(values);
    }
}
