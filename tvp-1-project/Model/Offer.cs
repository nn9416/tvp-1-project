using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class Offer : IConnection<Offer>, ISerializable
    {
        [NonSerialized]
        private string display;

        public Offer(Car car, DateTime dateFrom, DateTime dateTo, string dayPrice)
        {
            Id = Guid.NewGuid().ToString();
            Car = car;
            DateFrom = dateFrom.Date;
            DateTo = dateTo.Date;
            DayPrice = dayPrice;
            display = ToString();
            Bookings = new List<Booking>();
        }

        #region ISerializable
        public Offer(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            Id = info.GetString("Id");
            Car = (Car)info.GetValue("Car", Car.GetType());
            DateFrom = info.GetDateTime("DateFrom");
            DateTo = info.GetDateTime("DateTo");
            DayPrice = info.GetString("DayPrice");
            Display = ToString();
            Bookings = (List<Booking>)info.GetValue("Bookings", typeof(List<Booking>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Car", Car);
            info.AddValue("DateFrom", DateFrom);
            info.AddValue("DateTo", DateTo);
            info.AddValue("DayPrice", DayPrice);
            info.AddValue("Bookings", Bookings);
        }
        #endregion

        #region IConnection<>
        public void Create() => FileSystemCRUD.Create(path: $@"{DIRECTORY}\{Id}", serializableData: this);

        public Offer Read() => FileSystemCRUD.Read(path: $@"{DIRECTORY}\{Id}") as Offer;

        public void Update(Offer data) => FileSystemCRUD.Update(path: $@"{DIRECTORY}\{Id}", serializableData: data);

        public void Delete()
        {           
            if (Bookings.Count == 0)            
                FileSystemCRUD.Delete(path: $@"{DIRECTORY}\{Id}");            
            //else
                // Notify user (Can't delete offer with active reservations)       
        }
        #endregion

        public static List<Offer> ReadAll() => FileSystemCRUD.ReadAll(path: DIRECTORY).Cast<Offer>().ToList();

        public override string ToString()
        {
            return $"{Car.ToString()} | {DateFrom.ToShortDateString()} - {DateTo.ToShortDateString()}";
        }

        public static string DIRECTORY { get; } = AppSettings.GetDirectory("offers");
        public string Id { get; set; }
        public Car Car { get; set; } = new Car();
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string DayPrice { get; set; }
        public string Display { get => display; private set => display = value; }
        public List<Booking> Bookings { get; set; }
    }
}
