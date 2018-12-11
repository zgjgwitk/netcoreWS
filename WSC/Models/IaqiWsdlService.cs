using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace WSC.Models
{
	[ServiceContract]
    public interface IaqiWsdlService
    {
        [OperationContract]
        GetAQIByStationIdResponse GetAQIByStationId(GetAQIByStationIdRequest req);

        [OperationContract]
        GetAQIByMicrosoftStationIdResponse GetAQIByMicrosoftStationId(GetAQIByMicrosoftStationIdRequest req);

        [OperationContract]
        void VoidMethod(out string s);

        [OperationContract]
        Task<int> AsyncMethod();

        [OperationContract]
        int? NullableMethod(bool? arg);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
    }
}
