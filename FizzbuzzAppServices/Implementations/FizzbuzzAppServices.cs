using FizzbuzzAppServices.Contracts;
using Infrastructure.FizzbuzzRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace FizzbuzzAppServices.Implementations
{
    public class FizzbuzzAppServices : IFizzbuzzAppServices
    {
        private IFizzbuzzRepository _fizzbuzzRepository;
        private readonly ILog _log;

        public FizzbuzzAppServices() { }

        public FizzbuzzAppServices(IFizzbuzzRepository fizzbuzzRepository, ILog log)
        {
            _fizzbuzzRepository = fizzbuzzRepository;
            _log = log;
        }

        public List<string> GetFizzbuzz(string number)
        {
            throw new NotImplementedException();
        }

        public int ParseNumber(string number)
        {
            throw new NotImplementedException();
        }
    }
}
