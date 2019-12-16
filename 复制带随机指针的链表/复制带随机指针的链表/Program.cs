using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 复制带随机指针的链表
{/*复制带随机指针的链表
给定一个链表，每个节点包含一个额外增加的随机指针，该指针可以指向链表中的任何节点或空节点。

要求返回这个链表的深拷贝。 

 

示例：



输入：
{"$id":"1","next":{"$id":"2","next":null,"random":{"$ref":"2"},"val":2},"random":{"$ref":"2"},"val":1}

解释：
节点 1 的值是 1，它的下一个指针和随机指针都指向节点 2 。
节点 2 的值是 2，它的下一个指针指向 null，随机指针指向它自己。
 

提示：

你必须返回给定头的拷贝作为对克隆列表的引用。
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node() { }
        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head==null)
            {
                return null;
            }
            Node index = head;
            Node copyHead = new Node();
            Node copyIndex = copyHead;
            bool headChange = false;

            while (head!=null)
            {
                Node temp = new Node();
                temp.val = head.val;
                copyHead.next = temp;
                copyHead = temp;
                head = head.next;
            }

            copyIndex = copyIndex.next;
            Node copyfirst = copyIndex;
            Node first = index;
            Node A = first;
            Node B = copyIndex;

            while (first!=null)
            {
                if (first.random!=null)
                {
                    if (first.random==index)
                    {
                        copyfirst.random = copyIndex;
                        copyfirst = copyfirst.next;
                        first = first.next;
                        copyIndex = B;
                        index = A;
                    }
                    else
                    {
                        index = index.next;
                        copyIndex = copyIndex.next;
                    }
                }
                else
                {
                    first = first.next;
                    copyfirst = copyfirst.next;
                }
            }

            return B;
        }
    }
}
