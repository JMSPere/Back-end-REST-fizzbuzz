using FizzbuzzAppServices.Contracts;
using Infrastructure.FizzbuzzRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CrossCutting.Configuration;
using Domain.Entities;

namespace FizzbuzzAppServices.Implementations
{
    public class FizzbuzzAppServices : IFizzbuzzAppServices
    {
        private IFizzbuzzRepository _fizzbuzzRepository;
        private IConfiguration _configuration;
        private readonly ILog _log;

        public FizzbuzzAppServices() { }

        public FizzbuzzAppServices(IFizzbuzzRepository fizzbuzzRepository, ILog log, IConfiguration configuration)
        {
            _configuration = configuration;
            _fizzbuzzRepository = fizzbuzzRepository;
            _log = log;
        }

        public List<string> GetFizzbuzz(string number)
        {
            var numberParsed = ParseNumber(number);
            var fizzbuzzStringList = new List<string>();
            var maxNumber = _configuration.MaxNumber;

            //implement fizzbuzz logic
            for (int i = numberParsed; i <= maxNumber; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzbuzzStringList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    fizzbuzzStringList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    fizzbuzzStringList.Add("Buzz");
                }
                else
                {
                    fizzbuzzStringList.Add(i.ToString());
                }
            }

            var fizzbuzzList = new FizzbuzzList()
            {
                Number = maxNumber,
                StringList = fizzbuzzStringList
            };

            _fizzbuzzRepository.SaveFizzbuzzList(fizzbuzzList);

            return fizzbuzzStringList;
        }

        public int ParseNumber(string number)
        {
            if (number == null)
            {
                _log.Error("[ERROR]: The number is null");
                throw new ArgumentNullException("The number is null");
            }
            return Convert.ToInt32(number);
        }
    }
}
