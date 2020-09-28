using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.First
{
    class RAM
    {
        public long Size { get; set; }
        public string Vendor { get; set; }


        public RAM(long size,string vendor)
        {
            Size = size;
            Vendor = vendor;
        }
    }
}
