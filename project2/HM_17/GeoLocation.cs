using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.HM_16
{
    internal class GeoLocation
    {
        public string Location { get; set; }
        public GeoLocation(string loc)
        {
            Location = loc;
        }
    }

    internal interface ICoordinatesService
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        ICoordinatesService GetCoordinates();
    }
    internal class GeoLocationAdapter : ICoordinatesService
    {
        private double latitude;
        private double longitude;
        public double Latitude { get { return latitude; } set { latitude = value; } }
        public double Longitude { get { return longitude; } set { longitude = value; } }
        public GeoLocationAdapter(GeoLocation gLocation)
        {
            Latitude = double.Parse(gLocation.Location.Split(',')[0].Replace('.',','));
            Longitude = double.Parse(gLocation.Location.Split(',')[1].Replace('.', ','));
        }
        public GeoLocationAdapter(GeoLocationAdapter other)
        {
            Latitude = other.Latitude;
            Longitude = other.Longitude;
        }
        public ICoordinatesService GetCoordinates()
        {
            return new GeoLocationAdapter(this);
        }
    }

}
