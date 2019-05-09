using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class Booking : IConnection<Booking>, ISerializable
    {
        [NonSerialized]
        private string display;

        public Booking(Customer customer, Car car, DateTime dateFrom, DateTime dateTo)
        {
            Id = Guid.NewGuid().ToString();
            Customer = customer;
            Car = car;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Price = "0";
            Display = ToString();
        }
        public Booking(Customer customer, Car car, DateTime dateFrom, DateTime dateTo, string price)
        {
            Id = Guid.NewGuid().ToString();
            Customer = customer;
            Car = car;
            DateFrom = dateFrom;
            DateTo = dateTo;
            Price = price;
            Display = ToString();
        }        

        #region ISerializable
        public Booking(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            Id = info.GetString("Id");
            Customer = (Customer)info.GetValue("Customer", Customer.GetType());
            Car = (Car)info.GetValue("Car", Car.GetType());
            DateFrom = info.GetDateTime("DateFrom");
            DateTo = info.GetDateTime("DateTo");
            Price = info.GetString("Price");
            Display = ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Customer", Customer);
            info.AddValue("Car", Car);
            info.AddValue("DateFrom", DateFrom);
            info.AddValue("DateTo", DateTo);
            info.AddValue("Price", Price);
        }
        #endregion

        #region IConnection
        public void Create() => FileSystemCRUD.Create(path: $@"{DIRECTORY}\{Id}", serializableData: this);

        public Booking Read() => FileSystemCRUD.Read(path: $@"{DIRECTORY}\{Id}") as Booking;

        public void Update(Booking data) => FileSystemCRUD.Update(path: $@"{DIRECTORY}\{Id}", serializableData: data);

        public void Delete() => FileSystemCRUD.Delete(path: $@"{DIRECTORY}\{Id}");
        #endregion        

        #region Overrides
        public override string ToString() => $"{Car.Display} // {Customer.Display} // {DateFrom.ToShortDateString()} - {DateTo.ToShortDateString()} // Cena: {Price.ToString()}";
        #endregion

        public static List<Booking> ReadAll() => FileSystemCRUD.ReadAll(path: DIRECTORY).Cast<Booking>().ToList();

        public static string DIRECTORY { get; } = AppSettings.GetDirectory("bookings");
        public string Id { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public Car Car { get; set; } = new Car();
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Price { get; set; }
        public string Display { get => display; private set => display = value; }
     }
}
