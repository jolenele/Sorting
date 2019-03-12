using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class HashTableQuad
    {
        private string[] table;
        private int size;
        public HashTableQuad(int s)
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
            }
            return value % size;
        }
        public void insert(string key)
        {
            int loc = hashFunction(key);
            int newLoc = loc;
            int count = 1;
            while (table[loc] != "EMPTY" && table[loc] != "DELETED")
            {
                newLoc = (loc + count*count) % size;
                count++;
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
