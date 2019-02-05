using InterviewPractice.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInteriewConsoleProject
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] arr = new int[] { 1, 3, 5, 7, 9 };
            PrintArrayRecursive p = new PrintArrayRecursive();
            p.PrintArray(arr);
        }
    }
}
