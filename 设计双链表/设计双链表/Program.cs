using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计双链表
{//之前设计的单链表改装后的双链表，每个节点多了一个可以找到前一个节点的引用变量Pre；
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyLinkedNode
    {

        public int val;
        public MyLinkedNode Next,Pre;
        public int index;
        public MyLinkedNode(int x)
        {
            val = x;
        }

    }
    public class MyLinkedList
    {

        List<MyLinkedNode> list;

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            list = new List<MyLinkedNode>();

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (list.Count == 0)
            {
                return -1;
            }
            if (index < 0 || index >= list.Count)
            {
                return -1;
            }

            return list[index].val;

        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);

            if (list.Count == 0)
            {
                list.Add(node);
            }
            else
            {
                list.Add(node);

                for (int index = list.Count - 1; index >= 0; index--)
                {
                    if (index == 0)
                    {
                        list[index] = node;
                        break;
                    }
                    list[index] = list[index - 1];
                }

                node.Next = list[1];
                list[1].Pre = node;
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);
            list.Add(node);

            if (list.Count > 1)
            {
                list[list.Count - 2].Next = node;
                node.Pre = list[list.Count-2];
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);

            if (index > list.Count)
            {
                return;
            }

            if (index == list.Count)
            {

                list.Add(node);

                if (list.Count > 1)
                {
                    list[list.Count - 2].Next = node;
                    node.Pre = list[list.Count-2];
                }
                return;
            }
            if (index <= 0)
            {

                if (list.Count == 0)
                {
                    list.Add(node);
                }
                else
                {
                    list.Add(node);

                    for (int i = list.Count - 1; i >= 0; i--)
                    {
                        if (i == 0)
                        {
                            list[i] = node;
                            break;
                        }
                        list[i] = list[i - 1];
                    }

                    node.Next = list[1];
                    list[1].Pre = node;
                }
                return;
            }

            list.Add(node);

            for (int i = list.Count - 1; i >= index; i--)
            {
                if (i == index)
                {
                    list[i] = node;
                    break;
                }

                list[i] = list[i - 1];

            }

            list[index - 1].Next = node;
            node.Pre = list[index - 1];
            node.Next = list[index + 1];
            list[index + 1].Pre = node;


        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {

            if (list.Count == 0)
            {
                return;
            }

            if (index < 0 || index >= list.Count)
            {
                return;
            }

            if (index == 0)
            {
                list.RemoveAt(index);

                if (list.Count!=0)
                {
                    list[0].Pre = null;
                }

                
                return;
            }


            if (index == list.Count - 1)
            {
                list.RemoveAt(index);
                list[list.Count - 1].Next = null;
                return;
            }

            list.RemoveAt(index);
            list[index - 1].Next = list[index];
            list[index].Pre = list[index-1];

        }
    }

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
}
