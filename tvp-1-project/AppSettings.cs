using System;
using System.IO;

namespace tvp_1_project
{
    class AppSettings
    {
        private static readonly string APPDIRECTORY = Environment.ExpandEnvironmentVariables(@"%APPDATA%\tvp1project");

        public static string GetDirectory(string dataDirectory) => $@"{APPDIRECTORY}\{dataDirectory}";

        public static void CreateDirectories()
        {
            if (!Directory.Exists(APPDIRECTORY))
            {
                Directory.CreateDirectory(APPDIRECTORY);
                Directory.CreateDirectory(GetDirectory("admin"));
                Directory.CreateDirectory(GetDirectory("cars"));
                Directory.CreateDirectory(GetDirectory("customers"));
                Directory.CreateDirectory(GetDirectory("offers"));
                Directory.CreateDirectory(GetDirectory("bookings"));
            }
        }
    }
}
