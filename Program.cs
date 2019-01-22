using System;

namespace ConsoleApp3
{
    class Program
    {
        static int[] arr;
        static int triangle(int n)
        {
            if (n == 1) return 1;
            return n + triangle(n - 1);
        }
        static int factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * (n-1);
        }
        static int fibonnaci(int n)
        {
            if (n == 0 || n == 1) return 1;
            return fibonnaci(n - 1) + fibonnaci(n - 2);
        }
        static int fib(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            if (arr[n] != -1) return arr[n];
            arr[n] = fib(n - 1) + fib(n - 2);
            return arr[n];
        }
        static void printStars(int n)
        {
            if (n == 1) Console.WriteLine("*");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                printStars(n - 1);
            }
        }
        static void mergesort()
        {

        }
        static void Main(string[] args)
        {
            printStars(5);
            Console.WriteLine("Enter an integer: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(triangle(n));
            Console.WriteLine("Enter an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(x));
            Console.WriteLine("Enter an integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibonnaci(n));
            OrderedArray arr = new OrderedArray(10);
            arr.addLast(45);
            arr.addLast(25);
            arr.addLast(-7);
            Console.WriteLine(arr.listItems());
            arr.insertionSortAsc();
            Console.WriteLine(arr.listItems());
            Console.WriteLine("Enter an integer:");
            int z = Convert.ToInt32(Console.ReadLine());
            /*arr = new int[z+1];
            for(int x=0; x<z+1; )*/

            

            Console.ReadKey();
        }
    }
}
