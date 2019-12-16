using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 移除链表元素
{
    /*移除链表元素
删除链表中等于给定值 val 的所有节点。

示例:

输入: 1->2->6->3->4->5->6, val = 6
输出: 1->2->3->4->5
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
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head==null)
            {
                return null;
            }
            if (head.next==null)
            {
                if (head.val==val)
                {
                    head = null;
                    return head;
                }
                else
                {
                    return head;
                }
            }
            ListNode f = head;
            ListNode s = head;
            bool one = true;

            if (head.next.next==null)
            {
                while (head!=null)
                {
                    if (f==head)
                    {
                        if (head.val==val)
                        {
                            f = f.next;
                        }
                    }
                    else
                    {
                        if (head.val==val)
                        {
                            f.next = null;
                        }
                    }

                    head = head.next;

                }

                return f;
            }

                
            
            ListNode index = head;
            ListNode first = head;
            ListNode fast = head.next;
            ListNode connect = head;


            //已经解决一个和两个链表的头尾删除操作，下面编辑3个或以上的链表的删除
            //思路是设置慢快标记指针，拼接链表，难点是首与尾部要考虑到；

            while (index!=null)
            {
                if (first==index)
                {
                    if (index.val==val)
                    {
                        first = first.next;
                        connect = connect.next;
                    }
                }
                else
                {
                    if (index.val==val)
                    {
                        connect.next = fast;
                    }
                    else
                    {
                        connect = connect.next;
                    }
                }

                index = index.next;

                if (fast!=null)
                {
                    fast = fast.next;
                }
                else
                {
                    fast = null;
                }
                

            }

            return first;

        }
    }
}
