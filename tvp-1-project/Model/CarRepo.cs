using System.Collections.Generic;
using System.Xml.Serialization;

namespace tvp_1_project.Model
{
    [XmlRoot("Records")]
    public class Records
    {
        [XmlElement("Record")]
        public List<Record> Cars { get; set; }

        public Record GetAllMakesForYear(int year)
        {
            return Cars.Find(i => i.Year.Equals(year));
        }
    }

    public class Record
    {
        [XmlElement("year")]
        public string Year { get; set; }
        [XmlElement("makes")]
        public List<CarMakes> CarMakes { get; set; }

        public List<CarModels> GetAllModelsForMake(string make)
        {
            return CarMakes.Find(i => i.Make.Equals(make)).CarModels;
        }
    }

    public class CarMakes
    {
        [XmlElement("make")]
        public string Make { get; set; }
        [XmlElement("models")]
        public List<CarModels> CarModels { get; set; }
    }

    public class CarModels
    {
        [XmlElement("model")]
        public string Model { get; set; }
        [XmlElement("displacement")]
        public List<string> Displacement { get; set; }
        [XmlElement("fuel")]
        public List<string> Fuel { get; set; }
        [XmlElement("drive")]
        public List<string> Drive { get; set; }
        [XmlElement("transmission")]
        public List<string> Transmission { get; set; }
        [XmlElement("body_style")]
        public List<string> Body { get; set; }
        [XmlElement("number_of_doors")]
        public List<string> NumberOfDoors { get; set; }
    }
}
