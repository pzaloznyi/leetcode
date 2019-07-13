using FluentAssertions;
using leetcode.Data;
using Xunit;
using Xunit.Abstractions;

namespace leetcode
{
    public class EasyTasks
    {
        private readonly ITestOutputHelper _console;
        private readonly Solution _solution;

        public EasyTasks(ITestOutputHelper console)
        {
            _console = console;
            _solution = new Solution(_console);
        }

#region block1
        [Theory(DisplayName = "https://leetcode.com/problems/reverse-integer/description/")]
        [InlineData(1, 1)]
        [InlineData(10, 1)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        public void ReverseInteger(int actual, int expected)
        {
            _solution.Reverse(actual).Should().Be(expected);
        }

        [Theory(DisplayName = "https://leetcode.com/problems/palindrome-number/description/")]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        public void IsPalindrome(int actual, bool expected)
        {
            _solution.IsPalindrome(actual).Should().Be(expected);
        }

        [Theory(DisplayName = "https://leetcode.com/problems/roman-to-integer/")]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void RomanToInt(string actual, int expected)
        {
            _solution.RomanToInt(actual).Should().Be(expected);
        }
        
        [Theory]
        [ClassData(typeof(LongestCommonPrefixData))]
        public void LongestCommonPrefix(string[] strs, string expected)
        {
            _solution.LongestCommonPrefix(strs).Should().Be(expected);
        }
#endregion
    }
}