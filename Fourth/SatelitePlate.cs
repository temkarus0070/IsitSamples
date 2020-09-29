using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fourth
{
    public class SatelitePlate
    {
        private double D;

        private string Material;

        public double Price;


        public SatelitePlate(double d, string material, double price)
        {
            D = d;
            Material = material;
            Price = price;
        }

        public virtual double Q()
        {
            return D / Price;
        }

        public double GetQ()
        {
            return Q();
        }
    }
}
