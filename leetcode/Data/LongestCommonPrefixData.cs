using System.Collections;
using System.Collections.Generic;

namespace leetcode.Data
{
    public class LongestCommonPrefixData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
//            yield return new object[] {new string[0], ""};
            yield return new object[] {new[] {"a"}, "a"};
//            yield return new object[] {new[] {"flower", "flow", "flight"}, "fl"};
//            yield return new object[] {new[] {"dog","racecar","car"}, ""};
//            yield return new object[] {new[] {"abb","abc"}, "ab"};
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}