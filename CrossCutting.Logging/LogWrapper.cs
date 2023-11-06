using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Logging
{
    public class LogWrapper : ILogWrapper
    {
        private readonly ILog _log;

        public LogWrapper(ILog log)
        {
            _log = log;
        }

        public void Debug(string message)
        {
            _log.Debug(message);
        }

        public void Error(string message)
        {
            _log.Error(message);
        }

        public void Info(string message)
        {
            _log.Info(message);
        }
    }
}
