using System;
using System.Collections.Generic;

namespace DO11.MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("a", "b");
            dictionary.Add("b", "c");
            dictionary.Add("c", "d");
        }
    }

    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempKey = keys;
            V[] _tempValue = values;
            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                keys[i] = _tempKey[i];
                values[i] = _tempValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
