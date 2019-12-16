using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 快乐数
{
    class Program
    {/*快乐数
编写一个算法来判断一个数是不是“快乐数”。

一个“快乐数”定义为：对于一个正整数，每一次将该数替换为它每个位置上的数字的平方和，然后重复这个过程直到这个数变为 1，也可能是无限循环但始终变不到 1。如果可以变为 1，那么这个数就是快乐数。

示例: 

输入: 19
输出: true
解释: 
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
        */
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();

            while (n!=1)
            {
                int temp = 0;

                while (n > 0)
                {
                    temp += (n % 10) * (n % 10);
                    n = n / 10;
                }

                if (temp == 1)
                {
                    return true;
                }

                if (hs.Contains(temp))
                {
                    return false;
                }
                else
                {
                    hs.Add(temp);
                }

                n = temp;
            }

            return true;

        }
    }
}
