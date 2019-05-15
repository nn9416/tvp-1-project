using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class Car : IConnection<Car>, ISerializable
    {
        [NonSerialized]
        private string display;

        public Car() { }
        public Car(string productionYear, string make, string model, string displacement, string fuel, string drive, string transmission, string body, string numberOfDoors)
        {
            Id = Guid.NewGuid().ToString();
            ProductionYear = int.Parse(productionYear);
            Make = make;
            Model = model;
            Displacement = int.Parse(displacement);
            Fuel = fuel;
            Drive = drive;
            Transmission = transmission;
            Body = body;
            NumberOfDoors = int.Parse(numberOfDoors);
            Display = ToString();
        }
        public Car(string id, string productionYear, string make, string model, string displacement, string fuel, string drive, string transmission, string body, string numberOfDoors)
        {
            Id = id;
            ProductionYear = int.Parse(productionYear);
            Make = make;
            Model = model;
            Displacement = int.Parse(displacement);
            Fuel = fuel;
            Drive = drive;
            Transmission = transmission;
            Body = body;
            NumberOfDoors = int.Parse(numberOfDoors);
            Display = ToString();
        }

        #region ISerializable
        public Car(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            Id = info.GetString("Id");
            ProductionYear = info.GetInt32("ProductionYear");
            Make = info.GetString("Make");
            Model = info.GetString("Model");
            Displacement = info.GetInt32("Displacement");
            Fuel = info.GetString("Fuel");
            Drive = info.GetString("Drive");
            Transmission = info.GetString("Transmission");
            Body = info.GetString("Body");
            NumberOfDoors = info.GetInt32("NumberOfDoors");
            Display = ToString();
        }        

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("ProductionYear", ProductionYear);
            info.AddValue("Make", Make);
            info.AddValue("Model", Model);
            info.AddValue("Displacement", Displacement);
            info.AddValue("Fuel", Fuel);
            info.AddValue("Drive", Drive);
            info.AddValue("Transmission", Transmission);
            info.AddValue("Body", Body);
            info.AddValue("NumberOfDoors", NumberOfDoors);
        }
        #endregion

        #region IConnection
        public void Create() => FileSystemCRUD.Create(path: $@"{DIRECTORY}\{Id}", serializableData: this);

        public Car Read() => FileSystemCRUD.Read(path: $@"{DIRECTORY}\{Id}") as Car;

        public void Update(Car data) => FileSystemCRUD.Update(path: $@"{DIRECTORY}\{Id}", serializableData: data);

        public void Delete() => FileSystemCRUD.Delete(path: $@"{DIRECTORY}\{Id}");
        #endregion

        public static List<Car> ReadAll() => FileSystemCRUD.ReadAll(path: DIRECTORY).Cast<Car>().ToList();

        #region Overrides
        public override string ToString() => $"{Make} {Model} | {ProductionYear}";
        #endregion

        public static string DIRECTORY { get; } = AppSettings.GetDirectory("cars");
        public string Id { get; set; }
        public int ProductionYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Displacement { get; set; }
        public string Fuel { get; set; }
        public string Drive { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public int NumberOfDoors { get; set; }
        public string Display { get => display; private set => display = value; }
    }
}
