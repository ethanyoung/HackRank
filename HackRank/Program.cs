using System;

namespace HackRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result = SockMerchant.sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
