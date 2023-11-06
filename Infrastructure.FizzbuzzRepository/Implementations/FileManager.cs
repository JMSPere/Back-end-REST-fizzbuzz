using Infrastructure.FizzbuzzRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO.Abstractions;

namespace Infrastructure.FizzbuzzRepository.Implementations
{
    public class FileManager : IFileManager
    {
        private readonly ILog _log;
        private IFileSystem _fileSystem;

        public FileManager() { }

        public FileManager(IFileSystem fileSystem, ILog log)
        {
            _fileSystem = fileSystem;
            _log = log;
        }

        public int CreateFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public int WriteFile(string filePath, List<string> content)
        {
            throw new NotImplementedException();
        }
    }
}
