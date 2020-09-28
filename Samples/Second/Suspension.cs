using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Second
{
    class SatelitePlateWithSuspension:SatelitePlate
    {
        private SuspensionType P;

        public SatelitePlateWithSuspension(SuspensionType type):base(double d, string material, double price)
        {
            P = type;
        }

            public double Q()
            {

            }

        
    }
}
