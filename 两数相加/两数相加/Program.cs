using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两数相加
{/*给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。

如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。

您可以假设除了数字 0 之外，这两个数都不会以 0 开头。

示例：

输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
输出：7 -> 0 -> 8
原因：342 + 465 = 807
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode Result = new ListNode(0);
            ListNode R = Result;

            bool raise = false;

            while (l1!=null||l2!=null)
            {
                ListNode current = new ListNode(0);

                if (l1==null)
                {
                    if (raise)
                    {
                        current.val = (l2.val+1)%10;
                        Result.next = current;
                        Result = current;
                        if (l2.val+1>=10)
                        {
                            raise = true;
                        }
                        else
                        {
                            raise = false;
                        }
                        l2 = l2.next;
                    }
                    else
                    {
                        current.val = l2.val;
                        Result.next = current;
                        Result = current;
                        l2 = l2.next;
                    }
                   
                }else if (l2==null)
                {
                    if (raise)
                    {
                        current.val = (l1.val+1)%10;
                        Result.next = current;
                        Result = current;
                        if (l1.val+1>=10)
                        {
                            raise = true;
                        }
                        else
                        {
                            raise = false;
                        }
                        l1 = l1.next;
                    }
                    else
                    {
                        current.val = l1.val;
                        Result.next = current;
                        Result = current;
                        l1 = l1.next;
                    }
                   
                }
                else
                {
                    if (raise)
                    {
                        current.val = (l1.val + l2.val+1)%10;
                        Result.next = current;
                        Result = current;

                        if (l1.val+l2.val+1>=10)
                        {
                            raise = true;
                        }
                        else
                        {
                            raise = false;
                        }

                        l1 = l1.next;
                        l2 = l2.next;
                    }
                    else
                    {
                        current.val = (l1.val + l2.val) % 10;
                        Result.next = current;
                        Result = current;

                        if (l1.val + l2.val >= 10)
                        {
                            raise = true;
                        }
                        else
                        {
                            raise = false;
                        }
                        l1 = l1.next;
                        l2 = l2.next;
                    }
                }


            }
            if (raise)
            {
                ListNode current = new ListNode(1);
                Result.next = current;
            }
            if (R.next!=null)
            {
                return R.next;
            }
            else
            {
                return null;
            }
            
        }
    }
}
