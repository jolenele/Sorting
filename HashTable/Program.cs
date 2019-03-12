using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTableQuad a = new HashTableQuad(10);
            a.insert("John");
            a.insert("Jane");
            a.insert("Saun");
            a.printTable();
            Console.ReadKey();
        }
    }
}
