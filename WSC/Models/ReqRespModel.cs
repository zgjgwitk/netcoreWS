using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSC.Models
{
    public class GetAQIByStationIdRequest
    {
        public string stationId { get; set; }
        public string udid { get; set; }
        public string secretCode { get; set; }
    }

    public class GetAQIByMicrosoftStationIdRequest
    {
        public string stationId { get; set; }
        public string udid { get; set; }
        public string secretCode { get; set; }
    }

    public class GetAQIByStationIdResponse
    {
        public AQI GetAQIByStationIdResult { get; set; }
    }

    public class GetAQIByMicrosoftStationIdResponse
    {
        public AQI GetAQIByStationIdResult { get; set; }
    }

    public class AQI
    {
        public string Time { get; set; }
        public int PM25 { get; set; }
        public int PM10 { get; set; }
        public int NO2 { get; set; }
        public int CO { get; set; }
        public int O3 { get; set; }
        public int SO2 { get; set; }
    }
}
