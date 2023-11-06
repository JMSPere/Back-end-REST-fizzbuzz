using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FizzbuzzRepository.Contracts
{
    public interface IFileManager
    {
        int CreateFile(string filePath);

        int WriteFile(string filePath, List<string> content);
    }
}
