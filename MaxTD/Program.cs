﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxTD
{
    internal class Program
    {
        public static void maxelement(int no_of_rows, int[][] arr)
        {
            int i = 0;
            int max = 0;

            int[] result = new int[no_of_rows];

            while (i < no_of_rows)

            {

                for (int j = 0;

                         j < arr[i].Length; j++)

                {

                    if (arr[i][j] > max)

                    {

                        max = arr[i][j];

                    }

                }

                result[i] = max;

                max = 0;

                i++;


            }
            printArray(result);
        }
            
        private static void printArray(int[] result)
        {

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
        public static void Main(string[] args)
        {

            int[][] arr = new int[][]
            {            
                new int[] {3, 4, 1, 8},

                 new int[] {1, 4, 9, 11},

                 new int[] {76, 34, 21, 1},
            };
                 maxelement(3, arr);
        }
    }
}
   

     

           
           
        
    

