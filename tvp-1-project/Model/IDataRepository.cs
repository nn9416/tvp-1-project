using System.Collections.Generic;

namespace tvp_1_project.Model
{
    public interface IDataRepository
    {
        Records GetRecords();
        Record GetAllMakesForYear(string year);
        List<CarModels> GetAllModelsForMake(string make, List<CarMakes> carMakes);
        List<string> GetDisplacementForModel(string model, List<CarModels> carModels);
        List<string> GetFuelForModel(string model, List<CarModels> carModels);
        List<string> GetDriveForModel(string model, List<CarModels> carModels);
        List<string> GetTransmissionForModel(string model, List<CarModels> carModels);
        List<string> GetBodyTypesForModel(string model, List<CarModels> carModels);
        List<string> GetNumberOfDoorsForModel(string model, List<CarModels> carModels);
        List<string> GetYears();
        Admin GetAdmin();
        List<Car> GetCars();
        List<Customer> GetCustomers();
        List<Booking> GetBookings();
        List<Offer> GetOffers();
    }
}
