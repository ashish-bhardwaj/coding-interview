using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.DailyCodingProblem
{
    /* Problem Statement:
     * Good morning! Here's your coding interview problem for today.
        This problem was asked by Google.
        Suppose we represent our file system by a string in the following manner:
        The string "dir\n\tsubdir1\n\tsubdir2\n\t\tfile.ext" represents:
        dir
            subdir1
            subdir2
                file.ext
        The directory dir contains an empty sub-directory subdir1 and a sub-directory subdir2 containing a file file.ext.
        The string "dir\n\tsubdir1\n\t\tfile1.ext\n\t\tsubsubdir1\n\tsubdir2\n\t\tsubsubdir2\n\t\t\tfile2.ext" represents:
        dir
            subdir1
                file1.ext
                subsubdir1
            subdir2
                subsubdir2
                    file2.ext
        The directory dir contains two sub-directories subdir1 and subdir2. subdir1 contains a file file1.ext and an empty second-level sub-directory subsubdir1. subdir2 contains a second-level sub-directory subsubdir2 containing a file file2.ext.
        We are interested in finding the longest (number of characters) absolute path to a file within our file system. For example, in the second example above, the longest absolute path is "dir/subdir2/subsubdir2/file2.ext", and its length is 32 (not including the double quotes).
        Given a string representing the file system in the above format, return the length of the longest absolute path to a file in the abstracted file system. If there is no file in the system, return 0.
        Note:
        The name of a file contains at least a period and an extension.
        The name of a directory or sub-directory will not contain a period.
     */
    
    /* Solution complexity:
     * Time complextiy: O(n)
     * Space complexty : O(n)
     * */

    /* Solution overview:
     * Iterate from the beginning and keep a track of the folders/file names
     * Keep a track only of the latest ongoing folder during parsing
     * The folder is tracked in dirs list.
     * When we find a file name we check its the length of dirs list and length of file + number of \ used to prepare the file path.
     * This is checked with maxlen and stored in it if bigger.
     * */
    public class Problem17
    {
        public Problem17() { }

        public int GetAbsolutePath(string str)
        {
            int maxLen = 0;
            int currTabs = 0;
            bool isFile = false;
            StringBuilder sb = new StringBuilder();
            List<string> dirs = new List<string>();

            for (int i=0; i<str.Length; i++)
            {
                if (str[i] != '\n' && str[i] != '\t')
                    sb.Append(str[i]);

                if (str[i] == '.')
                    isFile = true;
                else if (str[i] == '\t')
                    currTabs++;
                else if(str[i] == '\n' || i == str.Length-1)
                {
                    string name = sb.ToString();
                    if(!isFile)
                    {
                        int len = dirs.Count;
                        if (len < currTabs)
                            dirs.Add(name);
                        else if (len > currTabs)
                        {
                            for (int j = len-1; j >= currTabs; j--)
                                dirs.RemoveAt(j);

                            dirs.Add(name);
                        }
                        else if (len == currTabs)
                        {
                            if(dirs.Count == currTabs+1)
                                dirs[currTabs] = name;
                            else
                                dirs.Add(name);
                        }
                    }
                    else
                    {
                        int absPath = name.Length + GetDirLen(dirs) + 1;
                        if (maxLen < absPath)
                            maxLen = absPath;
                    }

                    sb = new StringBuilder();
                    isFile = false;
                    currTabs = 0;
                }
            }
            return maxLen;
        }

        private int GetDirLen(List<string> dirs)
        {
            int len = 0;
            foreach (string s in dirs)
                len += s.Length;

            // Adding lenght for required \s to prepare absolute path.
            len += dirs.Count-1;

            return len;
        }
    }
}