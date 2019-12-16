using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计链表
{
    /*设计链表
设计链表的实现。您可以选择使用单链表或双链表。单链表中的节点应该具有两个属性：val 和 next。val 是当前节点的值，next 是指向下一个节点的指针/引用。如果要使用双向链表，则还需要一个属性 prev 以指示链表中的上一个节点。假设链表中的所有节点都是 0-index 的。

在链表类中实现这些功能：

get(index)：获取链表中第 index 个节点的值。如果索引无效，则返回-1。
addAtHead(val)：在链表的第一个元素之前添加一个值为 val 的节点。插入后，新节点将成为链表的第一个节点。
addAtTail(val)：将值为 val 的节点追加到链表的最后一个元素。
addAtIndex(index,val)：在链表中的第 index 个节点之前添加值为 val  的节点。如果 index 等于链表的长度，则该节点将附加到链表的末尾。如果 index 大于链表长度，则不会插入节点。如果index小于0，则在头部插入节点。
deleteAtIndex(index)：如果索引 index 有效，则删除链表中的第 index 个节点。
 

示例：

MyLinkedList linkedList = new MyLinkedList();
linkedList.addAtHead(1);
linkedList.addAtTail(3);
linkedList.addAtIndex(1,2);   //链表变为1-> 2-> 3
linkedList.get(1);            //返回2
linkedList.deleteAtIndex(1);  //现在链表是1-> 3
linkedList.get(1);            //返回3
 

提示：

所有val值都在 [1, 1000] 之内。
操作次数将在  [1, 1000] 之内。
请不要使用内置的 LinkedList 库。
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyLinkedNode {

        public int val;
        public MyLinkedNode Next;
        public int index;
        public MyLinkedNode(int x) {
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
            if (list.Count==0)
            {
                return -1;
            }
            if (index<0||index>=list.Count)
            {
                return -1;
            }

            return list[index].val;

        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);

            if (list.Count==0)
            {
                list.Add(node);
            }
            else
            {
                list.Add(node);

                for (int index = list.Count-1; index >=0; index--)
                {
                    if (index==0)
                    {
                        list[index] = node;
                        break;
                    }
                    list[index] = list[index - 1];
                }

                node.Next = list[1];
            }
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);
            list.Add(node);

            if (list.Count>1)
            {
                list[list.Count - 2].Next = node;
            }
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            MyLinkedNode node = new MyLinkedNode(val);

            if (index>list.Count)
            {
                return;
            }

            if (index==list.Count)
            {
                
                list.Add(node);

                if (list.Count > 1)
                {
                    list[list.Count - 2].Next = node;
                }
                return;
            }
            if (index<=0)
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
                }
                return;
            }

            list.Add(node);

            for (int i = list.Count-1; i >=index ; i--)
            {
                if (i==index)
                {
                    list[i] = node;
                    break;
                }

                list[i] = list[i - 1];
            }

            list[index - 1].Next = node;
            node.Next = list[index + 1];


        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {

            if (list.Count == 0)
            {
                return;
            }

            if (index<0||index>=list.Count)
            {
                return;
            }

            if (index==0)
            {
                list.RemoveAt(index);
                return;
            }


            if (index==list.Count-1)
            {
                list.RemoveAt(index);
                list[list.Count - 1].Next = null;
                return;
            }

            list.RemoveAt(index);
            list[index - 1].Next = list[index];

        }
    }
}
