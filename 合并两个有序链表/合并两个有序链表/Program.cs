using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 合并两个有序链表
{/* 合并两个有序链表
将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：

输入：1->2->4, 1->3->4
输出：1->1->2->3->4->4
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }
 
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1==null)
            {
                return l2;
            }

            if (l2==null)
            {
                return l1;
            }

            ListNode l1first = l1;
            ListNode l2first = l2;
            ListNode R = l1;

            if (l1first.val>l2first.val)
            {
                R = l2first;
            }

            ListNode currentbase = new ListNode(0);

            while (l1first!=null||l2first!=null)
            {
                if (l1first==null)
                {
                    currentbase.next = l2first;
                    return R;
                }

                if (l2first==null)
                {
                    currentbase.next = l1first;
                    return R;
                }

                if (l1first.val>l2first.val)
                {
                    currentbase.next = l2first;
                    currentbase = l2first;
                    l2first = l2first.next;
                }
                else
                {
                    currentbase.next = l1first;
                    currentbase = l1first;
                    l1first = l1first.next;
                }


            }
            return R;
        }
    }
}
