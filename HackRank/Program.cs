using System;

namespace HackRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sock Merchant");
            int n = 9;
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int result1 = SockMerchant.sockMerchant(n, ar);
            Console.WriteLine(result1);

            Console.WriteLine("Repeated String");
            string str = "aba";
            long numberOfChars = 10;
            long result2 = RepeatedString.repeatedString(str, numberOfChars);
            Console.WriteLine(result2);

        }
    }
}
