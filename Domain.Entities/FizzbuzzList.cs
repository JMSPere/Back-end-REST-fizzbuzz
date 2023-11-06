using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [DataContract]
    public class FizzbuzzList
    {
        [IgnoreDataMember]
        public int Number { get; set; }

        [DataMember]
        public List<string> StringList { get; set; }
    }
}
