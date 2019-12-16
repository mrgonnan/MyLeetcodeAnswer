using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 环形链表
{/*环形链表
给定一个链表，判断链表中是否有环。

为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

 

示例 1：

输入：head = [3,2,0,-4], pos = 1
输出：true
解释：链表中有一个环，其尾部连接到第二个节点。


示例 2：

输入：head = [1,2], pos = 0
输出：true
解释：链表中有一个环，其尾部连接到第一个节点。


示例 3：

输入：head = [1], pos = -1
输出：false
解释：链表中没有环。

    */

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ListNode
    {
     public int val;
     public ListNode next;
    public ListNode(int x)
        {
            val = x;
            next = null;
                 }
  }
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            if (head==null)
            {
                return false;
            }

            if (head.next==null)
            {
                return false;
            }

            while (fast.next!=slow)
            {

                for (int index = 0; index < 2; index++)
                {
                    if (fast.next==null)
                    {
                        return false;
                    }

                    fast = fast.next;
                }

                slow = slow.next;

            }

            return true;
        }
    }
}
