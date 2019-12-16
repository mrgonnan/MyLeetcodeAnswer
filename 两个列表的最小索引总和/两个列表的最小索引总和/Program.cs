using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个列表的最小索引总和
{/*两个列表的最小索引总和
假设Andy和Doris想在晚餐时选择一家餐厅，并且他们都有一个表示最喜爱餐厅的列表，每个餐厅的名字用字符串表示。

你需要帮助他们用最少的索引和找出他们共同喜爱的餐厅。 如果答案不止一个，则输出所有答案并且不考虑顺序。 你可以假设总是存在一个答案。

示例 1:

输入:
["Shogun", "Tapioca Express", "Burger King", "KFC"]
["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"]
输出: ["Shogun"]
解释: 他们唯一共同喜爱的餐厅是“Shogun”。
示例 2:

输入:
["Shogun", "Tapioca Express", "Burger King", "KFC"]
["KFC", "Shogun", "Burger King"]
输出: ["Shogun"]
解释: 他们共同喜爱且具有最小索引和的餐厅是“Shogun”，它有最小的索引和1(0+1)。
提示:

两个列表的长度范围都在 [1, 1000]内。
两个列表中的字符串的长度将在[1，30]的范围内。
下标从0开始，到列表的长度减1。
两个列表都没有重复的元素。
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> list = new List<string>(); 
            int index = 0;
            int max = int.MaxValue;
            int index1= 0;
            int index2 = 0;

            while (index<list1.Length+list2.Length)
            {
                if (index1<list1.Length)
                {
                    if (!dic.ContainsKey(list1[index1]))
                    {
                        dic.Add(list1[index1],index1);
                    }

                    index1++;
                }
                else
                {
                    if (dic.ContainsKey(list2[index2]))
                    {
                        if (dic[list2[index2]]+index2<max)
                        {
                            max = dic[list2[index2]] + index2;

                            if (list.Count!=0)
                            {
                                list.Clear();
                            }

                            list.Add(list2[index2]);

                        }
                        else if (dic[list2[index2]] + index2 == max)
                        {
                            list.Add(list2[index2]);
                        }
                    }
                    else
                    {
                        dic.Add(list2[index2],index2);
                    }
                    index2++;
                }

                index++;
            }

            string[] s = new string[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                s[i] = list[i];
            }

            return s;
        }
    }
}
