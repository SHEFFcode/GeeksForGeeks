using System;
using System.Collections.Generic;

namespace GeeksForGeeks.DataStructures
{
    public class CustomHash
    {
        List<Tuple<string, int>>[] container;
        int buckets = 8;
        int size;

        public CustomHash()
        {
            container = new List<Tuple<string, int>>[buckets];
            for (var i = 0; i < container.Length; i++)
            {
                container[i] = new List<Tuple<string, int>>();
            }
        }

        public int Hash(string inputToHash)
        {
            var hashCode = 5381;
            var charArrayInput = inputToHash.ToCharArray();
            for (var i = 0; i < inputToHash.Length; i++)
            {
                var character = charArrayInput[i];
                hashCode = ((hashCode << 5) + hashCode) + character;
            }
            return hashCode % buckets;
        }

        public void Insert(string key, int value)
        {
            var index = Hash(key);
            if (container[index].Count == 0) // the key has not been added yet.
            {
                container[index].Add(new Tuple<string, int>(key, value));
                size++;
            }
            else
            {
                var bucket = container[index];
                for (var i = 0; i < bucket.Count; i++)
                {
                    if (bucket[i].Item1 == key)
                    {
                        bucket[i] = new Tuple<string, int>(key, value); // we already have the key in the table, update the value.
                        return; // nothing else to be done here.
                    }
                }

                bucket.Add(new Tuple<string, int>(key, value)); // if we made it through the loop without finding a key, this is a new key
                size++;
            }
        }

        public int Delete(string key)
        {
            var index = Hash(key);
            if (container[index].Count == 0)
            {
                Console.WriteLine("Key not in hash table");
                return -1;
            }
            else
            {
                var bucket = container[index];
                for (var i = 0; i < bucket.Count; i++)
                {
                    if (bucket[i].Item1 == key) //key in tuple is equal to the key we are trying to delete
                    {
                        var item = bucket[i].Item2;
                        bucket.RemoveAt(i);
                        size--;
                        return item;
                    }
                }
            }
            Console.WriteLine("Key not in hash table");
            return -1;
        }

        public int Retrieve(string key)
        {
            var index = Hash(key);
            if (container[index].Count == 0)
            {
                Console.WriteLine("Key not in hash table.");
                return -1;
            }
            else 
            {
                var bucket = container[index];
                for (var i = 0; i < bucket.Count; i++)
                {
                    if (bucket[i].Item1 == key)
                    {
                        return bucket[i].Item2;
                    }
                }
            }
            Console.WriteLine("Key not in hash table.");
            return -1;
        }
    }
}
