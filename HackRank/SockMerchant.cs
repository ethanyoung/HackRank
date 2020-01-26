using System;
using System.Collections.Generic;
using System.Text;

namespace HackRank
{
    class SockMerchant
    {
        public static int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            HashSet<int> sockSet = new HashSet<int>();
            foreach (int sock in ar)
            {
                if (sockSet.Contains(sock))
                {
                    numberOfPairs++;
                    sockSet.Remove(sock);
                } else
                {
                    sockSet.Add(sock);
                }
            }
            return numberOfPairs;
        }   
    }
}
