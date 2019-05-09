using System;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class User : ISerializable
    {
        [NonSerialized]
        private string display;

        public User() { }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Display = ToString();
        }        

        #region ISerializable
        public User(SerializationInfo info, StreamingContext context)
        {
            Username = info.GetString("Username");
            Password = info.GetString("Password");
            Display = ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Username", Username);
            info.AddValue("Password", Password);
        }
        #endregion

        public override string ToString()
        {
            return $"{Username}";
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Display { get => display; private set => display = value; }
    }
}
