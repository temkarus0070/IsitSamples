using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace First
{
    class FirstTask
    {
        public static int GetMaxFromMin(int[,] array)
        {
            if (array.Length > 0)
            {

                int max = int.MinValue;
   
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int min = int.MaxValue;
 
               
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        if (array[i, j] < min)
                        {
                            min = array[i, j];
                           
                        }
                    }
                    if (min > max)
                        max = min;

                }
                return max;
            }
            else
            {
                throw new ArgumentException();
                return -1;
            }
        }
    }
}
