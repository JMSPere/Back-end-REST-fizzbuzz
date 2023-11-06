using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Logging
{
    public interface ILogWrapper
    {
        void Debug(string message);
        void Error(string message);
        void Info(string message);
    }
}
