using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    // Problem 1.9 String Rotation
    
    public class StringRotation
    {

        public bool SubString (string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            for(int i =0; i<s1.Length; i++)
            {
                if(s1[0] == s2[i])
                {
                    if(checkRotation(s1,s2,i))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool checkRotation (string s1, string s2, int i)
        {
            int index = 0;
            while (i < s2.Length)
            {
                if (s1[index++] != s2[i++])
                    return false;
            }
            i = 0;
            while (index < s1.Length)
            {
                if (s1[index++] != s2[i++])
                    return false;
            }
            return true;
        }
    }
}
