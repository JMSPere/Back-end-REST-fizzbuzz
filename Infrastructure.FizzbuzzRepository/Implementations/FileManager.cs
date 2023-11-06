using Infrastructure.FizzbuzzRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO.Abstractions;
using System.Runtime.Remoting.Messaging;

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
            try
            {
                bool fileExists = _fileSystem.File.Exists(filePath);

                if (!fileExists)
                {
                    _fileSystem.File.Create(filePath).Close();
                    _log.Info("File created successfully!");
                    return 1;
                }
                throw new Exception("File already exists!");
            }
            catch (Exception ex)
            {
                _log.Error("File not created, returned error!");
                throw ex;
            }
        }

        public int WriteFile(string filePath, List<string> content)
        {
            try
            {
                _fileSystem.File.AppendAllLines(filePath, content);
                _log.Info("File created successfully!");
                return 1;
            }
            catch (Exception ex)
            {
                _log.Error("File not created, returned error!");
                throw ex;
            }
        }
    }
}
