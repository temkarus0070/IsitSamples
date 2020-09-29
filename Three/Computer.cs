using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three
{
    public class Computer
    {
        public bool IsTurnOn
        {
             get;  set;
        }

        public HDD Hdd
        {
            get;  set;
        }

        public int VirusesCount
        {
            get;set;
        }
        public RAM Ram {get;  set;}

        public CPU Cpu
        {
             get;  set;
        }

        public GPU Gpu
        {
            get; set;
        }

        public void TurnOn()
        {
            if (!IsTurnOn)
            {
                IsTurnOn = true;
               
            }
            else
                TurnOff();
        }

        public void TurnOff()
        {
            if (IsTurnOn)
            {
              
                IsTurnOn = false;
            }
        }

        public void CheckViruses()
        {
            VirusesCount = 0;
        }

        public string GetHddSize()
        {
            return String.Format("Объём жесткого диска = {0}", Hdd.Size);
        }



    }
}
