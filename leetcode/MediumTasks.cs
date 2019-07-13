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
        
        //
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
    }
}