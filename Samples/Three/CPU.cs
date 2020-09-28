using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.Three
{
    class CPU
    {
        public string CpuModel { get; set; }
        public double CpuSpeed { get; set; }

        public CPU(string model,double speed)
        {
            CpuModel = model;
            CpuSpeed = speed;
        }
    }
}
