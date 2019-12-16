using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 杨辉三角_II
{
    /*杨辉三角 II
给定一个非负索引 k，其中 k ≤ 33，返回杨辉三角的第 k 行。



在杨辉三角中，每个数是它左上方和右上方的数的和。

示例:

输入: 3
输出: [1,3,3,1]
进阶：

你可以优化你的算法到 O(k) 空间复杂度吗？
     */
    class Program
    {
        static void Main(string[] args)
        {
            Solution_1 s = new Solution_1();
            IList<int> list = new List<int>();
            list = s.GetRow(10);

            for (int index = 0; index < list.Count; index++)
            {
                Console.Write(list[index]);
                Console.Write(",");
            }
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex==0)
            {
                return new List<int> { 1};
            }

            if (rowIndex==1)
            {
                return new List<int> { 1,1};
            }

            IList<int> list = new List<int>();
            IList<int> up = GetRow(rowIndex - 1);

            for (int index = 0; index < rowIndex+1; index++)
            {
                if (index==0||index==rowIndex)
                {
                    list.Add(1);
                }
                else
                {
                    list.Add(up[index-1]+up[index]);
                }               
            }
            return list;
        }
    }
    /*空间复杂度为k的算法，具体为2k+1
     */ 
    public class Solution_1
    {
        public IList<int> GetRow(int rowIndex)
        {
            if (rowIndex == 0)
            {
                return new List<int> { 1 };
            }

            if (rowIndex == 1)
            {
                return new List<int> { 1, 1 };
            }

            IList<int> list = new List<int>();
            IList<int> up = new List<int>();

            int length = 2;

            while (rowIndex>1)
            {
                for (int index = 0; index < length; index++)
                {
                    if (length>=3)
                    {
                        if (index==0||index==length-1)
                        {
                            list.Add(1);
                        }
                        else
                        {
                            list.Add(up[index-1]+up[index]);
                        }
                    }
                    else
                    {
                        up.Add(1);
                    }
                   
                }
                if (length>=3)
                {
                    up.Clear();

                    for (int index = 0; index < list.Count; index++)
                    {
                        up.Add(list[index]);
                    }

                    list.Clear();
                }
                

                length++;
                rowIndex--;
            }

            return up;
        }
        }
    }
