using Infrastructure.FizzbuzzRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using CrossCutting.Configuration;
using Domain.Entities;

namespace Infrastructure.FizzbuzzRepository.Implementations
{
    public class FizzbuzzRepository : IFizzbuzzRepository
    {
        private readonly ILog _log;
        private IFileManager _fileManager;
        private IConfiguration _configuration;

        public FizzbuzzRepository() { }

        public FizzbuzzRepository(IConfiguration configuratoin, IFileManager fileManager, ILog log)
        {
            _configuration = configuratoin;
            _fileManager = fileManager;
            _log = log;
        }

        public List<string> SaveFizzbuzzList(FizzbuzzList fizzbuzzList)
        {
            throw new NotImplementedException();
        }
    }
}
