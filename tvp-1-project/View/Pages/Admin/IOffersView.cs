using System.Collections.Generic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public interface IOffersView
    {
        POffers Presenter { get; set; }
        void PopulateDataViewer(List<Offer> data);
        void UpdateDataViewer(List<Offer> data);
        void SetCarsComboBox(List<Car> cars);
    }
}
