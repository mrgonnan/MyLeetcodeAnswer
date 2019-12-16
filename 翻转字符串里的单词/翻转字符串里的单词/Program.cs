using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 翻转字符串里的单词
{
    /* 翻转字符串里的单词
给定一个字符串，逐个翻转字符串中的每个单词。

 

示例 1：

输入: "the sky is blue"
输出: "blue is sky the"
示例 2：

输入: "  hello world!  "
输出: "world! hello"
解释: 输入字符串可以在前面或者后面包含多余的空格，但是反转后的字符不能包括。
示例 3：

输入: "a good   example"
输出: "example good a"
解释: 如果两个单词间有多余的空格，将反转后单词间的空格减少到只含一个。
 

说明：

无空格字符构成一个单词。
输入字符串可以在前面或者后面包含多余的空格，但是反转后的字符不能包括。
如果两个单词间有多余的空格，将反转后单词间的空格减少到只含一个。
 

     */
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string ns = s.ReverseWords("the sky is blue");
            Console.Write(ns);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public string ReverseWords(string s)
        {
            if (s.Length==0)
            {
                return s;
            }
            Queue<char> queue = new Queue<char>();
            Stack<Queue<char>> stack = new Stack<Queue<char>>();
            int sL = 0;
            int blink = 0;

            for (int i=0;i<s.Length;i++)
            {
               
                if (s[i]==' ')
                {
                    if (queue.Count!=0)
                    {
                        stack.Push(queue);
                        queue = new Queue<char>();
                    }
                    blink++;
                }
                else
                {
                    queue.Enqueue(s[i]);
                    sL++;
                }

                if (i == s.Length - 1&&s[i]!=' ')
                {
                    
                    stack.Push(queue);
                }
            }

            if (blink==s.Length)
            {
                return "";
            }

            char[] nsc = new char[sL + stack.Count - 1];
            int index = 0;

            while (stack.Count!=0)
            {
                queue=stack.Pop();

                while (queue.Count!=0)
                {
                    char c = queue.Dequeue();
                    nsc[index] = c;
                    index++;
                }

                if (stack.Count!=0)
                {
                    nsc[index] = ' ';
                    index++;
                }
               
            }

            return new string(nsc);
        }
    }
}
