using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Three
{
    class GPU
    {
        public long MemorySize { get; set; }
        public string Vendor { get; set; }

        public GPU(long memory,string vendor)
        {
            MemorySize = memory;
            Vendor = vendor;
        }
    }
}
