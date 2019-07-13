using System.Collections;
using System.Collections.Generic;
using leetcode.Entities;

namespace leetcode.Data
{
    public class AddTwoNumbersData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}},
                new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}},
                new ListNode(7) {next = new ListNode(0) {next = new ListNode(8)}}
            };

            yield return new object[]
            {
                new ListNode(5),
                new ListNode(5),
                new ListNode(0) {next = new ListNode(1)}
            };

            yield return new object[]
            {
                new ListNode(1) {next = new ListNode(8)},
                new ListNode(0),
                new ListNode(1) {next = new ListNode(8)}
            };

            yield return new object[]
            {
                new ListNode(1),
                new ListNode(9) {next = new ListNode(9)},
                new ListNode(0) {next = new ListNode(0) {next = new ListNode(1)}},
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}