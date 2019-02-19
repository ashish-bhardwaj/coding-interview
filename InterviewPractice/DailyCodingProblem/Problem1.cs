using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.DailyCodingProblem
{
    /* Problem Statement
        Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

        For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

        Bonus: Can you do this in one pass?
    */

    /* Time and Space complexity
     * Time complexity : O(n)
     * Space Complextiy: O(n)
     * */

    /* Solution Overview
     * Iterate through the numbers in array, get the difference of k and number in iteration in array.
     * Store the diff in hash
     * for each number if it exists in the diff-hashset as required for sum for another number.
     * */
    public class Problem1
    {
        public bool NumbersHaveSum (int []arr, int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            for (int i=0; i<arr.Length; i++)
            {
                if (hs.Contains(arr[i]))
                    return true;
                else
                {
                    int diff = sum - arr[i];
                    hs.Add(diff);
                }
            }
            return false;
        }
    }
}
