using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反转字符串中的单词_III
{
    /*反转字符串中的单词 III
给定一个字符串，你需要反转字符串中每个单词的字符顺序，同时仍保留空格和单词的初始顺序。

示例 1:

输入: "Let's take LeetCode contest"
输出: "s'teL ekat edoCteeL tsetnoc" 
注意：在字符串中，每个单词由单个空格分隔，并且字符串中不会有任何额外的空格。
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string ReverseWords(string s)
        {
            int space = 0;
            char[] sc = s.ToArray();

            for (int i = 0,j=0; i < s.Length&&j<s.Length;j++)
            {
                if (sc[j]==' ')
                {
                    space = j;
                    j--;

                    while (i<j)
                    {
                        char c = s[i];
                        sc[i] = s[j];
                        sc[j] = c;
                        i++;
                        j--;
                    }
                    i = space + 1;
                    j = space + 1;
                }
                if (j==s.Length-1)
                {
                    while (i < j)
                    {
                        char c = s[i];
                        sc[i] = s[j];
                        sc[j] = c;
                        i++;
                        j--;
                    }

                    j = s.Length - 1;
                }
            }
            return new string(sc);
        }
    }
}
