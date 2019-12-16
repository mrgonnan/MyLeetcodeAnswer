using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文链表
{/*回文链表
请判断一个链表是否为回文链表。

示例 1:

输入: 1->2
输出: false
示例 2:

输入: 1->2->2->1
输出: true
进阶：
你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
 
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
        public bool IsPalindrome(ListNode head)
        {
            if (head==null)
            {
                return true;
            }

            if (head.next==null)
            {
                return true;
            }
            if (head.next.next==null)
            {
                if (head.val==head.next.val)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            ListNode fast = head;
            ListNode slow = head;
            ListNode temp = head;
            ListNode connect = head;
            bool first = true;
            bool forbet = true;

            while (connect!=null)
            {
                if (first)
                {
                    fast = fast.next.next;
                    slow = slow.next;
                    connect = connect.next;
                    first = false;
                }
                else
                {
                    if (fast.next!=null)
                    {
                        if (fast.next.next != null)
                        {
                            fast = fast.next.next;
                            //开始前半面指针逆转
                            connect = slow.next;
                            slow.next = temp;
                            temp = slow;
                            slow = connect;
                        }
                        else
                        {
                            //完成前半面指向逆转
                            if (forbet)
                            {
                                connect = slow.next;
                                slow.next = temp;
                                forbet = false;
                            }
                            else
                            {
                                if (slow.val==connect.val)
                                {
                                    slow = slow.next;
                                    connect = connect.next;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                           

                        }
                    }
                    else
                    {
                        if (forbet)
                        {
                            connect = slow.next;
                            forbet = false;
                        }
                        else
                        {
                            if (connect.val==temp.val)
                            {
                                connect = connect.next;
                                temp = temp.next;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    
                }
            }

            return true;
        }
    }
}
