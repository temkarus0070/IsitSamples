using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples.First
{
    class Computer
    {
        private bool IsTurnOn
        {
            get; set;
        }

        public HDD Hdd
        {
            get; set;
        }
        public RAM Ram
        {
            get; set;
        }

        public CPU Cpu
        {
            get; set;
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
                Console.WriteLine("Я включился");
            }
            else
                TurnOff();
        }

        public void TurnOff()
        {
            if (IsTurnOn)
            {
                Console.WriteLine("Я выключился");
                IsTurnOn = false;
            }
        }

        public void CheckViruses()
        {
            Console.WriteLine("Всё хорошо");
        }

        public void PrintHddSize()
        {
            Console.WriteLine("Объём жесткого диска = {0}", Hdd.Size);
        }



    }
}
