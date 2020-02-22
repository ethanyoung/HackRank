using System;
using System.Collections.Generic;
using System.Text;

namespace HackRank
{
    class RepeatedString
    {
        public static long repeatedString(string s, long n)
        {
            var numberOfOccurence = n / s.Length;
            var extraChars = n % s.Length;

            int numberOfOccurenceInString = 0;
            int numberOfOccurenceStoppedAtExtra = 0;
            int index = 0;
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    numberOfOccurenceInString++;
                }
                if (index + 1 == extraChars)
                {
                    numberOfOccurenceStoppedAtExtra = numberOfOccurenceInString;
                }
                index++;
            }

            long totalOccurence = numberOfOccurence * numberOfOccurenceInString + numberOfOccurenceStoppedAtExtra;
            return totalOccurence;
        }
    }
}
