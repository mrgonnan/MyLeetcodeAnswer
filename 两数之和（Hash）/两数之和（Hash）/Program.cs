using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两数之和_Hash_
{/*两数之和
给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。

你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

示例:

给定 nums = [2, 7, 11, 15], target = 9

因为 nums[0] + nums[1] = 2 + 7 = 9
所以返回 [0, 1]
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] R = new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int index = 0; index < nums.Length; index++)
            {
                if (dic.ContainsKey(target-nums[index]))
                {
                    R[0] = dic[target - nums[index]];
                    R[1] = index;
                    return R;
                }
                else
                {
                    if (!dic.ContainsKey(nums[index]))
                    {
                        dic.Add(nums[index], index);
                    }
                    
                }
                
            }
            return null;

        }
    }
}
