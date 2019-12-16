using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计哈希集合
{/*设计哈希集合
不使用任何内建的哈希表库设计一个哈希集合

具体地说，你的设计应该包含以下的功能

add(value)：向哈希集合中插入一个值。
contains(value) ：返回哈希集合中是否存在这个值。
remove(value)：将给定值从哈希集合中删除。如果哈希集合中没有这个值，什么也不做。

示例:

MyHashSet hashSet = new MyHashSet();
hashSet.add(1);         
hashSet.add(2);         
hashSet.contains(1);    // 返回 true
hashSet.contains(3);    // 返回 false (未找到)
hashSet.add(2);          
hashSet.contains(2);    // 返回 true
hashSet.remove(2);          
hashSet.contains(2);    // 返回  false (已经被删除)

注意：

所有的值都在 [1, 1000000]的范围内。
操作的总数目在[1, 10000]范围内。
不要使用内建的哈希集合库。
    */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyHashSet
    {
        int[] data;
        /** Initialize your data structure here. */
        public MyHashSet()
        {
            data = new int[1000001];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = -1;
            }
        }

        public void Add(int key)
        {

            data[key] = key;
            
        }

        public void Remove(int key)
        {
            data[key] = -1;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            if (data[key]==-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    /**
     * Your MyHashSet object will be instantiated and called as such:
     * MyHashSet obj = new MyHashSet();
     * obj.Add(key);
     * obj.Remove(key);
     * bool param_3 = obj.Contains(key);
     */
}
