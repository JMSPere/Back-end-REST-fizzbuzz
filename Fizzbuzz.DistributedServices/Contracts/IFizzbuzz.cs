using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Fizzbuzz.DistributedServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFizzbuzz
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "/Foo",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        int Foo();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "/Fizzbuzz/{number}",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        List<string> GetFizzbuzz(string number);
    }
}
