using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace tvp_1_project.Model
{
    class FileSystemCRUD
    {
        public static object Create(string path, ISerializable serializableData)
        {
            FileStream fileStream = File.Open(path, FileMode.CreateNew);
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            binaryFormatter.Serialize(fileStream, serializableData);
            fileStream.Close();

            return serializableData;
        }

        public static object Read(string path)
        {
            if (File.Exists(path))
            {
                FileStream fileStream = File.Open(path, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                object data = binaryFormatter.Deserialize(fileStream);
                fileStream.Close();
                return data;
            }
            else
            {
                // TODO: Notify user
                return null;
            }
            
        }

        public static object Update(string path, ISerializable serializableData)
        {
            if (File.Exists(path))
            {
                FileStream fileStream = File.Open(path, FileMode.Truncate);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, serializableData);
                fileStream.Close();
                return serializableData;
            }
            else
            {
                // TODO: Notify user
                return null;
            }
        }

        public static object Delete(string path)
        {
            if (File.Exists(path))
            {
                object data = Read(path);
                File.Delete(path);
                return data;
            }
            else
            {
                // TODO: Notify user
                return null;
            }
        }

        public static List<object> ReadAll(string path)
        {
            List<object> dataList = new List<object>();
            string[] files = Directory.GetFiles(path);
            if (files.Length > 0)
            {
                foreach (string filePath in files)
                {
                    dataList.Add(Read(filePath));
                }
                return dataList;
            }            
            else
            {
                // TODO: Notify user
                // return null;
                return new List<object>() { };
            }
        }
    }
}
