using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Others
{
    public class PrintArrayRecursive
    {

        /*
         * If an array is given 1, 2, 3, 4, 5
            Print
            1 2 3 4 5
            5 4 3 2 1
        */

        public void PrintArray(int []arr, int currIndex)
        {   
            Console.Write(arr[currIndex]);
            if (currIndex==arr.Length-1)
                Console.WriteLine();                
            else
                PrintArray(arr, currIndex+1);

            Console.Write(arr[currIndex]);
        }
        public void PrintArray (int[] arr)
        {
            PrintArray(arr, 0);
        }
    }
}
