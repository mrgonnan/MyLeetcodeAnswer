using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 环形链表_II
{/*环形链表 II
给定一个链表，返回链表开始入环的第一个节点。 如果链表无环，则返回 null。

为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

说明：不允许修改给定的链表。

 

示例 1：

输入：head = [3,2,0,-4], pos = 1
输出：tail connects to node index 1
解释：链表中有一个环，其尾部连接到第二个节点。


示例 2：

输入：head = [1,2], pos = 0
输出：tail connects to node index 0
解释：链表中有一个环，其尾部连接到第一个节点。


示例 3：

输入：head = [1], pos = -1
输出：no cycle
解释：链表中没有环。

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
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }

    public class Solution
    {
        public ListNode DetectCycle(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();

            while (head!=null)
            {
                
                for (int index = 0; index < list.Count; index++)
                {
                    if (head==list[index])
                    {
                        return head;
                    }
                }
                list.Add(head);
                head = head.next;
            }

            return null;
        }
    }
}
