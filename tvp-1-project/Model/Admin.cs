using System;
using System.Runtime.Serialization;

namespace tvp_1_project.Model
{
    [Serializable]
    public class Admin : User, ISerializable
    {
        public Admin(string username, string password) : base(username, password) { }

        #region ISerializable
        public Admin(SerializationInfo info, StreamingContext context) : base(info, context) { }

        public new void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Username", Username);
            info.AddValue("Password", Password);
        }
        #endregion

        public static Admin Read()
        {
            string path = $@"{DIRECTORY}\admin";
            return FileSystemCRUD.Read(path) as Admin;
        }

        public void Create()
        {
            string path = $@"{DIRECTORY}\admin";
            FileSystemCRUD.Create(path, this);
        }

        public static string DIRECTORY { get; } = AppSettings.GetDirectory("admin");
    }
}
