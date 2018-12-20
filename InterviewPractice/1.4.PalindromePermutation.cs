using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    // Problem 1.4 Palindrome Permutation from Cracking the coding interview
    public class PalindromePermutation
    {

        public bool IsPalindrome (string str)
        {
            int[] arr = new int[26];
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    count++;
                    int index = str[i] - 'a';
                    arr[index] = arr[index] + 1;
                }
            }

            int odd = (count % 2 > 0) ? 1 : 0;

            for (int i=0; i< 26; i++)
            {
                if (arr[i] % 2 > 0)
                {
                    if(odd>0)
                        odd--;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
