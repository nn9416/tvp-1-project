using System.Collections.Generic;
using System.Linq;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter.Pages.Admin
{
    public class POffers
    {
        private readonly IOffersView _view;
        private readonly IDataRepository _repository;

        public POffers(IOffersView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        public void GetOffers() => _view.PopulateDataViewer(_repository.GetOffers());

        internal void UpdateData()
        {
            _view.UpdateDataViewer(_repository.GetOffers());
            UpdateCarsComboBox();
        }

        internal void UpdateCarsComboBox() => _view.SetCarsComboBox(_repository.GetCars().ToList());

        internal bool TryCreateNew(Dictionary<string, object> values) => Validation.ValidateOffer(values);
    }
}
