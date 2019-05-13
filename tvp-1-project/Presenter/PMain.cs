using System.Reflection;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;
using tvp_1_project.View;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter
{
    public class PMain
    {
        private readonly IMainView _view;
        private readonly IDataRepository _repository;

        public PMain(IMainView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
            _view.SetViewState(Authentication.IsAdmin);
            InitOtherPresenters(view, repository);
        }

        private void InitOtherPresenters(IMainView view, IDataRepository repository)
        {
            PCars pCars = new PCars(view.Pages["cars"] as PageCars, repository);
            PCustomers pCustomers = new PCustomers(view.Pages["customers"] as PageCustomers, repository);
            POffers pOffers = new POffers(view.Pages["offers"] as PageOffers, repository);
            PBookings pBookings = new PBookings(view.Pages["bookings"] as PageBookings, repository);
            // TODO: Uncomment when statistics feature is merged
            //PStatistics pStatistics = new PStatistics(view.Pages["statistics"] as PageStatistics, repository);
        }

        internal void PerformCRUD(string methodName, object data)
        {
            MethodInfo mi = data.GetType().GetMethod(methodName);
            if (methodName.Equals("Update"))
            {
                mi.Invoke(data, new object[] { data });
            }
            else
            {
                mi.Invoke(data, null);
            }
        }
    }
}
