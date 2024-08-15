using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssPosition.Models
{
    public class CurrentPositionData
    {
        public string ID { get; set; }
        public string? Name { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string? Altitude { get; set; }
        public string? Velocity { get; set; }
        public string? Visibility { get; set; }
        public string? Footprint { get; set; }
        public string? Timestamp { get; set; }

        public CurrentPositionData(string id, string name, string latitude, string longitude, string altitude, string velocity, string visibility, string footprint, string timestamp)
        {
            ID = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            Altitude = altitude;
            Velocity = velocity;
            Visibility = visibility;
            Footprint = footprint;
            Timestamp = timestamp;           
        }
    }


   
}
