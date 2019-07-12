using Xunit.Abstractions;

namespace leetcode
{
    public class Solution
    {
        private readonly ITestOutputHelper Console;

        public Solution(ITestOutputHelper console)
        {
            Console = console;
        }
        
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                if (rev > int.MaxValue / 10 || rev == int.MaxValue / 10 && pop > 7) return 0;
                if (rev < int.MinValue / 10 || rev == int.MinValue / 10 && pop < -8) return 0;
                rev = rev * 10 + pop;
            }

            return rev;
        }
        
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
        
        public int RomanToInt(string number)
        {
            var result = 0;
            var index = 0;
            var previous = 0;
            while (index < number.Length)
            {
                var current = RomanToDigit(number[index]);

                if (current > previous)
                {
                    result += current - 2 * previous;
                }
                else
                {
                    result += current;
                }

                previous = current;
                index++;
            }

            return result;
        }
        
        private static int RomanToDigit(char digit)
        {
            switch (digit)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
    }
}