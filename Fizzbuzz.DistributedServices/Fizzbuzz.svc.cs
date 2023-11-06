using FizzbuzzAppServices.Contracts;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Fizzbuzz.DistributedServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Fizzbuzz : IFizzbuzz
    {
        private readonly IFizzbuzzAppServices _fizzbuzzAppServices;

        private readonly ILog _log;

        public Fizzbuzz() { }

        public Fizzbuzz(IFizzbuzzAppServices fizzbuzzAppServices, ILog log)
        {
            _fizzbuzzAppServices = fizzbuzzAppServices;
            _log = log;
        }
       public int Foo()
        {
            return 1;
        }

        public List<string> GetFizzbuzz(string number)
        {
            throw new NotImplementedException();
        }
    }
}
