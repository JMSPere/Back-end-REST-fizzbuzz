using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FizzbuzzRepository.Contracts
{
    public interface IFizzbuzzRepository
    {
        List<string> SaveFizzbuzzList(FizzbuzzList fizzbuzzList);
    }
}
