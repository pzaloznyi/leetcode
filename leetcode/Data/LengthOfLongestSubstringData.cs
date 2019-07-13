using System.Collections;
using System.Collections.Generic;

namespace leetcode.Data
{
    public class LengthOfLongestSubstring : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {"abcabcbb", 3};
            yield return new object[] {"bbbbb", 1};
            yield return new object[] {"pwwkew", 3};
            yield return new object[] {"abcdabcdabcdzabc", 5};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}