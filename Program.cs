using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UnOrderedArray ua = new UnOrderedArray(10);
            ua.addLast(23);
            ua.addLast(-43);
            ua.addLast(10);
            ua.addLast(16);
            ua.addLast(20);
            ua.addLast(50);
            ua.addLast(6);
            ua.addLast(-15);
            ua.addLast(100);
            ua.addLast(99);
            ua.printList();
            ua.andrew();
            Console.WriteLine("\n");
            ua.printList();
            Console.WriteLine("\n"+ua.BinarySearch(100));
            Console.ReadKey();
        }
    }
}
