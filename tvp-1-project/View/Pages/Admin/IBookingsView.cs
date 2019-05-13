using System.Collections.Generic;
using tvp_1_project.Model;
using tvp_1_project.Presenter.Pages.Admin;

namespace tvp_1_project.View.Pages.Admin
{
    public interface IBookingsView
    {
        PBookings Presenter { get; set; }
        void PopulateDataViewer(List<Booking> data);
        void UpdateDataViewer(List<Booking> data);
        void SetCustomersComboBox(List<Customer> customers);
        void SetCarsComboBox(List<Car> cars);
    }
}
