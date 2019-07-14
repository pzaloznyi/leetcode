using FluentAssertions;
using leetcode.Data;
using leetcode.Entities;
using Xunit;
using Xunit.Abstractions;

namespace leetcode
{
    public class MediumTasks
    {
        private readonly ITestOutputHelper _console;
        private readonly Solution _solution;

        public MediumTasks(ITestOutputHelper console)
        {
            _console = console;
            _solution = new Solution(_console);
        }
        
#region 1
        [Theory(DisplayName = "https://leetcode.com/problems/add-two-numbers/")]
        [ClassData(typeof(AddTwoNumbersData))]
        public void AddTwoNumbers(ListNode l1, ListNode l2, ListNode expected)
        {
            _solution.AddTwoNumbers(l1, l2).Should().BeEquivalentTo(expected);
        }

        [Theory(DisplayName = "https://leetcode.com/problems/longest-substring-without-repeating-characters/")]
        [ClassData(typeof(LengthOfLongestSubstring))]
        public void LengthOfLongestSubstring(string input, int expected)
        {
            _solution.LengthOfLongestSubstring(input).Should().Be(expected);
        }

        [Theory(DisplayName = "https://leetcode.com/problems/zigzag-conversion/")]
        [InlineData("PAYPALISHIRING", 2, "PYAIHRNAPLSIIG")]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("PAYPALISHIRING", 5, "PHASIYIRPLIGAN")]
        [InlineData("PAYPALISHIRING", 6, "PRAIIYHNPSGAIL")]
        [InlineData("PAYP", 3, "PAPY")]
        [InlineData("A", 2, "A")]
        [InlineData("AB", 1, "AB")]
        public void ZigZagConversion(string input, int rows, string output)
        {
            _solution.Convert(input, rows).Should().Be(output);
        }
#endregion
    }
}