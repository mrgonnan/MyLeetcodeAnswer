using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 旋转链表
{/*旋转链表
给定一个链表，旋转链表，将链表每个节点向右移动 k 个位置，其中 k 是非负数。

示例 1:

输入: 1->2->3->4->5->NULL, k = 2
输出: 4->5->1->2->3->NULL
解释:
向右旋转 1 步: 5->1->2->3->4->NULL
向右旋转 2 步: 4->5->1->2->3->NULL
示例 2:

输入: 0->1->2->NULL, k = 4
输出: 2->0->1->NULL
解释:
向右旋转 1 步: 2->0->1->NULL
向右旋转 2 步: 1->2->0->NULL
向右旋转 3 步: 0->1->2->NULL
向右旋转 4 步: 2->0->1->NULL
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
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head==null)
            {
                return null;
            }
            int length = 0;

            ListNode first = head;

            while (head!=null)
            {
                length++;

                if (head.next==null)
                {
                    head.next = first;
                    break;
                }

                head = head.next;
                
            }

            int index = length - k%length;
            
            for (int i = 0; i < index; i++)
            {

                first = first.next;
            }

            ListNode near = first;

            for (int j = 0; j < length-1; j++)
            {
                near = near.next;
            }

            near.next = null;

            return first;



        }
    }
}
