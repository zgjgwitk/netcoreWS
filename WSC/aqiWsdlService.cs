using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSC.Models;
using System.Xml.Linq;

namespace WSC
{
    public class aqiWsdlService: IaqiWsdlService
    {
        public GetAQIByStationIdResponse GetAQIByStationId(GetAQIByStationIdRequest req)
        {
            return new GetAQIByStationIdResponse();
        }

        public GetAQIByMicrosoftStationIdResponse GetAQIByMicrosoftStationId(GetAQIByMicrosoftStationIdRequest req)
        {
            return new GetAQIByMicrosoftStationIdResponse();
        }

        public void VoidMethod(out string s)
        {
            s = "Value from server";
        }

        public Task<int> AsyncMethod()
        {
            return Task.Run(() => 42);
        }

        public int? NullableMethod(bool? arg)
        {
            return null;
        }

        public void XmlMethod(XElement xml)
        {
            Console.WriteLine(xml.ToString());
        }
    }
}
