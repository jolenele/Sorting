using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HashTableDouble
    {
        private string[] table;
        private int size;
        public HashTableDouble(int s)
        {
            size = s;
            table = new string[size];
            for (int i = 0; i < size; i++)
            {
                table[i] = "EMPTY";
            }
        }
        public int hashFunction(string key)
        {
            int value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i];
                //value +=s[i]*(x+2);
                //return value;
            }
            return value % size;
        }
        public int hashFunction2(string key)
        {
            int value = 0;
            for (int i = 0; i < key.Length; i++)
            {
                value += key[i] * (i + 2);
            }
            return value;
        }
        public void insert(string key)
        {
            int loc = hashFunction(key);
            int inc = hashFunction2(key);
            while (table[loc] != "EMPTY" && table[loc] != "DELETED")
            {
                loc = (loc + 1) % size;
            }
            table[loc] = key;
        }
        public void delete(string key)
        {
            int loc = hashFunction(key);
            while (table[loc] != "EMPTY" && table[loc] != key)
            {
                loc = (loc + 1) % size;
            }
            if (table[loc] != "EMPTY")
                table[loc] = "DELETED";
        }
        public int search(string key)
        {
            int loc = hashFunction(key);
            while (table[loc] != "EMPTY" && table[loc] != key)
            {
                loc = (loc + 1) % size;
            }
            if (table[loc] != "EMPTY")
                return loc;
            return -1;
        }
        public void printTable()
        {
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i] + "\n");
            }
        }
    }
}
