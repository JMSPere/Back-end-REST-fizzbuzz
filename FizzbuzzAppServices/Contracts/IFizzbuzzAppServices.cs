using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzbuzzAppServices.Contracts
{
    public interface IFizzbuzzAppServices
    {
        int ParseNumber(string number);
        List<string> GetFizzbuzz(string number);
    }
}
