using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 反转链表
{/*反转链表
反转一个单链表。

示例:

输入: 1->2->3->4->5->NULL
输出: 5->4->3->2->1->NULL
进阶:
你可以迭代或递归地反转链表。你能否用两种方法解决这道题？
    */
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            ListNode node = new ListNode(1);
            ListNode node1 = new ListNode(2);
            ListNode node2 = new ListNode(3);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(5);
            node.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            s.ReverseList(node);

        }
    }
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int value){
            val = value;
         }
    }
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head==null)
            {
                return null;
            }

            if (head.next==null)
            {
                return head;
            }

            ListNode temp=head.next;
            ListNode f = head;
            head = head.next.next;
            f.next = null;

            while (temp!=null)
            {

                    temp.next = f;
                    f = temp;
                if (head==null)
                {
                    temp = null;
                }
                else
                {
                    temp = head.next;
                }
                
                   
                
               

                if (head==null)
                {
                    return f;  
                }

                head.next = f;
                f = head;

                if (temp==null)
                {
                    head = null;
                }
                else
                {
                    head = temp.next;
                }
               
            }
            return f;
        }
    }

}
