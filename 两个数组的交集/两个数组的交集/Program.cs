﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个数组的交集
{/*两个数组的交集
给定两个数组，编写一个函数来计算它们的交集。

示例 1:

输入: nums1 = [1,2,2,1], nums2 = [2,2]
输出: [2]
示例 2:

输入: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
输出: [9,4]
说明:

输出结果中的每个元素一定是唯一的。
我们可以不考虑输出结果的顺序。
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> hs = new HashSet<int>();
            List<int> list = new List<int>();

            foreach (int i in nums1)
            {
                hs.Add(i);
            }

            foreach (int j in nums2)
            {
                if (hs.Contains(j))
                {
                    list.Add(j);
                    hs.Remove(j);
                }
            }

            int[] R = new int[list.Count];

            for (int index = 0; index < R.Length; index++)
            {
                R[index] = list[index];
            }

            return R;
        }
    }
}
