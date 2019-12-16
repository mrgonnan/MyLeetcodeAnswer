using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移动零
{
    /*移动零
给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。

示例:

输入: [0,1,0,3,12]
输出: [1,3,12,0,0]
说明:

必须在原数组上操作，不能拷贝额外的数组。
尽量减少操作次数。
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            int slow = 0;

            for (int index = 0; index < nums.Length; index++)
            {//与快慢指针赋值再补零不同的是，这个方法通过交换满足了两种需求，十分优化
                if (nums[index] != 0)
                {
                    int temp = nums[slow];
                    nums[slow] = nums[index];
                    nums[index] = temp;
                    slow++;
                }
            }

        }
    }
}
