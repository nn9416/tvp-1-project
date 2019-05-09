using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class Customer : User, IConnection<Customer>, ISerializable
    {
        public Customer() { }
        public Customer(string firstName, string lastName, string ssn, DateTime birthDate, string phoneNumber, string username, string password) : base(username, password)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Ssn = ssn;
            BirthDate = birthDate.Date;
            PhoneNumber = phoneNumber;
        }

        #region ISerializable
        public Customer(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            Id = info.GetString("Id");
            FirstName = info.GetString("FirstName");
            LastName = info.GetString("LastName");
            Ssn = info.GetString("Ssn");
            BirthDate = info.GetDateTime("BirthDate");
            PhoneNumber = info.GetString("PhoneNumber");
        }        

        public new void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("FirstName", FirstName);
            info.AddValue("LastName", LastName);
            info.AddValue("Ssn", Ssn);
            info.AddValue("BirthDate", BirthDate);
            info.AddValue("PhoneNumber", PhoneNumber);
            info.AddValue("Username", Username);
            info.AddValue("Password", Password);
        }
        #endregion

        #region IConnection<>
        public void Create() => FileSystemCRUD.Create(path: $@"{DIRECTORY}\{Id}", serializableData: this);

        public Customer Read() => FileSystemCRUD.Read(path: $@"{DIRECTORY}\{Id}") as Customer;

        public void Update(Customer data) => FileSystemCRUD.Update(path: $@"{DIRECTORY}\{Id}", serializableData: data);

        public void Delete() => FileSystemCRUD.Delete(path: $@"{DIRECTORY}\{Id}");
        #endregion

        public static List<Customer> ReadAll() => FileSystemCRUD.ReadAll(path: DIRECTORY).Cast<Customer>().ToList();

        public static string DIRECTORY { get; } = AppSettings.GetDirectory("customers");
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Ssn { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}
