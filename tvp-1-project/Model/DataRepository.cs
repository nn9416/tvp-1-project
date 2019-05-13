using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace tvp_1_project.Model
{
    public class DataRepository : IDataRepository
    {
        public DataRepository()
        {
            Records = GetRecords();
        }

        public Records Records { get; set; }

        #region IDataRepository
        public Records GetRecords()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Records));

            using (Stream stream = GetType().Assembly.
               GetManifestResourceStream("tvp_1_project.Resources.carRepo.xml"))
                return (Records)serializer.Deserialize(stream);
        }

        public Admin GetAdmin()
        {
            return Admin.Read();
        }

        public List<Booking> GetBookings()
        {
            return Booking.ReadAll();
        }

        public List<Car> GetCars()
        {
            return Car.ReadAll();
        }

        public List<Customer> GetCustomers()
        {
            return Customer.ReadAll();
        }

        public List<Offer> GetOffers()
        {
            return Offer.ReadAll();
        }

        public List<string> GetYears()
        {
            return Records.Cars.Select(record => record.Year).ToList();
        }

        public Record GetAllMakesForYear(string year)
        {
            return Records.Cars.First(make => make.Year.Equals(year));
        }

        public List<CarModels> GetAllModelsForMake(string make, List<CarMakes> carMakes)
        {
            return carMakes.First(model => model.Make.Equals(make)).CarModels;
        }                

        public List<string> GetDisplacementForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).Displacement;
        }

        public List<string> GetFuelForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).Fuel;
        }

        public List<string> GetDriveForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).Drive;
        }

        public List<string> GetTransmissionForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).Transmission;
        }

        public List<string> GetBodyTypesForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).Body;
        }

        public List<string> GetNumberOfDoorsForModel(string model, List<CarModels> carModels)
        {
            return carModels.First(car => car.Model.Equals(model)).NumberOfDoors;
        }
        #endregion
    }
}
