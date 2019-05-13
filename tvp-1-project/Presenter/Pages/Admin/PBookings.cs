using System.Collections.Generic;
using System.Linq;
using tvp_1_project.BussinesLogic;
using tvp_1_project.Model;
using tvp_1_project.View.Pages.Admin;

namespace tvp_1_project.Presenter.Pages.Admin
{
    public class PBookings
    {
        private readonly IBookingsView _view;
        private readonly IDataRepository _repository;

        public PBookings(IBookingsView view, IDataRepository repository)
        {
            _view = view;
            _repository = repository;
            view.Presenter = this;
        }

        public void GetBookings() => _view.PopulateDataViewer(_repository.GetBookings());

        internal void UpdateData()
        {
            _view.UpdateDataViewer(_repository.GetBookings());
            UpdateCustomersComboBox();
            UpdateCarsComboBox();
        }

        public List<string> GetYears() => _repository.GetYears();

        internal void UpdateCustomersComboBox() => _view.SetCustomersComboBox(_repository.GetCustomers());

        internal void UpdateCarsComboBox() => _view.SetCarsComboBox(_repository.GetCars().ToList());

        internal List<Booking> GetBookingsForCustomer(Customer customer)
        {
            List<Booking> bookingsForCustomer = new List<Booking>();
            foreach (Booking booking in _repository.GetBookings().Where(i => i.Customer.Display.Equals(customer.Display)))
            {
                bookingsForCustomer.Add(booking);
            }

            return bookingsForCustomer;
        }

        internal List<Offer> GetOffersForCar(Car car)
        {
            List<Offer> offersForCar = new List<Offer>();
            foreach (Offer offer in _repository.GetOffers().Where(i => i.Car.Display.Equals(car.Display)))
            {
                offersForCar.Add(offer);
            }
            return offersForCar;
        }

        // TODO: Implement validation for bookings
        //internal bool TryCreateNew(Dictionary<string, object> values) => Validation.ValidateBooking(values);
    }
}
