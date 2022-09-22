using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4]
          {
               { 1,2,3,4},
               {5,6,7,8 },
               {9,10,11,12 }
          };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}]= {arr[i, j]}  ");
                }
                Console.WriteLine();
            }

        }
    }
   
}
     

           
           
        
    

