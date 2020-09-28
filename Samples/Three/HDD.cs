using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Three
{
    class HDD
    {
        public long Size { get; set; }
        public string Vendor { get; set; }

        public HDD(long size,string vendor)
        {
            Size = size;
            Vendor = vendor;
        }
    }
}
