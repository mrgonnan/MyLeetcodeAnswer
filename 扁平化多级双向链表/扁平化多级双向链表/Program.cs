using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扁平化多级双向链表
{/*您将获得一个双向链表，除了下一个和前一个指针之外，它还有一个子指针，可能指向单独的双向链表。这些子列表可能有一个或多个自己的子项，依此类推，生成多级数据结构，如下面的示例所示。

扁平化列表，使所有结点出现在单级双链表中。您将获得列表第一级的头部。

 

示例:

输入:
 1---2---3---4---5---6--NULL
         |
         7---8---9---10--NULL
             |
             11--12--NULL

输出:
1-2-3-7-8-11-12-9-10-4-5-6-NULL

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
        public Node prev;
        public Node next;
        public Node child;

        public Node() { }
        public Node(int _val, Node _prev, Node _next, Node _child)
        {
            val = _val;
            prev = _prev;
            next = _next;
            child = _child;
        }
    }
        public class Solution
        {
            public Node Flatten(Node head)
            {
            if (head==null)
            {
                return null;
            }
                Stack<Node> layer = new Stack<Node>();
                Node Result = head;

                while (head.next!=null||layer.Count!=0||head.child!=null)
                {
                    if (head.child != null)
                    {
                        if (head.next!=null)
                        {
                            Node temp = head.next;
                            layer.Push(temp);
                            
                        }

                        head.next = head.child;
                        head.child.prev = head;
                        head.child = null;
                        head = head.next;
                        continue;

                    }
                    if (head.next==null)
                    {
                        Node temp = layer.Pop();
                        head.next = temp;
                        temp.prev = head;

                    }
                  

                    head = head.next;

                }
                return Result;
            }
        }
    }

