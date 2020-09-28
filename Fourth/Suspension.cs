using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fourth
{
    class SatelitePlateWithSuspension : SatelitePlate
    {
        private SuspensionType P;

        public SatelitePlateWithSuspension(SuspensionType type, double d, string material, double price) : base(d, material, price)
        {
            P = type;
        }

        public override double Q()
        {
            switch(P)
            {
                case SuspensionType.азимутальный:
                    return base.Q();
                case SuspensionType.полярный:
                    return base.Q() * 2;
                default:
                    return base.Q() * 2.5;
            }
        }


    }
}
