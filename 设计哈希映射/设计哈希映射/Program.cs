using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计哈希映射
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyHashMap
    {
        int[] values;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            values = new int[1000001];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = -1;
            }
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            values[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return values[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            values[key] = -1;
        }
    }
}
