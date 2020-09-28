using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Three
{
    class SatelitePlateWithSuspension:SatelitePlate
    {
        private SuspensionType P;

        public SatelitePlateWithSuspension(SuspensionType type,double d,string material,double price):base(d, material, price)
        {
            P = type;
        }

            public void Q()
            {

            }

        
    }
}
