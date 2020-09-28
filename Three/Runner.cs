using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Three
{
   public class Runner
    {
        public static void Run()
        {

            Computer computer = new Computer();
            Console.WriteLine("Если хотите выйти введите 0,чтобы продолжить введите размер жесткого диска, производителя диска, производителя процессора, тактовую частоту, кол-во памяти видеокарты, производителя видеокарты,кол-во оперативной памяти и её производителя");
            try
            {
                var textInput =Console.ReadLine();
                if (textInput == "0")
                    return;
                var userInput = textInput.Split(new[] { ' ' });

                long size = long.Parse(userInput[0]);
                string hddVendor = userInput[1];
                string cpuVendor = userInput[2];
                var cpuRate = double.Parse(userInput[3]);
                var gpuMemory = long.Parse(userInput[4]);
                var gpuVendor = userInput[5];
                var ramSize = long.Parse(userInput[6]);
                var ramVendor = userInput[7];
                computer = new Computer() { Hdd = new HDD(size, hddVendor), Cpu = new CPU(cpuVendor, cpuRate), Gpu = new GPU(gpuMemory, gpuVendor), Ram = new RAM(ramSize, ramVendor) };
            }
            catch (Exception ex)
            {
                throw new ArgumentException();
            }
            var input = 1;
            do
            {
                Console.WriteLine("0. завершить программу \n 1. включить компьютер \n 2. выключить \n  3. проверить на вирусы \n  4. вывести размер винчестера");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        return;
                    case 1:
                        computer.TurnOn();
                        break;
                    case 2:
                        computer.TurnOff();
                        break;
                    case 3:
                        computer.CheckViruses();
                        break;
                    case 4:
                        computer.PrintHddSize();
                        break;



                }
                Console.WriteLine();
            }
            while (input != 0);
        }
    }
}
