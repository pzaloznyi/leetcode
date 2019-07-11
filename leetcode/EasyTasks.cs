using FluentAssertions;
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
        
        [Theory(DisplayName = "https://leetcode.com/problems/reverse-integer/description/")]
        [InlineData(1, 1)]
        [InlineData(10, 1)]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        public void ReverseInteger(int actual, int expected)
        {
            _solution.Reverse(actual).Should().Be(expected);
        }
    }
}