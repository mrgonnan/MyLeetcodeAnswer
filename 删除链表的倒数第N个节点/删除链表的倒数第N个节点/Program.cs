using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 删除链表的倒数第N个节点
{/*删除链表的倒数第N个节点
给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。

示例：

给定一个链表: 1->2->3->4->5, 和 n = 2.

当删除了倒数第二个节点后，链表变为 1->2->3->5.
说明：

给定的 n 保证是有效的。

进阶：

你能尝试使用一趟扫描实现吗？
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next==null)
            {
                head = null;
                return head;
            }

            if (head.next.next==null)
            {
                if (n==1)
                {
                    head.next = null;
                }
                if (n==2)
                {
                    head = head.next;
                }
                return head;
            }

            ListNode fast = head;
            ListNode slow = head;
            ListNode connect = head;
            ListNode tail = head;
            ListNode sta = head;
            int k = n-2;
            int i = 1;

            if (n<2)
            {
                while (head!=null)
                {
                    if (head.next==null)
                    {
                        tail.next = null;
                        return sta;

                    }

                    if (i<=0)
                    {
                        tail = tail.next;
                    }
                    
                    head = head.next;
                    i--;
                }
            }
            while (fast!=null)
            {
                if (fast.next==null)
                {
                    if (k<=0&&n<=0)
                    {
                        slow.next = connect;
                        return sta;
                    }
                    else
                    {
                        sta = sta.next;
                        return sta;
                    }
                   
                }
                if (k<=0)
                {
                    connect = connect.next;
                }
                if (n<=0)
                {
                    slow = slow.next;
                }
                fast = fast.next;
                n--;
                k--;
            }
            return sta;
        }
    }
}
